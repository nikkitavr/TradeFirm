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
    public partial class ShopManagment : Form
    {
        OleDbConnection cn;

        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataAdapter da2;
        DataTable dt2;
        String username;
        bool shopRowHasChoosen = false;
        bool shipmentRowHasChoosen = false;
        public ShopManagment(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;

            dg_shop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_shop.ReadOnly = true;
            dg_shop.AllowUserToAddRows = false;

            dg_shipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_shipments.ReadOnly = true;
            dg_shipments.AllowUserToAddRows = false;

            btn_accept.Hide();
            btn_shipToStorage.Hide();
            btn_unload.Hide();
            btn_shipToStorage2.Hide();

        }

        private void ShopManagment_Load(object sender, EventArgs e)
        {
            dg_shipmentsUpdate();
            dg_shopUpdate();


        }

        private void dg_shipmentsUpdate()
        {
            if (da2 != null) da2.Dispose();
            if (dt2 != null) dt2.Dispose();

            String todays = "";
            String today_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
            if (chb_onlyToday.Checked) todays = " AND Shipments.deliveryDate = " + "'" + today_date + "'";

            da2 = new OleDbDataAdapter("SELECT Orders.id AS 'Номер заказа', Shipments.deliveryDate AS 'Дата доставки', " +
                "OrderStatus.title AS 'Статус' FROM Orders JOIN Shipments ON Orders.shipmentId = Shipments.id " +
                "JOIN OrderStatus ON Orders.statusId = OrderStatus.id " +
                "WHERE (OrderStatus.title = 'Доставляется' OR OrderStatus.title = 'Отменен')" + todays, cn);
            dt2 = new DataTable("Shipments");
            da2.Fill(dt2);

            dg_shipments.DataSource = dt2;

        }

        private void dg_shopUpdate()
        {
            if (da != null) da.Dispose();
            if (dt != null) dt.Dispose();

            da = new OleDbDataAdapter("SELECT Orders.id AS 'Номер заказа', Shipments.deliveryDate AS 'Дата доставки', " +
                "OrderStatus.title AS 'Статус', OrderDetails.maxShelfDays AS 'Срок хранения' " +
                "FROM Orders JOIN Shipments ON Orders.shipmentId = Shipments.id " +
                "JOIN OrderDetails ON OrderDetails.orderId = Orders.id " +
                "JOIN OrderStatus ON Orders.statusId = OrderStatus.id " +
                "WHERE OrderStatus.title = 'Ожидает' OR OrderStatus.title = 'Просрочен'", cn);
            dt = new DataTable("Storage");
            da.Fill(dt);

            dg_shop.DataSource = dt;
        }

        private void dg_shop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_orderId.Text = dg_shop.SelectedRows[0].Cells["Номер заказа"].Value.ToString();
            txt_deliveryDate.Text = dg_shop.SelectedRows[0].Cells["Дата доставки"].Value.ToString();
            txt_status.Text = dg_shop.SelectedRows[0].Cells["Статус"].Value.ToString();
            txt_shelfDate.Text = DateTime.Parse(txt_deliveryDate.Text).AddDays(int.Parse(dg_shop.SelectedRows[0].Cells["Срок хранения"].Value.ToString())).ToString("yyyy-MM-dd");

            if(DateTime.Compare(DateTime.Today, DateTime.Parse(txt_shelfDate.Text)) > 0)
            {
                btn_accept.Hide();
                btn_shipToStorage.Show();
            } else
            {
                btn_accept.Show();
                btn_shipToStorage.Hide();
            }

            shopRowHasChoosen = true;
        }

        private void dg_shipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_orderId2.Text = dg_shipments.SelectedRows[0].Cells["Номер заказа"].Value.ToString();
            txt_deliveryDate2.Text = dg_shipments.SelectedRows[0].Cells["Дата доставки"].Value.ToString();
            txt_status2.Text = dg_shipments.SelectedRows[0].Cells["Статус"].Value.ToString();
            if(txt_status2.Text == "Отменен")
            {
                btn_unload.Hide();
                btn_shipToStorage2.Show();
                
            } else
            {
                btn_unload.Show();
                btn_shipToStorage2.Hide();
            }

            shipmentRowHasChoosen = true;
        }

        private void chb_onlyToday_CheckedChanged(object sender, EventArgs e)
        {
            dg_shipmentsUpdate();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if(txt_orderId.Text == "")
            {
                MessageBox.Show("Сначала выберите заказ", "Ошибка");
                return;
            }

            OleDbCommand cmnd = new OleDbCommand("EXEC acceptOrder ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters[0].Value = txt_orderId.Text;

            try
            {
                cmnd.ExecuteNonQuery();
                txt_orderId.Text = "";
                txt_deliveryDate.Text = "";
                txt_status.Text = "";
                txt_shelfDate.Text = "";
                btn_accept.Hide();
                shopRowHasChoosen = false;
                dg_shipmentsUpdate();
                dg_shopUpdate();
                MessageBox.Show("Получение товара покупателем подтверждено", "Успех");
            } catch(OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void btn_unload_Click(object sender, EventArgs e)
        {
            if (txt_orderId2.Text == "")
            {
                MessageBox.Show("Сначала выберите заказ", "Ошибка");
                return;
            }

            if (txt_deliveryDate2.Text != DateTime.Today.Date.ToString("yyyy-MM-dd") && MessageBox.Show("Дата получения заказа в журнале не соответсвует сегодняшней дате. Вы уверены, что хотите разгрузить?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                return;

            }

            OleDbCommand cmnd = new OleDbCommand("EXEC dockShipmnetShop ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters[0].Value = txt_orderId2.Text;


            try
            {
                cmnd.ExecuteNonQuery();
                txt_orderId2.Text = "";
                txt_deliveryDate2.Text = "";
                txt_status2.Text = "";
                btn_unload.Hide();
                shipmentRowHasChoosen = false;
                dg_shipmentsUpdate();
                dg_shopUpdate();
                MessageBox.Show("Прибытие заказа покупателя подтверждено", "Успех");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }



        }

        private void btn_shipToStorage_Click(object sender, EventArgs e)
        {
            OleDbCommand cmnd = new OleDbCommand("EXEC shipBackExpired ?, ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 30);
            cmnd.Parameters[0].Value = txt_orderId.Text;
            cmnd.Parameters[1].Value = username;

            try
            {
                cmnd.ExecuteNonQuery();
                txt_orderId2.Text = "";
                txt_deliveryDate2.Text = "";
                txt_status2.Text = "";
                btn_unload.Hide();
                shopRowHasChoosen = false;
                dg_shipmentsUpdate();
                dg_shopUpdate();
                MessageBox.Show("Заказ отправлен обратно на склад", "Успех");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void btn_shipToStorage2_Click(object sender, EventArgs e)
        {

            if (DateTime.Compare(DateTime.Today, DateTime.Parse(txt_deliveryDate2.Text)) < 0 && MessageBox.Show("Дата получения заказа в журнале не соответсвует сегодняшней дате. Вы уверены, что хотите разгрузить?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            OleDbCommand cmnd = new OleDbCommand("EXEC shipBackCancelled ?, ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 30);
            cmnd.Parameters[0].Value = txt_orderId2.Text;
            cmnd.Parameters[1].Value = username;

            try
            {
                cmnd.ExecuteNonQuery();
                txt_orderId2.Text = "";
                txt_deliveryDate2.Text = "";
                txt_status2.Text = "";
                btn_unload.Hide();
                shipmentRowHasChoosen = false;
                dg_shipmentsUpdate();
                dg_shopUpdate();
                MessageBox.Show("Заказ отправлен обратно на склад", "Успех");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void changeStatus(String orderId, String status)
        {
            OleDbCommand cmnd = new OleDbCommand("EXEC changeOrderStatus ?, ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.Integer);
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 15);
            cmnd.Parameters[0].Value = orderId;
            cmnd.Parameters[1].Value = status;
            try
            {
                cmnd.ExecuteNonQuery();
            } catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, при изенении статуса заказа.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void update_dgs_Tick(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_shop.Rows)
            {
                String rowD = row.Cells["Дата доставки"].Value.ToString();
                String rowS = row.Cells["Статус"].Value.ToString();
                DateTime dTime = DateTime.Parse(rowD);
                DateTime toTime = dTime.AddDays(int.Parse(row.Cells["Срок хранения"].Value.ToString()));
                if(rowS != "Просрочен" && DateTime.Compare(DateTime.Today, toTime) > 0)
                {
                    String rowOrderId = row.Cells["Номер заказа"].Value.ToString();
                    changeStatus(rowOrderId, "Просрочен");
                    OleDbCommand cmnd = new OleDbCommand("EXEC copyToExpired ?", cn);
                    cmnd.Parameters.Add("@p1", OleDbType.Integer);
                    cmnd.Parameters[0].Value = rowOrderId;

                    try
                    {
                        cmnd.ExecuteNonQuery();
                    } catch (OleDbException exc)
                    {
                        MessageBox.Show("Произошла ошибка базы данных, при добавлении в таблицу просроченных заказов.\n" + exc.Message, "Ошибка");
                    }

                }
            }
            dg_shipmentsUpdate();
            dg_shopUpdate();
            checkAlreadyDel();
            checkCancelled();

            if (shopRowHasChoosen && DateTime.Compare(DateTime.Today, DateTime.Parse(txt_shelfDate.Text)) > 0)
            {
                btn_accept.Hide();
                btn_shipToStorage.Show();
            }
            else
            {
                btn_accept.Show();
                btn_shipToStorage.Hide();
            }

            if (shipmentRowHasChoosen && txt_status2.Text == "Отменен")
            {
                btn_unload.Hide();
                btn_shipToStorage2.Show();
                
            }
            else
            {
                btn_unload.Show();
                btn_shipToStorage2.Hide();
            }
        }

        private void checkCancelled()
        {
            bool isCancelled = true;
            foreach (DataGridViewRow row in dg_shop.Rows)
            {
                if (row.Cells["Номер заказа"].Value.ToString() == txt_orderId.Text)
                {
                    isCancelled = false;
                    break;
                }
            }

            if (isCancelled)
            {
                shopRowHasChoosen = false;
            }
        }

        private void checkAlreadyDel()
        {
            String currentId1 = txt_orderId.Text;
            String currentId2 = txt_orderId2.Text;
            bool was = false;
            if(currentId1 != "")
            {
                foreach(DataGridViewRow row in dg_shop.Rows)
                {
                    if(row.Cells["Номер заказа"].Value.ToString() == txt_orderId.Text)
                    {
                        txt_status.Text = row.Cells["Статус"].Value.ToString();
                        was = true;
                    }
                }
                if (!was)
                {
                    txt_orderId.Text = "";
                    txt_deliveryDate.Text = "";
                    txt_shelfDate.Text = "";
                    txt_status.Text = "";
                }
            }
            was = false;
            if (currentId2 != "")
            {
                foreach (DataGridViewRow row in dg_shipments.Rows)
                {
                    if (row.Cells["Номер заказа"].Value.ToString() == txt_orderId2.Text)
                    {
                        txt_status2.Text = row.Cells["Статус"].Value.ToString();
                        was = true;
                    }
                }
                if (!was)
                {
                    txt_orderId2.Text = "";
                    txt_deliveryDate2.Text = "";
                    txt_status2.Text = "";
                }
            }

        }
    }
}
