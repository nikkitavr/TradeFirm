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
    public partial class Catalog : Form
    {
        OleDbConnection cn;
        String currentProductId = "";
        bool isSelected = false;
        bool bSpFlag = false;
        String filter = "";

        public Catalog(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;

            dg_catalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_catalog.ReadOnly = true;
            dg_catalog.AllowUserToAddRows = false;

            cb_filter.SelectedItem = "Названию";

        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            updateDataGreed();
            lbl_1.Hide();
            lbl_2.Hide();
            lbl_3.Hide();
            txt_num.Hide();
            txt_fPrice.Hide();
            txt_deliveryDate.Hide();
            btn_confirm.Hide();
            lbl_warning.Hide();
            updateCatalog.Enabled = true;
        }

        private void updateDataGreed()
        {
            if(isSelected && dg_catalog.SelectedRows.Count > 0)
            {
                currentProductId = dg_catalog.SelectedRows[0].Cells["Артикул Фирмы"].Value.ToString();
            }
            
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM FirmCatalog", cn);
            DataTable dt = new DataTable("Catalog");
            da.Fill(dt);
            DataView dv = dt.DefaultView;

            switch (filter)
            {
                case "":
                    dg_catalog.DataSource = dt;
                    break;
                case "Названию":
                    if(txt_search.Text == "")
                    {
                        dg_catalog.DataSource = dt;
                        break;
                    }
                    dv.RowFilter = string.Format("[Название товара] like '%{0}%'", txt_search.Text);
                    dg_catalog.DataSource = dv.ToTable();
                    break;
                case "Артикулу фирмы":
                    if (txt_search.Text == "")
                    {
                        dg_catalog.DataSource = dt;
                        break;
                    }
                    dv.RowFilter = string.Format("[Артикул фирмы] = '{0}'", txt_search.Text);
                    dg_catalog.DataSource = dv.ToTable();
                    break;
            }

            if (currentProductId != "")
            {
                foreach (DataGridViewRow row in dg_catalog.Rows)
                {
                    if (row.Cells["Артикул Фирмы"].Value.ToString() == currentProductId) row.Selected = true;
                    else row.Selected = false;
                }
            }
        }

        private void updateCatalog_Tick(object sender, EventArgs e)
        {

            updateCatalogTime();
        }

        private void updateCatalogTime()
        {
            updateDataGreed();
            if(txt_title.Text != "") checkDel();
            if (isSelected) txt_capacity.Text = dg_catalog.SelectedRows[0].Cells["Количество"].Value.ToString();
        }

        private void checkDel()
        {
            bool isExist = false;
            foreach(DataGridViewRow row in dg_catalog.Rows)
            {
                if(row.Cells["Артикул Фирмы"].Value.ToString() == currentProductId)
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                clearAll();
                MessageBox.Show("К сожалению, последнюю единцу выбранного вами товара уже кто-то заказал");
            }
        }

        private void dg_catalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentProductId = dg_catalog.SelectedRows[0].Cells["Артикул Фирмы"].Value.ToString();
            txt_title.Text = dg_catalog.SelectedRows[0].Cells["Название товара"].Value.ToString() +
                " (" + currentProductId + ")";
            txt_price.Text = dg_catalog.SelectedRows[0].Cells["Цена"].Value.ToString();
            txt_capacity.Text = dg_catalog.SelectedRows[0].Cells["Количество"].Value.ToString();
            isSelected = true;
            lbl_1.Hide();
            lbl_2.Hide();
            lbl_3.Hide();
            txt_num.Hide();
            txt_fPrice.Hide();
            txt_deliveryDate.Hide();
            btn_confirm.Hide();
            txt_num.Text = "";
            txt_fPrice.Text = "";
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if(txt_title.Text == "")
            {
                MessageBox.Show("Сначала выберите товар", "Внимание!");
                return;
            }

            if(Program.username == "")
            {
                MessageBox.Show("Для продолжения необходимо войти в систему или зарегестрироваться");
                LoginForm login = new LoginForm(cn);
                login.Show();
                return;
            }

            lbl_1.Show();
            lbl_2.Show();
            lbl_3.Show();
            txt_num.Show();
            txt_fPrice.Show();
            txt_deliveryDate.Show();
            btn_confirm.Show();

            int deliveryToShopTimeDays = 3;
            txt_deliveryDate.Text = DateTime.Today.Date.AddDays(deliveryToShopTimeDays).ToString("yyyy-MM-dd");
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_num.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsControl(number))
            {
                if(txt_fPrice.Text != "warning") txt_num.Text = txt_num.Text + e.KeyChar;

            } else if (bSpFlag) {
                if(txt_num.Text != "") txt_num.Text = txt_num.Text.Remove(txt_num.Text.Length - 1);
                
            }
            if (txt_num.Text == "") txt_fPrice.Text = "";
            else
            {
                int num;
                bool isOverFlow = !int.TryParse(txt_num.Text, out num);
                isOverFlow =  isOverFlow || int.Parse(txt_num.Text) * int.Parse(txt_price.Text) < 0 || (int.MaxValue - int.Parse(txt_num.Text) * int.Parse(txt_price.Text)) < 0;
                if(isOverFlow)
                {
                    txt_fPrice.Text = "warning";
                    lbl_2.Hide();
                    lbl_3.Hide();
                    txt_fPrice.Hide();
                    txt_deliveryDate.Hide();
                    lbl_warning.Show();

                } else
                {
                    txt_fPrice.Text = (int.Parse(txt_num.Text) * int.Parse(txt_price.Text)).ToString();
                    lbl_1.Show();
                    lbl_2.Show();
                    lbl_3.Show();
                    txt_num.Show();
                    txt_fPrice.Show();
                    txt_deliveryDate.Show();
                    lbl_warning.Hide();
                }
                
            }

            txt_num.SelectionStart = txt_num.Text.Length;
            e.Handled = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(txt_num.Text == "")
            {
                MessageBox.Show("Необходимо выбрать количество", "Внимание!");
                return;
            }

            updateCatalogTime();
            if (int.Parse(txt_num.Text) > int.Parse(txt_capacity.Text))
            {
                MessageBox.Show("На складе нет необходимого количества", "Внимание!");
                return;
            }

            if(txt_fPrice.Text == "warning")
            {
                
                String email = "";
                OleDbCommand cmnd = new OleDbCommand("SELECT email FROM Employees JOIN Posts ON postId = Posts.id WHERE Posts.title = ?", cn);
                cmnd.Parameters.Add("@p1", OleDbType.VarChar, 30);
                cmnd.Parameters[0].Value = "Управляющий компании";
                OleDbDataReader rdr = cmnd.ExecuteReader();
                if (rdr.Read()) email = rdr["email"].ToString();
                rdr.Close();
                MessageBox.Show("Направьте ваше обращение с данными по заказу на этот адрес электронной почты: " + email, "Внимание!");
                clearAll();
                return;
            }
            String bit = "0";
            if (chb_isTest.Checked)
            {
                bit = "1";
            }
            OleDbCommand cmnd2 = new OleDbCommand("EXEC orderClient ?, ?, ?, ?", cn);
            cmnd2.Parameters.Add("@p1", OleDbType.VarChar, 30);
            cmnd2.Parameters.Add("@p2", OleDbType.Integer);
            cmnd2.Parameters.Add("@p3", OleDbType.Integer);
            cmnd2.Parameters.Add("@p4", OleDbType.SmallInt);
            cmnd2.Parameters[0].Value = Program.username;
            cmnd2.Parameters[1].Value = currentProductId;
            cmnd2.Parameters[2].Value = txt_num.Text;
            cmnd2.Parameters[3].Value = bit;

            try
            {
                cmnd2.ExecuteNonQuery();
                clearAll();
                MessageBox.Show("Заказ успешно оформлен", "Успех");
                return;

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }


        }

        private void txt_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                bSpFlag = true;
            else
                bSpFlag = false;
        }

        private void clearAll()
        {
            foreach (DataGridViewRow row in dg_catalog.Rows)
            {
                row.Selected = false;
                

            }
            isSelected = false;
            currentProductId = "";
            txt_title.Text = "";
            txt_price.Text = "";
            txt_capacity.Text = "";
            txt_num.Text = "";
            txt_fPrice.Text = "";
            txt_deliveryDate.Text = "";
            lbl_1.Hide();
            lbl_2.Hide();
            lbl_3.Hide();
            txt_num.Hide();
            txt_fPrice.Hide();
            txt_deliveryDate.Hide();
            lbl_warning.Hide();
            btn_confirm.Hide();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (cb_filter.SelectedItem.ToString() == "Артикулу фирмы")
            {
                char symb = e.KeyChar;
                if (!Char.IsDigit(symb) && !Char.IsControl(symb))
                {
                    e.Handled = true;
                }
            }
          
        }

        private void cb_filter_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_search.Text = "";
            filter = cb_filter.SelectedItem.ToString();
            
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                filter = "";
            }
            else
            {
                filter = cb_filter.SelectedItem.ToString();
            }
        }
    }
}
