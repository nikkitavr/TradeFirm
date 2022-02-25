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
    public partial class AddSuppliersProducts : Form
    {
        OleDbConnection cn;
        String supId;
        List<String> products;
        List<String> pPrices;
        List<String> dPrices;
        List<String> dTimes;

        int index = 0;
        int numElements;

        public AddSuppliersProducts(List<String> products, String supplierId, OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            this.products = new List<String>(products);
            this.supId = supplierId;
            numElements = products.Count;

            pPrices = new List<string>(numElements);
            dPrices = new List<string>(numElements);
            dTimes = new List<string>(numElements);
            for(int i = 0; i < numElements; i++)
            {
                pPrices.Add("");
                dPrices.Add("");
                dTimes.Add("");
            }

            lbl_companyName.Text = getValueById("Suppliers", "companyName", supId);
        }

        private void AddSuppliersProducts_Load(object sender, EventArgs e)
        {
            showProduct();
        }

        private void txt_pPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && !Char.IsControl(num) || (txt_pPrice.Text == "" && num == '0'))
            {
                e.Handled = true;
            }
        }

        private void txt_dPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && !Char.IsControl(num))
            {
                e.Handled = true;
            }
        }

        private void txt_dTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && !Char.IsControl(num) || (txt_dPrice.Text == "" && num == '0'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index == products.Count() - 1)
            {
                return;
            }
            remember();
            index++;
            showProduct();
            txt_pPrice.ReadOnly = false;
            txt_dTime.ReadOnly = false;
            txt_dPrice.ReadOnly = false;

        }

        private void showProduct()
        {
            txt_product.Text = products[index];
            txt_pPrice.Text = pPrices[index];
            txt_dPrice.Text = dPrices[index];
            txt_dTime.Text = dTimes[index];
        }

       private void remember()
        {
            pPrices[index] = txt_pPrice.Text;
            dPrices[index] = txt_dPrice.Text;
            dTimes[index] = txt_dTime.Text;
        }

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                return;
            }
            remember();
            index--;
            showProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remember();

            if (isNulls())
            {
                MessageBox.Show("Все поля должны быть заполнены", "Внимание");
                return;
            }

            if (isIntOver())
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
                return;
            }

            if(txt_dPrice.TextLength > 1 && txt_dPrice.Text[0] == ' ')
            {
                MessageBox.Show("Неккоректный формат цены за доставку", "Внимание!");
                return;
            }

            for (int i=0; i < numElements; i++)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO SuppliersCatalog VALUES (?, ?, ?, ?, ?)", cn);
                command.Parameters.Add("@supId", OleDbType.Integer);
                command.Parameters.Add("@prodId", OleDbType.Integer);
                command.Parameters.Add("@uPrice", OleDbType.Integer);
                command.Parameters.Add("@tPrice", OleDbType.Integer);
                command.Parameters.Add("@tTime", OleDbType.Integer);
                command.Parameters[0].Value = supId;
                command.Parameters[1].Value = getIdByValue("ProductDetails", "title", products[i], idName:"productId");
                command.Parameters[2].Value = pPrices[i];
                command.Parameters[3].Value = dPrices[i];
                command.Parameters[4].Value = dTimes[i];

                try
                {
                    command.ExecuteNonQuery();
                   
                } catch (Exception exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }
            }
            MessageBox.Show("Каталог продовца был успешно обновлен", "Успех");
            AddSupplier add = new AddSupplier(cn);
            add.MdiParent = this.MdiParent;
            add.Show();
            this.Close();
        }

        private bool isNulls()
        {
            for(int i = 0; i < numElements; i++)
            {
                if(pPrices[i] == "" || dPrices[i] == "" || dTimes[i] == "")
                {
                    return true;
                }
            }
            return false;
        }

        private bool isIntOver()
        {
            for (int i = 0; i < numElements; i++)
            {
                
                if (Program.intOverFlow(pPrices[i]) || Program.intOverFlow(dPrices[i])|| Program.intOverFlow(dTimes[i]))
                {
                    return true;
                }
            }
            return false;
        }


        private String getValueById(String table, String clmn, String id)
        {
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT " + clmn + " AS clmn FROM " + table + " WHERE id = " + id, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["clmn"].ToString();
        }

        private String getIdByValue(String table, String clmn, String value, bool isChar = true, String idName = "")
        {
            if (isChar) value = "'" + value + "'";
            if (idName == "") idName = "id";

            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT " + idName + " FROM " + table + " WHERE " + clmn + " = " + value, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])[idName].ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\n Поставщик \"" + getValueById("Suppliers", "companyName", supId) + "\" и все внесенные данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            OleDbCommand command = new OleDbCommand("DELETE Suppliers WHERE id = ?", cn);
            command.Parameters.Add("@supId", OleDbType.Integer);
            command.Parameters[0].Value = supId;
            try
            {
                command.ExecuteNonQuery();
                AddSupplier add = new AddSupplier(cn);
                add.MdiParent = this.MdiParent;
                add.Show();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }

        }
    }
}
