using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DBCourseClients
{
    static class Program
    {
        public class MyApplicationContext : ApplicationContext
        {
            public MyApplicationContext(Form startupForm)
            {
                startupForm.FormClosed += OnFormClosed;
                startupForm.Show();
            }

            private void OnFormClosed(object sender, FormClosedEventArgs e)
            {
                if (Application.OpenForms.Count > 0)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        form.FormClosed -= OnFormClosed;
                        form.FormClosed += OnFormClosed;
                    }
                }
                else ExitThread();
            }
        }

        public static String username = "";
        public static bool isNulls(List<TextBox> list_tb = null, List<ComboBox> list_cb = null)
        {
            if (list_tb != null)
            {
                foreach (TextBox tb in list_tb)
                {
                    if (tb.Text == "")
                    {
                        return true;
                    }
                }
            }
            if (list_cb != null)
            {
                foreach (ComboBox cb in list_cb)
                {
                    if (cb.SelectedItem == null)
                    {
                        return true;
                    }
                }
            }
            return false;
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

        public static String getValueByValue(String table, String selClmn, String whereClmn, String whereClmnValue, OleDbConnection cn, bool isWhereClmnChar = true)
        {
            if (isWhereClmnChar) whereClmnValue = "'" + whereClmnValue + "'";
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT " + selClmn + " FROM " + table + " WHERE " + whereClmn + " = " + whereClmnValue, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])[selClmn].ToString();
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyApplicationContext(new MainForm()));
        }
    }
}
