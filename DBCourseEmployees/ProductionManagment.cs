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
using System.Collections;

namespace DBCourseEmployees
{
    public partial class ProductionManagment : Form
    {
        private void ProductionManagment_Load(object sender, EventArgs e)
        {
            txt_articul.ReadOnly = true;
            txt_id.ReadOnly = true;

            txt_category.ReadOnly = true;
            cb_category.Hide();

            txt_supplier.ReadOnly = true;
            cb_supplier.Hide();

            setReadMode();
            btn_del.Hide();

            cb_filter.SelectedItem = "Названию";
            txt_search.ReadOnly = false;

            cb_filter.SelectedItem = "Названию";
        }

        OleDbConnection cn;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataAdapter daFull;
        DataTable dtFull;
        Dictionary<String, String> pastValues = new Dictionary<String, String>();
        bool isNew = true;
        bool isChooseFreeze = false;
        String currProdId = "-1";

        public ProductionManagment(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;

            da = new OleDbDataAdapter("SELECT Categories.title AS \"Категория\", ProductDetails.title AS \"Название\", " +
                "Products.id AS \"Артикул фирмы\", Products.articul AS \"Артикул\" FROM Products " +
                "JOIN ProductDetails ON ProductDetails.productId = Products.id JOIN Categories ON Products.categoryId = Categories.id", cn);
            dt = new DataTable("Products");
            da.Fill(dt);

            dg_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_products.DataSource = dt;
            dg_products.ReadOnly = true;
            dg_products.AllowUserToAddRows = false;

            daFull = new OleDbDataAdapter("SELECT Products.id AS id, Products.articul AS art, Categories.title AS cat, Categories.id AS catId, " +
                "ProductDetails.title AS title, ProductDetails.marketPrice AS mPrice, ProductDetails.firmPrice AS fPrice, ProductDetails.capacity AS cap, " +
                "Suppliers.companyName AS sup, Suppliers.id AS supId FROM Products LEFT JOIN Suppliers ON Products.supplierId = Suppliers.id " +
                "JOIN Categories ON Categories.id = Products.categoryId JOIN ProductDetails ON Products.id = ProductDetails.productId", cn);
            dtFull = new DataTable("EmployeesFull");
            daFull.Fill(dtFull);

            OleDbCommand sP = new OleDbCommand("SELECT companyName FROM Suppliers JOIN SuppliersCatalog ON Suppliers.id = SuppliersCatalog.supplierId WHERE productId = " + currProdId, cn);
            OleDbDataReader rdr = sP.ExecuteReader();
            cb_supplier.Items.Add("Отсутствует");
            while (rdr.Read())
                cb_supplier.Items.Add(rdr["companyName"]);
            rdr.Close();

            OleDbCommand sP2 = new OleDbCommand("SELECT title FROM Categories", cn);
            OleDbDataReader rdr2 = sP2.ExecuteReader();
            while (rdr2.Read())
                cb_category.Items.Add(rdr2["title"]);
            rdr.Close();

            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = true;
                }
            }

        }

        private void updateCbSup()
        {
            cb_supplier.Items.Clear();
            OleDbCommand sP = new OleDbCommand("SELECT companyName FROM Suppliers JOIN SuppliersCatalog ON Suppliers.id = SuppliersCatalog.supplierId WHERE productId = " + currProdId, cn);
            OleDbDataReader rdr = sP.ExecuteReader();
            cb_supplier.Items.Add("Отсутствует");
            while (rdr.Read())
                cb_supplier.Items.Add(rdr["companyName"]);
            rdr.Close();
        }
        private void updateResx()
        {
            da.Dispose();
            daFull.Dispose();
            dt.Dispose();
            dtFull.Dispose();

            da = new OleDbDataAdapter("SELECT Categories.title AS \"Категория\", ProductDetails.title AS \"Название\", Products.id AS \"Артикул фирмы\", Products.articul AS \"Артикул\" FROM Products " +
               "JOIN ProductDetails ON ProductDetails.productId = Products.id JOIN Categories ON Products.categoryId = Categories.id", cn);
            dt = new DataTable("Products");
            da.Fill(dt);

            daFull = new OleDbDataAdapter("SELECT Products.id AS id, Products.articul AS art, Categories.title AS cat, Categories.id AS catId, " +
                "ProductDetails.title AS title, ProductDetails.marketPrice AS mPrice, ProductDetails.firmPrice AS fPrice, ProductDetails.capacity AS cap, Suppliers.companyName AS sup, Suppliers.id AS supId" +
                " FROM Products LEFT JOIN Suppliers ON Products.supplierId = Suppliers.id JOIN Categories ON Categories.id = Products.categoryId " +
                "JOIN ProductDetails ON Products.id = ProductDetails.productId", cn);
            dtFull = new DataTable("EmployeesFull");
            daFull.Fill(dtFull);

            dg_products.DataSource = dt;
        }

        private void setWriteMode()
        {
            cb_category.Show();
            txt_category.Hide();

            cb_supplier.Show();
            txt_supplier.Hide();

            txt_title.ReadOnly = false;
            txt_gCost.ReadOnly = false;
            txt_fCost.ReadOnly = false;
            txt_capacity.ReadOnly = false;

            btn_save.Show();
            btn_cancel.Show();
            btn_change.Hide();
            btn_add.Hide();

            isChooseFreeze = true;

            if (!isNew)
            {
                cb_category.SelectedItem = txt_category.Text;
                cb_supplier.SelectedItem = txt_supplier.Text;
                btn_del.Show();
            }
        }

        private void setReadMode()
        {
            cb_category.Hide();
            txt_category.Show();

            cb_supplier.Hide();
            txt_supplier.Show();

            txt_title.ReadOnly = true;
            txt_gCost.ReadOnly = true;
            txt_fCost.ReadOnly = true;
            txt_capacity.ReadOnly = true;
            txt_articul.ReadOnly = true;

            btn_save.Hide();
            btn_cancel.Hide();
            btn_change.Show();
            btn_add.Show();

            isChooseFreeze = false;

            if (!isNew)
            {
                if(cb_category.SelectedItem == null)
                {
                    txt_category.Text = "";
                } else
                {
                    txt_category.Text = cb_category.SelectedItem.ToString();
                }

                if (cb_supplier.SelectedItem == null)
                {
                    txt_supplier.Text = "";
                }
                else
                {
                    txt_supplier.Text = cb_supplier.SelectedItem.ToString();
                }
                btn_del.Hide();
            }
        }

        private void setNull()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedItem = null;
                    (c as ComboBox).Text = "";

                }
            }
        }

        private void rememberOld()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox && (c as TextBox).Name != "txt_serach")
                {
                    pastValues[(c as TextBox).Name] = (c as TextBox).Text;
                }
                else if (c is ComboBox && (c as ComboBox).Name != "cb_filter")
                {
                    pastValues[(c as ComboBox).Name] = (c as ComboBox).SelectedItem.ToString();
                }
            }
        }

        private void restoreOld()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox && (c as TextBox).Name != "txt_search")
                {
                    (c as TextBox).Text = pastValues[(c as TextBox).Name];
                }
                else if (c is ComboBox && (c as ComboBox).Name != "cb_filter")
                {
                    (c as ComboBox).SelectedItem = pastValues[(c as ComboBox).Name];
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            isNew = true;
            setNull();
            setWriteMode();
            txt_articul.ReadOnly = false;
            label5.Hide();
            txt_id.Hide();
            txt_id.Text = "-1";
            label10.Hide();
            txt_supplier.Hide();
            cb_supplier.Hide();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int returnCode = 1;

            

            if (isNew)
            {
                returnCode = addProduct();
                if (returnCode == 0)
                {
                    setNull();
                    label5.Show();
                    txt_id.Show();
                }
            }
            else
            {
                returnCode = changeProduct();
            }
            if (returnCode == 0)
            {
                isChooseFreeze = false;
                updateResx();
                setReadMode();
            }
        }

        private int addProduct()
        {

            if (isNulls())
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
                return 1;
            }

            if (isOver())
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
                return 1;
            }

            OleDbCommand iU;

            if (cb_supplier.SelectedItem == null || cb_supplier.SelectedItem.ToString() == "Отсутствует")
            {
                iU = new OleDbCommand("INSERT INTO Products (categoryId, articul) VALUES (?, ?)", cn);
                iU.Parameters.Add("@p1", OleDbType.Integer);
                iU.Parameters.Add("@p2", OleDbType.Integer);
                iU.Parameters[0].Value = getIdByValue("Categories", "title", cb_category.SelectedItem.ToString());
                iU.Parameters[1].Value = txt_articul.Text;
                
            }
            else
            {
                iU = new OleDbCommand("INSERT INTO Products VALUES (?, ?)", cn);
                iU.Parameters.Add("@p1", OleDbType.Integer);
                iU.Parameters.Add("@p2", OleDbType.Integer);
                iU.Parameters[0].Value = getIdByValue("Categories", "title", cb_category.SelectedItem.ToString());
                iU.Parameters[1].Value = txt_articul.Text;

            }
            try
            {
                iU.ExecuteNonQuery();
            }
            catch (OleDbException exc)
            {
                if (!Program.isErrorIsDuplicate(exc.Message))
                {
                    MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
                return 1;
            }


            OleDbCommand iU2 = new OleDbCommand("INSERT INTO ProductDetails VALUES (?, ?, ?, ?, ?)", cn);
            iU2.Parameters.Add("@p1", OleDbType.Integer);
            iU2.Parameters.Add("@p2", OleDbType.VarChar, 20);
            iU2.Parameters.Add("@p3", OleDbType.Integer);
            iU2.Parameters.Add("@p4", OleDbType.Integer);
            iU2.Parameters.Add("@p5", OleDbType.Integer);

            iU2.Parameters[0].Value = getLastMasterId("Products");
            iU2.Parameters[1].Value = txt_title.Text;
            iU2.Parameters[2].Value = txt_gCost.Text;
            iU2.Parameters[3].Value = txt_fCost.Text;
            iU2.Parameters[4].Value = txt_capacity.Text;

            try
            {
                iU2.ExecuteNonQuery();
                label10.Show();
                txt_supplier.Show();
                cb_supplier.Show();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return 1;
            }
            return 0;

        }

        private int changeProduct()
        {
            if (isNulls())
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
                return 1;
            }

            if (isOver())
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
                return 1;
            }

            OleDbCommand iU;

            if (cb_supplier.SelectedItem == null || cb_supplier.SelectedItem.ToString() == "Отсутствует")
            {
                iU = new OleDbCommand("UPDATE Products SET categoryId = ?, articul = ? WHERE id = ?", cn);
                iU.Parameters.Add("@p1", OleDbType.Integer);
                iU.Parameters.Add("@p2", OleDbType.Integer);
                iU.Parameters.Add("@p3", OleDbType.Integer);

                iU.Parameters[0].Value = getIdByValue("Categories", "title", cb_category.SelectedItem.ToString());
                iU.Parameters[1].Value = txt_articul.Text;
                iU.Parameters[2].Value = txt_id.Text;


            }
            else
            {
                iU = new OleDbCommand("UPDATE Products SET categoryId = ?, articul = ?, supplierId = ? WHERE id = ?", cn);
                iU.Parameters.Add("@p1", OleDbType.Integer);
                iU.Parameters.Add("@p2", OleDbType.Integer);
                iU.Parameters.Add("@p3", OleDbType.Integer);
                iU.Parameters.Add("@p4", OleDbType.Integer);

                iU.Parameters[0].Value = getIdByValue("Categories", "title", cb_category.SelectedItem.ToString());
                iU.Parameters[1].Value = txt_articul.Text;
                iU.Parameters[2].Value = getIdByValue("Suppliers", "companyName", cb_supplier.SelectedItem.ToString());
                iU.Parameters[3].Value = txt_id.Text;


            }
            try
            {
                iU.ExecuteNonQuery();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return 1;
            }


            OleDbCommand iU2 = new OleDbCommand("UPDATE ProductDetails SET title = ?, marketPrice = ?, firmPrice = ?, capacity = ? WHERE productId = ?", cn);
            iU2.Parameters.Add("@p1", OleDbType.VarChar, 20);
            iU2.Parameters.Add("@p2", OleDbType.Integer);
            iU2.Parameters.Add("@p3", OleDbType.Integer);
            iU2.Parameters.Add("@p4", OleDbType.Integer);
            iU2.Parameters.Add("@p5", OleDbType.Integer);


            iU2.Parameters[0].Value = txt_title.Text;
            iU2.Parameters[1].Value = txt_gCost.Text;
            iU2.Parameters[2].Value = txt_fCost.Text;
            iU2.Parameters[3].Value = txt_capacity.Text;
            iU2.Parameters[4].Value = txt_id.Text;

            try
            {
                iU2.ExecuteNonQuery();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return 1;
            }
            return 0;
        }

        private void txt_title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && !Char.IsDigit(letter) && txt_title.TextLength == 20)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_title.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_articul_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_articul.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_gCost_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_gCost.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_fCost_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_fCost.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_capacity_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_capacity.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void dg_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isChooseFreeze)
            {
                txt_id.Text = dg_products.SelectedRows[0].Cells["Артикул фирмы"].Value.ToString();
                currProdId = txt_id.Text;
                int id = int.Parse(txt_id.Text);
                updateCbSup();

                txt_articul.Text = chooseById(id, "art");
                txt_category.Text = chooseById(id, "cat");
                txt_title.Text = chooseById(id, "title");
                txt_gCost.Text = chooseById(id, "mPrice");
                txt_fCost.Text = chooseById(id, "fPrice");
                txt_capacity.Text = chooseById(id, "cap");
                txt_supplier.Text = chooseById(id, "sup");

            }
        }

        private String chooseById(int id, String clmn)
        {
            DataRow row = (dtFull.Select("id = '" + id + "'"))[0];
            String value = row[clmn].ToString();
            if (clmn == "sup" && value == "")
            {
                return "Отсутствует";
            }
            return value;

        }

        private bool isNulls()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox && !((c as TextBox).Name == "txt_category" || (c as TextBox).Name == "txt_supplier" || (c as TextBox).Name == "txt_search"))
                {
                    if((c as TextBox).Text == "")
                    {
                        return true;
                    }
                }
                else if (c is ComboBox && !((c as ComboBox).Name == "cb_supplier" || (c as ComboBox).Name == "cb_filter"))
                {
                    if((c as ComboBox).SelectedItem == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool isOver()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is TextBox )
                {
                    if(Program.intOverFlow((c as TextBox).Text) && !(c.Name == "txt_supplier" || c.Name == "txt_title" || c.Name == "txt_category" || c.Name == "txt_search"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private String getIdByValue(String table, String clmn, String value, bool isChar = true)
        {
            if (isChar) value = "'" + value + "'";
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT id FROM " + table + " WHERE " + clmn + " = " + value, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["id"].ToString();
        }

        private String getLastMasterId(String table)
        {
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT MAX(id) AS max FROM " + table, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["max"].ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                setNull();
                label5.Show();
                txt_id.Show();
                label10.Show();
                txt_supplier.Show();
                cb_supplier.Show();
            }
            else
            {
                restoreOld();
            }
            isChooseFreeze = false;
            setReadMode();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            cb_category.SelectedItem = txt_category.Text;
            cb_supplier.SelectedItem = txt_supplier.Text;
            if (isNulls())
            {
                MessageBox.Show("Выберите товар", "Внимание!");
                return;
            }
            isNew = false;
            rememberOld();
            setWriteMode();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\n Товар \"" + pastValues[txt_title.Name] + "\" и его данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            OleDbCommand iU2 = new OleDbCommand("DELETE Products WHERE id = ?", cn);
            iU2.Parameters.Add("@p1", OleDbType.Integer);
            iU2.Parameters[0].Value = txt_id.Text;
          

            try
            {
                iU2.ExecuteNonQuery();
                MessageBox.Show("Товар был успешно удален", "Успех!");
                setNull();
                isChooseFreeze = false;
                updateResx();
                setReadMode();

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_search.Text == "")
                {
                    dg_products.DataSource = dt;
                    updateResx();

                }
                else
                {
                    DataView dv = dt.DefaultView;
                    switch (cb_filter.SelectedItem.ToString())
                    {
                        case "Названию":
                            dv.RowFilter = string.Format("Название like '%{0}%'", txt_search.Text);
                            dg_products.DataSource = dv.ToTable();
                            break;
                        case "Категории":
                            dv.RowFilter = string.Format("Категория like '%{0}%'", txt_search.Text);
                            dg_products.DataSource = dv.ToTable();
                            break;
                        case "Артикулу":
                            dv.RowFilter = string.Format("Артикул = '{0}'", txt_search.Text);
                            dg_products.DataSource = dv.ToTable();
                            break;
                        case "Артикулу фирмы":
                            dv.RowFilter = string.Format("[Артикул фирмы] = '{0}'", txt_search.Text);
                            dg_products.DataSource = dv.ToTable();
                            break;
                    }
                }

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
