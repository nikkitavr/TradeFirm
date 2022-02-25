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

namespace DBCourseEmployees
{
    public partial class StorageManagment : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataAdapter da2;
        DataTable dt2;
        String shipmentDate = "";
        String shipmentId = "";
        bool isAlreadyOrdered;
        String username;
        public StorageManagment(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;

            dg_storage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_storage.ReadOnly = true;
            dg_storage.AllowUserToAddRows = false;

            dg_shipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_shipments.ReadOnly = true;
            dg_shipments.AllowUserToAddRows = false;
        }

        private void dgStorage_update()
        {
            if (da != null) da.Dispose();
            if (dt != null) dt.Dispose();

            da = new OleDbDataAdapter("SELECT Storage.id AS 'Номер на складе', Products.id as 'Артикул фирмы', " +
                "ProductDetails.title AS 'Название', Storage.quantity AS 'Количество', " +
                "CASE WHEN Shipments.id IS NOT NULL THEN 'Да' ELSE 'Нет' END AS 'Товар заказан' FROM Storage " +
                "JOIN Products ON Storage.productId = Products.id JOIN ProductDEtails ON ProductDetails.productId = Products.id " +
                "LEFT JOIN Shipments ON Products.id = Shipments.productId AND Shipments.destination = 1" +
                "WHERE Products.supplierId IS NOT NULL", cn);
            dt = new DataTable("Storage");
            da.Fill(dt);

            dg_storage.DataSource = dt;

        }

        private void dgShipments_update()
        {
            if (da2 != null) da2.Dispose();
            if (dt2 != null) dt2.Dispose();

            String todays = "";
            String today_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
            if (chb_onlyToday.Checked) todays = " AND Shipments.deliveryDate = " + "'" + today_date + "'";

            da2 = new OleDbDataAdapter("SELECT Shipments.id AS 'Номер поставки', Shipments.productId AS 'Артикул фирмы', " +
                "ProductDetails.title AS 'Название', Shipments.quantity AS 'Количество', Shipments.deliveryDate AS 'Дата поступления' FROM Shipments " +
                "JOIN ProductDetails ON Shipments.productId = ProductDetails.productId WHERE Shipments.destination = 1" + todays, cn);
            dt2 = new DataTable("Shipments");
            da2.Fill(dt2);

            dg_shipments.DataSource = dt2;
        }

    

        private void StorageManagment_Load(object sender, EventArgs e)
        {
            dgStorage_update();
            dgShipments_update();
           
        }

        private void dg_storage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_storage.SelectedRows[0].Cells["Артикул фирмы"].Value.ToString();
            txt_title.Text = dg_storage.SelectedRows[0].Cells["Название"].Value.ToString();
            txt_num.Text = dg_storage.SelectedRows[0].Cells["Количество"].Value.ToString();

            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT capacity FROM Products JOIN ProductDetails " +
                "ON productId = Products.id WHERE Products.id = " + txt_id.Text, cn);
            DataTable dtTemp = new DataTable("Capacity");
            daTemp.Fill(dtTemp);

            lbl_capacity.Text = (dtTemp.Rows[0])["capacity"].ToString();
            isAlreadyOrdered = dg_storage.SelectedRows[0].Cells["Товар заказан"].Value.ToString() == "Да"; 
        }


        private void btn_makeOrder_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Сначала выберите товар", "Ошибка");
                return;
            }

            if (int.Parse(txt_num.Text) >= int.Parse(lbl_capacity.Text) / 2)
            {
                MessageBox.Show("Чтобы заказать обновление данного товара, его количество на складе " +
                    "должно быть меньше чем половина вместимости", "Ошибка");
                return;
            }

            if (isAlreadyOrdered)
            {
                MessageBox.Show("Товар уже был заказан раннее (см. на вкладке 'Поступления')", "Ошибка");
                return;
            }

            int bit = 0;
            if (checkBox_testMode.Checked) bit = 1;
            
            OleDbCommand cmnd = new OleDbCommand("EXEC orderSupplier ?, ?, ?, ?", cn);
            cmnd.Parameters.Add("@p4", OleDbType.VarChar, 30);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters.Add("@p2", OleDbType.Integer);
            cmnd.Parameters.Add("@p3", OleDbType.SmallInt);

            cmnd.Parameters[0].Value = username;
            cmnd.Parameters[1].Value = txt_id.Text;
            cmnd.Parameters[2].Value = (int.Parse(lbl_capacity.Text) - int.Parse(txt_num.Text)).ToString();
            cmnd.Parameters[3].Value = bit.ToString();


            try
            {
                cmnd.ExecuteNonQuery();
                txt_id.Text = "";
                txt_title.Text = "";
                txt_num.Text = "";
                dgShipments_update();
                dgStorage_update();
                MessageBox.Show("Заказ на обновление ассортимента успешно оформлен", "Успех!");
            } catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }



        }

        private void dg_shipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id2.Text = dg_shipments.SelectedRows[0].Cells["Артикул фирмы"].Value.ToString();
            txt_title2.Text = dg_shipments.SelectedRows[0].Cells["Название"].Value.ToString();
            txt_count2.Text = dg_shipments.SelectedRows[0].Cells["Количество"].Value.ToString();

            shipmentDate = dg_shipments.SelectedRows[0].Cells["Дата поступления"].Value.ToString();
            shipmentId = dg_shipments.SelectedRows[0].Cells["Номер поставки"].Value.ToString();

        }

        private void btn_dock_Click(object sender, EventArgs e)
        {
            if(txt_id2.Text == "")
            {
                MessageBox.Show("Сначала выберите поставку", "Ошибка");
                return;
            }

            if(shipmentDate != DateTime.Today.Date.ToString("yyyy-MM-dd") && MessageBox.Show("Дата поставки в журнале не соответсвует сегодняшней дате. Вы уверены, что хотите разгрузить?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                
                return;
              
            }


            OleDbCommand cmnd = new OleDbCommand("EXEC dockShipmentStorage ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters[0].Value = shipmentId;
            

            try
            {
                cmnd.ExecuteNonQuery();
                txt_id2.Text = "";
                txt_title2.Text = "";
                txt_count2.Text = "";
                dgShipments_update();
                dgStorage_update();
                MessageBox.Show("Поставка успешно разгружена на складе", "Успех!");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }



        }

        private void chb_onlyToday_CheckedChanged(object sender, EventArgs e)
        {
            dgShipments_update();
        }
    }
}
