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
using System.Security.Cryptography;

namespace DBCourseEmployees
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                cn.Close();
            }

        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable loginTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand sU = new OleDbCommand("SELECT lgn, psw FROM Users WHERE lgn = ? AND psw = ?", cn);
            sU.Parameters.Add("@p1", OleDbType.VarChar, 30);
            sU.Parameters.Add("@p1", OleDbType.VarChar, 64);
            sU.Parameters[0].Value = txt_login.Text;
            sU.Parameters[1].Value = sha256_hash(txt_password.Text);
            da.SelectCommand = sU;
            da.Fill(loginTable);

            if(loginTable.Rows.Count > 0)
            {
                MessageBox.Show("yes");
            } else
            {
                MessageBox.Show("no");
            }

        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
