using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace DBCourseEmployees
{
    public partial class ManageSuppliers : Form
    {

        OleDbConnection cn;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbDataAdapter daFull;
        DataTable dtFull;
        String currentSupCatId;
        String currentSupId;
        String currentProductId;
        Dictionary<String, String> pastValues = new Dictionary<String, String>();
        Dictionary<String, String> productsIds = new Dictionary<String, String>();

        bool isNew;
        bool isChooseFreeze = false;
        public ManageSuppliers(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            txt_phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            dg_catalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_catalog.ReadOnly = true;
            dg_catalog.AllowUserToAddRows = false;

        }

        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            updateCb();
            hideProducts();
            setSupplierReadMode();
            setProductsReadMode();
            btn_change.Hide();
            btn_changeProduct.Hide();
            btn_addProduct.Hide();
            
            //updateCbProducts();
            cb_product.Hide();
            cb_filter.SelectedItem = "Названию";
        }

        private void updateCb()
        {
            cb_companyName.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("SELECT companyName FROM Suppliers", cn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                cb_companyName.Items.Add(rdr["companyName"]);
            rdr.Close();
        }

        private void updateCbProducts()
        {
            cb_product.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("SELECT id, title, articul FROM (" +
                                                    "SELECT id, articul FROM Products " +
                                                    "EXCEPT " +
                                                    "SELECT Products.id AS id, articul FROM Products " +
                                                        "JOIN SuppliersCatalog ON SuppliersCatalog.productId = Products.id " +
                                                        "WHERE SuppliersCatalog.supplierId = " + currentSupId +
                                                    ") AS T " +
                                                     "JOIN ProductDetails ON ProductDetails.productId = id", cn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                cb_product.Items.Add(rdr["title"] + " (" + rdr["articul"] + ")");
                productsIds[cb_product.Items[i].ToString()] = rdr["id"].ToString();
                i++;
            }
            rdr.Close();
        }

        private void hideProducts()
        {
            splitContainerLeft.Panel1Collapsed = true;
            splitContainerRight.Panel2Collapsed = true;
            splitContainerRight.Panel2.Hide();
            splitContainerLeft.Panel1.Hide();
            label10.Hide();
            label9.Hide();
            label8.Hide();
            label7.Hide();
            label6.Hide();
            label3.Hide();
            txt_product.Hide();
            txt_pPrice.Hide();
            txt_dPrice.Hide();
            txt_dTime.Hide();
            btn_addProduct.Hide();
            btn_cancelProduct.Hide();
            btn_changeProduct.Hide();
            btn_saveProduct.Hide();
            btn_delProduct.Hide();
        }

        private void showProducts(String supId)
        {
            splitContainerLeft.Panel1Collapsed = false;
            splitContainerRight.Panel2Collapsed = false;
            splitContainerRight.Panel2.Show();
            splitContainerLeft.Panel1.Show();
            label10.Show();
            label9.Show();
            label8.Show();
            label7.Show();
            label6.Show();
            label3.Show();
            txt_product.Show();
            txt_pPrice.Show();
            txt_dPrice.Show();
            txt_dTime.Show();
            btn_addProduct.Show();
            btn_changeProduct.Show();
           

            updateDg(supId);
        }

        private void cb_companyName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_companyName.SelectedItem != null)
            {
                currentSupId = Program.getIdByValue("Suppliers", "companyName", cb_companyName.Text, cn);
                btn_change.Show();
                txt_companyName.Text = cb_companyName.SelectedItem.ToString();
                txt_regDate.Text = Program.getValueByValue("SuppliersDetails", "registrationDate", "supplierId", currentSupId, cn, isWhereClmnChar: false);
                txt_phone.Text = Program.getValueByValue("SuppliersDetails", "phone", "supplierId", currentSupId, cn, isWhereClmnChar: false);
                showProducts(currentSupId);
            }
            else
            {
                hideProducts();
                btn_change.Hide();
                txt_regDate.Text = "";
                txt_phone.Text = "";
            }

            setProductNulls();
            cb_product.SelectedItem = null;
            cb_product.Text = "";
            txt_search.Text = "";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (isSuppNulls())
            {
                MessageBox.Show("Выберите поставщика", "Внимание!");
                return;
            }

            rememberSupplier();
            setSupplierWriteMode();
            hideProducts();
        }

        private void updateDg(String supId)
        {
            if (da != null) da.Dispose();
            if (daFull != null) daFull.Dispose();
            if (dt != null) dt.Dispose();
            if (dtFull != null) dtFull.Dispose();
            

            da = new OleDbDataAdapter("SELECT SuppliersCatalog.id AS \"Номер в каталоге\", Categories.title AS \"Категория\", ProductDetails.title AS \"Название\", " +
                "Products.id AS \"Артикул фирмы\", Products.articul AS \"Артикул\" FROM SuppliersCatalog " +
               "LEFT JOIN Products ON SuppliersCatalog.productId = Products.id " +
               "JOIN ProductDetails ON ProductDetails.productId = Products.id JOIN Categories ON Products.categoryId = Categories.id " +
               "WHERE SuppliersCatalog.supplierId = " + supId, cn);
            dt = new DataTable("Catalog");
            da.Fill(dt);

            daFull = new OleDbDataAdapter("SELECT id AS id, supplierId as supId, unitPrice as uPrice, transferPrice as tPrice, transferTime as tTime " +
                "FROM SuppliersCatalog WHERE supplierId = " + supId, cn);
            dtFull = new DataTable("EmployeesFull");
            daFull.Fill(dtFull);

            dg_catalog.DataSource = dt;
        }

        private String chooseById(String id, String clmn)
        {
            DataRow row = (dtFull.Select("id = '" + id + "'"))[0];
            String value = row[clmn].ToString();
            
            return value;

        }

        private void setProductNulls()
        {
            txt_product.Text = "";
            txt_pPrice.Text = "";
            txt_dPrice.Text = "";
            txt_dTime.Text = "";
        }

        private void setSuppNulls()
        {
            cb_companyName.SelectedItem = null;
            cb_companyName.Text = "";
            txt_companyName.Text = "";
            txt_regDate.Text = "";
            txt_phone.Text = "";
        }

        private void rememberSupplier()
        {
            pastValues[txt_companyName.Name] = txt_companyName.Text;
            pastValues[txt_regDate.Name] = txt_regDate.Text;
            pastValues[txt_phone.Name] = txt_phone.Text;
        }
        private void rememberProduct()
        {
            pastValues[txt_product.Name] = txt_product.Text;
            pastValues[txt_pPrice.Name] = txt_pPrice.Text;
            pastValues[txt_dPrice.Name] = txt_dPrice.Text;
            pastValues[txt_dTime.Name] = txt_dTime.Text;
        }

        private void restoreSupplier()
        {
            txt_companyName.Text = pastValues[txt_companyName.Name];
            txt_regDate.Text = pastValues[txt_regDate.Name];
            txt_phone.Text = pastValues[txt_phone.Name];
            cb_companyName.SelectedItem = null;
            cb_companyName.SelectedItem = txt_companyName;
        }

        private void restoreProduct()
        {
            txt_pPrice.Text = pastValues[txt_pPrice.Name];
            txt_dPrice.Text = pastValues[txt_dPrice.Name];
            txt_dTime.Text = pastValues[txt_dTime.Name];
            txt_product.Text = pastValues[txt_product.Name];
        }

        private bool isSuppNulls()
        {
            if(txt_companyName.Text == "" || txt_phone.MaskCompleted == false)
            {
                return true;
            }
            return false;
        }

        private bool isProductNulls()
        {
            if (txt_product.Text == "" || txt_pPrice.Text == "" || txt_dPrice.Text == "" || txt_dTime.Text == "")
            {
                return true;
            }
            return false;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isSuppNulls())
            {
                MessageBox.Show("Необходимо заполнить все поля", "Внимание!");
                return;
            }

            String sId = Program.getIdByValue("Suppliers", "companyName", pastValues[txt_companyName.Name], cn);

            OleDbCommand iP = new OleDbCommand("UPDATE Suppliers SET companyName = ? WHERE id = ?", cn);
            iP.Parameters.Add("@p1", OleDbType.VarChar, 30);
            iP.Parameters.Add("@p2", OleDbType.Integer);
            iP.Parameters[0].Value = txt_companyName.Text;
            iP.Parameters[1].Value = sId;

            try
            {
                iP.ExecuteNonQuery();
                
            }
            catch (OleDbException exc)
            {
                if (!Program.isErrorIsDuplicate(exc.Message))
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
                return;
            }

            OleDbCommand iP2 = new OleDbCommand("UPDATE SuppliersDetails SET phone = ? WHERE supplierId = ?", cn);
            iP2.Parameters.Add("@p1", OleDbType.VarChar, 11);
            iP2.Parameters.Add("@p2", OleDbType.Integer);
            iP2.Parameters[0].Value = txt_phone.Text;
            iP2.Parameters[1].Value = sId;

            try
            {
                iP2.ExecuteNonQuery();
                updateCb();
                setSupplierReadMode();
                MessageBox.Show("Информация о поставщике была успешно обновлена", "Успех");
                

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void setSupplierReadMode()
        {
            if (txt_companyName.Text != "")
            {
                cb_companyName.SelectedItem = txt_companyName.Text;
            }
            else 
            { 
                cb_companyName.SelectedItem = null;
                cb_companyName.Text = ""; 
            }
            cb_companyName.Show();
            txt_companyName.Hide();
            btn_change.Show();
            btn_save.Hide();
            btn_cancel.Hide();
            btn_delete.Hide();
            txt_phone.ReadOnly = true;
        }

        private void setSupplierWriteMode()
        {
            txt_companyName.Text = cb_companyName.SelectedItem.ToString();
            cb_companyName.Hide();
            txt_companyName.Show();
            btn_change.Hide();
            btn_save.Show();
            btn_cancel.Show();
            btn_delete.Show();
            txt_phone.ReadOnly = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            restoreSupplier();
            setSupplierReadMode();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\n Поставщик \"" + pastValues[txt_companyName.Name] + "\" и его данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            String sId = Program.getIdByValue("Suppliers", "companyName", pastValues[txt_companyName.Name], cn);

            OleDbCommand iP = new OleDbCommand("DELETE Suppliers WHERE id = ?", cn);
            iP.Parameters.Add("@p1", OleDbType.Integer);
            iP.Parameters[0].Value = sId;

            try
            {
                iP.ExecuteNonQuery();
                updateCb();
                setSuppNulls();
                setSupplierReadMode();
                btn_change.Hide();
                MessageBox.Show("Поставщик был успешно удален", "Успех!");
               
            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void setProductsReadMode() {
            cb_product.Hide();
            txt_pPrice.ReadOnly = true;
            txt_dPrice.ReadOnly = true;
            txt_dTime.ReadOnly = true;
            btn_saveProduct.Hide();
            btn_cancelProduct.Hide();
            btn_delProduct.Hide();
            isChooseFreeze = false;
        }

        private void setProductsWriteMode()
        {
            txt_pPrice.ReadOnly = false;
            txt_dPrice.ReadOnly = false;
            txt_dTime.ReadOnly = false;
            btn_saveProduct.Show();
            btn_cancelProduct.Show();
            btn_delProduct.Show();
            isChooseFreeze = true;
        }

        private void dg_catalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isChooseFreeze)
            {
                currentSupCatId = dg_catalog.SelectedRows[0].Cells["Номер в каталоге"].Value.ToString();
                txt_product.Text = dg_catalog.SelectedRows[0].Cells["Название"].Value.ToString() + " (" +
                    dg_catalog.SelectedRows[0].Cells["Артикул"].Value.ToString() + ")";
                currentProductId = dg_catalog.SelectedRows[0].Cells["Артикул фирмы"].Value.ToString();

                txt_pPrice.Text = chooseById(currentSupCatId, "uPrice");
                txt_dPrice.Text = chooseById(currentSupCatId, "tPrice");
                txt_dTime.Text = chooseById(currentSupCatId, "tTime");

                btn_addProduct.Show();
                btn_changeProduct.Show();
            }
        }

        private void btn_changeProduct_Click(object sender, EventArgs e)
        {
            if (isProductNulls())
            {
                MessageBox.Show("Сначала выберите продукт", "Внимание!");
                return;
            }
            rememberProduct();
            setProductsWriteMode();
            btn_addProduct.Hide();
            btn_changeProduct.Hide();
            btn_change.Hide();
            isNew = false;
            lockSupp();
        }

        private void lockSupp()
        {
            btn_change.Hide();
            btn_cancel.Hide();
            btn_save.Hide();
            btn_delete.Hide();
            txt_companyName.Text = cb_companyName.SelectedItem.ToString();
            cb_companyName.Hide();
            txt_companyName.Show();
            txt_companyName.ReadOnly = true;
            txt_regDate.ReadOnly = true;
            txt_phone.ReadOnly = true;
        }

        private void unlockSupp()
        {
            btn_change.Show();
            cb_companyName.SelectedItem = txt_companyName.Text;
            cb_companyName.Show();
            txt_companyName.Hide();
            txt_companyName.ReadOnly = false;
        }

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {
            if (isOver())
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
                return;
            }

            if(isNew){
                addProduct();
                return;
            }
            changeProduct();
        }

        private void addProduct()
        {
            if (cb_product.SelectedItem != null) txt_product.Text = cb_product.SelectedItem.ToString();
            if (isProductNulls())
            {
                MessageBox.Show("Необходимо заполнить все поля", "Внимание!");
                return;
            }

            OleDbCommand iP = new OleDbCommand("INSERT INTO SuppliersCatalog VALUES (?, ?, ?, ?, ?)", cn);
            iP.Parameters.Add("@p1", OleDbType.Integer);
            iP.Parameters.Add("@p2", OleDbType.Integer);
            iP.Parameters.Add("@p3", OleDbType.Integer);
            iP.Parameters.Add("@p4", OleDbType.Integer);
            iP.Parameters.Add("@p5", OleDbType.Integer);

            iP.Parameters[0].Value = currentSupId;
            iP.Parameters[1].Value = productsIds[cb_product.SelectedItem.ToString()];
            iP.Parameters[2].Value = txt_pPrice.Text;
            iP.Parameters[3].Value = txt_dPrice.Text;
            iP.Parameters[4].Value = txt_dTime.Text;
            try
            {
                iP.ExecuteNonQuery();
                setProductsReadMode();
                btn_addProduct.Show();
                btn_changeProduct.Show();
                btn_change.Show();
                updateDg(currentSupId);
                setProductNulls();
                txt_product.Text = "";
                cb_product.SelectedItem = null;
                cb_product.Text = "";
                txt_product.Show();
                cb_product.Hide();
                btn_delProduct.Show();
                unlockSupp();
                MessageBox.Show("Продукт был успешно добавлен", "Успешно!");

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }

        }

        private void changeProduct()
        {
            if (isProductNulls())
            {
                MessageBox.Show("Необходимо заполнить все поля", "Внимание!");
                return;
            }

            //String sId = Program.getIdByValue("Suppliers", "companyName", pastValues[txt_companyName.Name], cn);

            OleDbCommand iP = new OleDbCommand("UPDATE SuppliersCatalog SET unitPrice = ?, transferPrice = ?, transferTime = ? WHERE id = ?", cn);
            iP.Parameters.Add("@p1", OleDbType.Integer);
            iP.Parameters.Add("@p2", OleDbType.Integer);
            iP.Parameters.Add("@p3", OleDbType.Integer);
            iP.Parameters.Add("@p4", OleDbType.Integer);

            iP.Parameters[0].Value = txt_pPrice.Text;
            iP.Parameters[1].Value = txt_dPrice.Text;
            iP.Parameters[2].Value = txt_dTime.Text;
            iP.Parameters[3].Value = currentSupCatId;

            try
            {
                iP.ExecuteNonQuery();
                setProductsReadMode();
                btn_addProduct.Show();
                btn_changeProduct.Show();
                btn_change.Show();
                updateDg(currentSupId);
                unlockSupp();
                MessageBox.Show("Продукт был успешно обновлен", "Успешно!");

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            rememberProduct();
            setProductsWriteMode();
            setProductNulls();
            txt_product.Text = "";
            txt_product.Hide();
            cb_product.Show();
            btn_changeProduct.Hide();
            btn_addProduct.Hide();
            btn_change.Hide();
            btn_delProduct.Hide();
            isNew = true;
            lockSupp();
            updateCbProducts();
        }

        private void btn_cancelProduct_Click(object sender, EventArgs e)
        {
            restoreProduct();
            setProductsReadMode();
            btn_addProduct.Show();
            btn_changeProduct.Show();
            unlockSupp();
            if (isNew)
            {
                txt_product.Show();
            }
        }

        private void btn_delProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\n Продукт \"" + pastValues[txt_product.Name] + "\" поставщика \"" + txt_companyName.Text + "\" и его данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            

            OleDbCommand iP = new OleDbCommand("DELETE SuppliersCatalog WHERE id = ?", cn);
            iP.Parameters.Add("@p1", OleDbType.Integer);
            iP.Parameters[0].Value = currentSupCatId;

            try
            {
                iP.ExecuteNonQuery();
                setProductsReadMode();
                btn_addProduct.Show();
                btn_changeProduct.Show();
                btn_change.Show();
                setProductNulls();
                updateDg(currentSupId);
                unlockSupp();
                MessageBox.Show("Продукт был успешно удален", "Успех!");

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (txt_phone.Text == "" && num == '0')
            {
                e.Handled = true;
            }
        }

        private void txt_pPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_pPrice.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private bool isOver()
        {
           if(Program.intOverFlow(txt_pPrice.Text) || Program.intOverFlow(txt_dPrice.Text) || Program.intOverFlow(txt_dTime.Text))
            {
                return true;
            }
            return false;
        }

        private void txt_dPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_dPrice.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_dTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_dTime.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_product.TextLength == 50)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_product.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_companyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_companyName.TextLength == 50)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_companyName.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_search.Text == "")
                {
                    dg_catalog.DataSource = dt;
                    updateDg(currentSupId);

                }
                else
                {
                    DataView dv = dt.DefaultView;
                    switch (cb_filter.SelectedItem.ToString())
                    {
                        case "Названию":
                            dv.RowFilter = string.Format("Название like '%{0}%'", txt_search.Text);
                            dg_catalog.DataSource = dv.ToTable();
                            break;
                        case "Категории":
                            dv.RowFilter = string.Format("Категория like '%{0}%'", txt_search.Text);
                            dg_catalog.DataSource = dv.ToTable();
                            break;
                        case "Артикулу":
                            dv.RowFilter = string.Format("Артикул = '{0}'", txt_search.Text);
                            dg_catalog.DataSource = dv.ToTable();
                            break;
                        case "Артикулу фирмы":
                            dv.RowFilter = string.Format("[Артикул фирмы] = '{0}'", txt_search.Text);
                            dg_catalog.DataSource = dv.ToTable();
                            break;
                    }
                }

            }
        }
    }
}
