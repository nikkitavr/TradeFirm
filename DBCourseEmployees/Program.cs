using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace DBCourseEmployees
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

        public static String selectFirstFrom(OleDbCommand cmnd, String clmn)
        {
            DataTable postTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmnd;
            da.Fill(postTable);
            return (postTable.Rows[0])[clmn].ToString();
        }

        public static bool intOverFlow(String num)
        {
            int x;
            if (!int.TryParse(num, out x))
            {
                return true;
            }
            return false;
        }

        public static String getLastMasterId(String table, OleDbConnection cn)
        {
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT MAX(id) AS max FROM " + table, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["max"].ToString();
        }

        public static String getIdByValue(String table, String clmn, String value, OleDbConnection cn, bool isChar = true)
        {
            if (isChar) value = "'" + value + "'";
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT id FROM " + table + " WHERE " + clmn + " = " + value, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])["id"].ToString();
        }

        public static String getValueById(String table, String clmn, String id, OleDbConnection cn)
        {
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT " + clmn + " FROM " + table + " WHERE id = " + id, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])[clmn].ToString();
        }

        public static String getValueByValue(String table, String selClmn, String whereClmn, String whereClmnValue, OleDbConnection cn, bool isWhereClmnChar = true)
        {
            if (isWhereClmnChar) whereClmnValue = "'" + whereClmnValue + "'";
            DataTable dtTemp = new DataTable();
            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT " + selClmn + " FROM " + table + " WHERE " + whereClmn + " = " + whereClmnValue, cn);
            daTemp.Fill(dtTemp);
            return (dtTemp.Rows[0])[selClmn].ToString();
        }

        public static bool isErrorIsDuplicate(String message)
        {
            if (message.Contains("Cannot insert duplicate key in object"))
            {
                MessageBox.Show("Какое-то из введеных значений должно быть уникальным, но уже встречается в базе данных фирмы.\n" +
                    "(Такими значениями могуть быть номера телефонов, электронные адреса и т.п)", "Ошибка");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyApplicationContext(new loginForm()));
        }
    }
}
