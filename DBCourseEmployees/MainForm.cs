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
            try
            {
                cn.Open();
            } catch(Exception e)
            {
                MessageBox.Show("Не удается установить соединение с базой. Обратитесь к администратору." +
                    "\nОшибка:" + e.ToString(), "Ошибка!");
                isSystemExit = true;
                this.Close();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }


      

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSystemExit)
            {
                if (shouldCloseCN)
                {
                    cn.Close();
                }
                isSystemExit = false;
                shouldCloseCN = true;
                return;
            }
            if (MessageBox.Show("Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                cn.Close();
            }

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable loginTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand sU = new OleDbCommand("SELECT lgn, psw FROM Users WHERE lgn = ? AND psw = ?", cn);
            sU.Parameters.Add("@p1", OleDbType.VarChar, 30);
            sU.Parameters.Add("@p2", OleDbType.VarChar, 64);
            sU.Parameters[0].Value = txt_login.Text;
            sU.Parameters[1].Value = Program.sha256_hash(txt_password.Text);
            da.SelectCommand = sU;
            da.Fill(loginTable);

            if(loginTable.Rows.Count > 0)
            {
                String post = "";
                DataTable postTable = new DataTable();
                OleDbCommand sP = new OleDbCommand("SELECT Posts.title FROM Employees JOIN Posts ON postId = Posts.id WHERE Employees.email = ?", cn);
                sP.Parameters.Add("@p1", OleDbType.VarChar, 30);
                sP.Parameters[0].Value = txt_login.Text;
                da.SelectCommand = sP;
                da.Fill(postTable);
                post = (postTable.Rows[0])["title"].ToString();
                bool isProblem = false;
                switch (post)
                {
                    case "Управляющий компании":
                        DirectorMainForm directorMainForm = new DirectorMainForm(cn, txt_login.Text);
                        directorMainForm.Show();
                        break;
                    case "Аналитик":
                        AnalyticMainForm analyticMain = new AnalyticMainForm(cn, txt_login.Text);
                        analyticMain.Show();
                        break;
                    case "Работник склада":
                        StorageWorkerMain storageWorkerMain = new StorageWorkerMain(cn, txt_login.Text);
                        storageWorkerMain.Show();
                        break;
                    default:
                        MessageBox.Show("Вы зарегистрированы в системе, но вам не назначена должность. СВяжитесь с начальством.", "Ошибка");
                        isProblem = true;
                        break;
                }
                if (!isProblem)
                {
                    isSystemExit = true;
                    shouldCloseCN = false;
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Введен неверный логин или пароль", " Ошибка авторизации");
                txt_password.Text = "";
            }

        }

        

        bool isSystemExit = false;
        bool shouldCloseCN = true;
    }
}
