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
    public partial class LoginForm : Form
    {
        OleDbConnection cn;
        public LoginForm(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(cn);
            registration.Show();
            this.Close(); //?

        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (txt_phone.Text == "" && num == '0')
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(!txt_phone.MaskCompleted || txt_newPsw.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
                return;
            }

            OleDbCommand cmnd = new OleDbCommand("Select lgn, psw FROM Users WHERE lgn = ? AND psw = ?", cn);
            cmnd.Parameters.Add("@p1", OleDbType.VarChar, 30);
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 64);
            cmnd.Parameters[0].Value = txt_phone.Text;
            cmnd.Parameters[1].Value = Program.sha256_hash(txt_newPsw.Text);

            OleDbDataAdapter daTemp = new OleDbDataAdapter();
            daTemp.SelectCommand = cmnd;
            DataTable dtTemp = new DataTable("Temp");
            daTemp.Fill(dtTemp);
            if (dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("Введен неверный логин или пароль", "Внимание!");
                return;
            } else
            {
                MessageBox.Show("Авторизация прошла успешно", "Успех");
                Program.username = txt_phone.Text;
                this.Close(); //?

            }


        }
    }
}
