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
    public partial class Registration : Form
    {
        OleDbConnection cn;
        public Registration(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
        }

       

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void txt_f_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_f.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_f.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_i.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_i.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_o_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_o.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_o.Text == "")
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

        private bool isErrorIsDuplicate(String message)
        {
            if (message.Contains("Cannot insert duplicate key in object"))
            {
                MessageBox.Show("Данный номер телефона уже зарегестрирован", "Ошибка");
                return true;
            }
            return false;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_f.Text == "" || txt_i.Text == "" || txt_o.Text == "" || !txt_phone.MaskCompleted || txt_psw.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
                return;
            }

            if (txt_psw.Text != txt_psw2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Внимание!");
                txt_psw.Text = "";
                txt_psw2.Text = "";
                return;
            }

            OleDbDataAdapter daTemp = new OleDbDataAdapter("Select lgn FROM Users WHERE lgn = " + "'" + txt_phone.Text + "'", cn);
            DataTable dtTemp = new DataTable("Temp");
            daTemp.Fill(dtTemp);
            if(dtTemp.Rows.Count > 0)
            {
                MessageBox.Show("Введеный номер телефона уже был зарегестрирован", "Внимание!");
                return;
            }

            OleDbCommand cmnd = new OleDbCommand("INSERT INTO Users VALUES (?, ?)", cn);
            cmnd.Parameters.Add("@p1", OleDbType.VarChar, 30);
            cmnd.Parameters.Add("@p2", OleDbType.VarChar, 64);
            cmnd.Parameters[0].Value = txt_phone.Text;
            cmnd.Parameters[1].Value = Program.sha256_hash(txt_psw.Text);

            try
            {
                cmnd.ExecuteNonQuery();
                
            } catch (OleDbException exc)
            {
                if (!isErrorIsDuplicate(exc.Message))
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
                return;
            }

            OleDbCommand cmnd2 = new OleDbCommand("INSERT INTO Clients VALUES (?, ?, ?)", cn);
            cmnd2.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmnd2.Parameters.Add("@p2", OleDbType.VarChar, 30);
            cmnd2.Parameters.Add("@p3", OleDbType.Date);

            cmnd2.Parameters[0].Value = String.Concat(txt_f.Text, " ", txt_i.Text, " ", txt_o.Text);
            cmnd2.Parameters[1].Value = txt_phone.Text;
            cmnd2.Parameters[2].Value = DateTime.Today.Date.ToString("yyyy-MM-dd");

            try
            {
                cmnd2.ExecuteNonQuery();
                Program.username = txt_phone.Text;
                MessageBox.Show("Регистрация прошла успешно", "Успех");
                this.Close(); //?

            }
            catch (OleDbException exc)
            {
                MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                return;
            }

        }
    }
}
