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
    public partial class AddSupplier : Form
    {
        OleDbConnection cn;
        List<String> products = new List<String>();
        String phone;

        public AddSupplier(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;

            OleDbCommand sP = new OleDbCommand("SELECT title FROM ProductDetails", cn);
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
                lb_products.Items.Add(rdr["title"]);
            rdr.Close();
            txt_phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && !Char.IsDigit(letter) && txt_name.TextLength == 30)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_name.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
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

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || !txt_phone.MaskCompleted || lb_products.CheckedItems.Count == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
                return;
            }

            OleDbCommand iU2 = new OleDbCommand("INSERT INTO Suppliers VALUES (?)", cn);
            iU2.Parameters.Add("@p1", OleDbType.VarChar, 30);
            iU2.Parameters[0].Value = txt_name.Text;
            
            try
            {
                iU2.ExecuteNonQuery();
                

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }
            String masterId = getLastMasterId("Suppliers");
            OleDbCommand iU = new OleDbCommand("INSERT INTO SuppliersDetails VALUES (?, ?, ?)", cn);
            iU.Parameters.Add("@p1", OleDbType.Integer);
            iU.Parameters.Add("@p2", OleDbType.Date);
            iU.Parameters.Add("@p3", OleDbType.VarChar, 11);
            iU.Parameters[0].Value = masterId;
            iU.Parameters[1].Value = DateTime.Today.Date.ToString("d");
            iU.Parameters[2].Value = txt_phone.Text;

            try
            {
                iU.ExecuteNonQuery();
                foreach (String product in lb_products.CheckedItems)
                {
                    products.Add(product);
                }
                AddSuppliersProducts addSupplierProducts = new AddSuppliersProducts(products, masterId, cn);
                addSupplierProducts.MdiParent = this.MdiParent;
                addSupplierProducts.Show();
                this.Close();

            }
            catch (OleDbException exc)
            {
                if (!Program.isErrorIsDuplicate(exc.Message)) {
                    MessageBox.Show("Произошла ошибка базы данных при добавлении новой учетной записи, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
            }
        }

        private String getLastMasterId(String table)
        {
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT MAX(id) AS max FROM " + table, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["max"].ToString();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
