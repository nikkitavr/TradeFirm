using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBCourseClients
{
    public partial class Orders : Form
    {
        OleDbConnection cn;
        DataTable dtFull;
        int currentOrderId;
        public Orders(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            lbl_shelf.Hide();
            txt_shelfDate.Hide();
            btn_terminate.Hide();

            dg_orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_orders.ReadOnly = true;
            dg_orders.AllowUserToAddRows = false;

            dgUpdate();
            fullTableUpdate();
        }


        private void dgUpdate()
        {
            OleDbCommand cmnd = new OleDbCommand("SELECT Orders.id AS 'Номер заказа', ProductDetails.title AS 'Название', " +
                "OrderDetails.orderDate AS 'Дата заказа', OrderStatus.title AS 'Статус' FROM Orders " +
                "JOIN OrderDetails ON OrderDetails.orderId = Orders.id JOIN ProductDetails ON Orders.productId = ProductDetails.productId JOIN " +
                "OrderStatus ON Orders.statusId = OrderStatus.id WHERE OrderStatus.title != ? AND " +
                "OrderStatus.title != ? AND Orders.clientId = (SELECT MAX(id) FROM Clients WHERE phone = ?) " +
                "UNION ALL " +
                "SELECT ExpiredOrders.id AS 'Номер заказа', ExpiredOrders.titile AS 'Название', " +
                "ExpiredOrders.orderDate AS 'Дата заказа', ExpiredOrders.statusTitle AS 'Статус' FROM ExpiredOrders " +
                "WHERE ExpiredOrders.clientId = (SELECT MAX(id) FROM Clients WHERE phone = ?)", cn);
            cmnd.Parameters.Add("@p1", OleDbType.VarChar, 15);
            cmnd.Parameters[0].Value = "Отменен";
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 15);
            cmnd.Parameters[1].Value = "Просрочен";
            cmnd.Parameters.Add("@p3", OleDbType.VarChar, 11);
            cmnd.Parameters[2].Value = Program.username;
            cmnd.Parameters.Add("@p4", OleDbType.VarChar, 11);
            cmnd.Parameters[3].Value = Program.username;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmnd;
            DataTable dt = new DataTable("Orders");
            da.Fill(dt);

            dg_orders.DataSource = dt;
        }

        private void fullTableUpdate()
        {
            if (dtFull != null) dtFull.Dispose();
            OleDbCommand cmnd = new OleDbCommand("SELECT Orders.id as id, Shipments.quantity as quantity, " +
                "OrderDetails.finalPrice as fPrice, Shipments.deliveryDate as dDate, maxShelfDays as storageTo FROM " +
                "Orders JOIN OrderDetails ON Orders.id = OrderDetails.orderId JOIN Shipments ON Orders.shipmentId = Shipments.id WHERE " +
                "Orders.clientId = (SELECT MAX(id) FROM Clients WHERE phone = ?)", cn);
            cmnd.Parameters.Add("@p1", OleDbType.VarChar, 11);
            cmnd.Parameters[0].Value = Program.username;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmnd;
            dtFull = new DataTable("Details");
            da.Fill(dtFull);
        }

        private void dg_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String status = dg_orders.SelectedRows[0].Cells["Статус"].Value.ToString();
            String orderId = dg_orders.SelectedRows[0].Cells["Номер заказа"].Value.ToString();
            if (status != "Отправлен обратно на склад")
            {
                txt_status.Text = status;
                txt_title.Text = dg_orders.SelectedRows[0].Cells["Название"].Value.ToString();
                txt_orderDate.Text = dg_orders.SelectedRows[0].Cells["Дата заказа"].Value.ToString();
                txt_status.Text = dg_orders.SelectedRows[0].Cells["Статус"].Value.ToString();

                currentOrderId = int.Parse(orderId);
                txt_num.Text = chooseById(currentOrderId, "quantity");
                txt_price.Text = chooseById(currentOrderId, "fPrice");
                txt_deliveryDate.Text = chooseById(currentOrderId, "dDate");

                btn_terminate.Show();

                if (txt_status.Text == "Ожидает") //?
                {
                    lbl_shelf.Show();
                    txt_shelfDate.Show();
                    txt_shelfDate.Text = DateTime.Parse(txt_deliveryDate.Text).AddDays(int.Parse(chooseById(currentOrderId, "storageTo"))).ToString("yyyy-MM-dd"); //DateTime.Today.Date.ToString("yyyy-MM-dd")
                }
                return;
            }
            MessageBox.Show("Вы не забрали ваш заказ из магазина вовремя, и, к сожалению, нам пришлось отправить " +
                "его обратно на склад. В скором времени вы сможете снова увидеть этот товар в каталоге");
            OleDbCommand cmnd = new OleDbCommand("DELETE ExpiredOrders WHERE id = ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters[0].Value = orderId;
            try
            {
                cmnd.ExecuteNonQuery();
                dgUpdate();
                fullTableUpdate();

            } catch(OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private String chooseById(int id, String col)
        {
            DataRow row = (dtFull.Select("id = '" + id + "'"))[0];
            return row[col].ToString();
        }

        private void btn_terminate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите отменить заказ?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            OleDbCommand cmnd = new OleDbCommand("UPDATE Orders SET statusId = (SELECT MAX(id) FROM OrderStatus WHERE title = ?) " +
                "WHERE id = ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.VarChar, 15);
            cmnd.Parameters.Add("@p2", OleDbType.Integer);
            cmnd.Parameters[0].Value = "Отменен";
            cmnd.Parameters[1].Value = currentOrderId.ToString();

            try
            {
                cmnd.ExecuteNonQuery();
                dgUpdate();
                fullTableUpdate();
                txt_title.Text = "";
                txt_orderDate.Text = "";
                txt_status.Text = "";

                currentOrderId = -1;
                txt_num.Text = "";
                txt_price.Text = "";
                txt_deliveryDate.Text = "";

                btn_terminate.Hide();
                lbl_shelf.Hide();
                txt_shelfDate.Hide();
                MessageBox.Show("Заказ отменен","Успех");
            } catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }
    }
}
