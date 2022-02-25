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

namespace DBCourseEmployees
{
    public partial class AddWorker : Form
    {
        public AddWorker(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        OleDbConnection cn;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!(letter > 'a' && letter < 'z') && !Char.IsControl(letter) && !Char.IsDigit(letter) && !(letter == '.') && txt_mail.TextLength == 20)
            {
                e.Handled = true;
            }

        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            OleDbCommand sP = new OleDbCommand("SELECT title FROM Posts", cn);
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
                cb_post.Items.Add(rdr["title"]);
            rdr.Close();

            txt_phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            List<TextBox> list_tb = new List<TextBox>() {txt_f, txt_i, txt_o, txt_mail, txt_psw2, txt_psw };
            List<ComboBox> list_cb = new List<ComboBox>() { cb_post };
            if (Program.isNulls(list_tb, list_cb) || !txt_phone.MaskCompleted)
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Внимание!");
            } else if (txt_psw.Text != txt_psw2.Text) {
                MessageBox.Show("Пароли не совпадают", "Внимание!");
                txt_psw.Text = "";
                txt_psw2.Text = "";
            } else
            {
                OleDbCommand iU = new OleDbCommand("INSERT INTO Users VALUES (?, ?)", cn);
                iU.Parameters.Add("@p1", OleDbType.VarChar, 30);
                iU.Parameters.Add("@p2", OleDbType.VarChar, 64);
                iU.Parameters[0].Value = String.Concat(txt_mail.Text, txt_domain.Text);
                iU.Parameters[1].Value = Program.sha256_hash(txt_psw.Text);
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
                     return;
                }

                OleDbCommand sPid = new OleDbCommand("SELECT id FROM Posts WHERE title = ?", cn);
                sPid.Parameters.Add("@p1", OleDbType.VarChar, 50);
                sPid.Parameters[0].Value = cb_post.SelectedItem.ToString();
                String postId = Program.selectFirstFrom(sPid, "id");

                OleDbCommand iE = new OleDbCommand("INSERT INTO Employees VALUES (?, ?, ?)", cn);
                iE.Parameters.Add("@p1", OleDbType.VarChar, 50);
                iE.Parameters.Add("@p2", OleDbType.Integer);
                iE.Parameters.Add("@p3", OleDbType.VarChar, 30);
                iE.Parameters[0].Value = String.Concat(txt_f.Text, " ", txt_i.Text, " ", txt_o.Text);
                iE.Parameters[1].Value = int.Parse(postId);
                iE.Parameters[2].Value = String.Concat(txt_mail.Text, txt_domain.Text);
 
                try
                {
                    iE.ExecuteNonQuery();
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных при добавлении сотрудника, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }

                OleDbCommand sEid = new OleDbCommand("SELECT id FROM Employees WHERE email = ?", cn);
                sEid.Parameters.Add("@p1", OleDbType.VarChar, 30);
                sEid.Parameters[0].Value = String.Concat(txt_mail.Text, txt_domain.Text); 
                String employeeId = Program.selectFirstFrom(sEid, "id");

                OleDbCommand iED = new OleDbCommand("INSERT INTO EmployeesDetails (employeeId, hireDate, phone)" +
                    " VALUES (?, ?, ?)", cn);
                iED.Parameters.Add("@p1", OleDbType.Integer);
                iED.Parameters.Add("@p2", OleDbType.Date);
                iED.Parameters.Add("@p3", OleDbType.VarChar, 11);
                iED.Parameters[0].Value = int.Parse(employeeId);
                iED.Parameters[1].Value = DateTime.Today.Date.ToString("d");
                iED.Parameters[2].Value = txt_phone.Text;

                try
                {
                    iED.ExecuteNonQuery();
                    MessageBox.Show("Новый работник был успешно добавлен", "Успех");
                    txt_phone.Text = "";
                    txt_f.Text = "";
                    txt_i.Text = "";
                    txt_o.Text = "";
                    txt_mail.Text = "";
                    txt_psw.Text = "";
                    txt_psw2.Text = "";
                    cb_post.SelectedItem = null;
                    cb_post.Text = "";
    
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных при добавлении сотрудника, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }
                
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if(txt_phone.Text == "" && num == '0')
            {
                e.Handled = true;
            }
        }

        private void cb_post_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
