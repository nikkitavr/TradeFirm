
namespace DBCourseEmployees
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_o = new System.Windows.Forms.TextBox();
            this.txt_i = new System.Windows.Forms.TextBox();
            this.txt_f = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_changePsw = new System.Windows.Forms.Button();
            this.txt_oldPsw = new System.Windows.Forms.TextBox();
            this.lbl_psw3 = new System.Windows.Forms.Label();
            this.lbl_psw1 = new System.Windows.Forms.Label();
            this.txt_newPsw2 = new System.Windows.Forms.TextBox();
            this.txt_newPsw = new System.Windows.Forms.TextBox();
            this.lbl_psw2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phone.Location = new System.Drawing.Point(153, 152);
            this.txt_phone.Mask = "0 (000) 000-00-00";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(168, 32);
            this.txt_phone.TabIndex = 41;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_change.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_change.Location = new System.Drawing.Point(373, 20);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(225, 40);
            this.btn_change.TabIndex = 40;
            this.btn_change.Text = "Редактировать";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_o
            // 
            this.txt_o.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_o.Location = new System.Drawing.Point(153, 106);
            this.txt_o.Name = "txt_o";
            this.txt_o.Size = new System.Drawing.Size(168, 32);
            this.txt_o.TabIndex = 35;
            this.txt_o.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_o_KeyPress);
            // 
            // txt_i
            // 
            this.txt_i.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_i.Location = new System.Drawing.Point(153, 62);
            this.txt_i.Name = "txt_i";
            this.txt_i.Size = new System.Drawing.Size(168, 32);
            this.txt_i.TabIndex = 34;
            this.txt_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_i_KeyPress);
            // 
            // txt_f
            // 
            this.txt_f.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_f.Location = new System.Drawing.Point(153, 20);
            this.txt_f.Name = "txt_f";
            this.txt_f.Size = new System.Drawing.Size(168, 32);
            this.txt_f.TabIndex = 33;
            this.txt_f.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_f_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Фамилия";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_mail.Location = new System.Drawing.Point(153, 197);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(168, 32);
            this.txt_mail.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(17, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 30);
            this.label12.TabIndex = 42;
            this.label12.Text = "Почта";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_salary.Location = new System.Drawing.Point(153, 291);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(168, 32);
            this.txt_salary.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(17, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "Зарплата";
            // 
            // txt_post
            // 
            this.txt_post.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_post.Location = new System.Drawing.Point(153, 244);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(168, 32);
            this.txt_post.TabIndex = 47;
            this.txt_post.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(17, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 30);
            this.label6.TabIndex = 46;
            this.label6.Text = "Должность";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_changePsw
            // 
            this.btn_changePsw.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_changePsw.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_changePsw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_changePsw.Location = new System.Drawing.Point(604, 20);
            this.btn_changePsw.Name = "btn_changePsw";
            this.btn_changePsw.Size = new System.Drawing.Size(225, 40);
            this.btn_changePsw.TabIndex = 48;
            this.btn_changePsw.Text = "Изменить пароль";
            this.btn_changePsw.UseVisualStyleBackColor = false;
            this.btn_changePsw.Click += new System.EventHandler(this.btn_changePsw_Click);
            // 
            // txt_oldPsw
            // 
            this.txt_oldPsw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_oldPsw.Location = new System.Drawing.Point(641, 86);
            this.txt_oldPsw.Name = "txt_oldPsw";
            this.txt_oldPsw.Size = new System.Drawing.Size(287, 32);
            this.txt_oldPsw.TabIndex = 52;
            this.txt_oldPsw.UseSystemPasswordChar = true;
            // 
            // lbl_psw3
            // 
            this.lbl_psw3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_psw3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_psw3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_psw3.Location = new System.Drawing.Point(377, 178);
            this.lbl_psw3.Name = "lbl_psw3";
            this.lbl_psw3.Size = new System.Drawing.Size(258, 33);
            this.lbl_psw3.TabIndex = 51;
            this.lbl_psw3.Text = "Подтвердите пароль";
            // 
            // lbl_psw1
            // 
            this.lbl_psw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_psw1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_psw1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_psw1.Location = new System.Drawing.Point(377, 86);
            this.lbl_psw1.Name = "lbl_psw1";
            this.lbl_psw1.Size = new System.Drawing.Size(258, 32);
            this.lbl_psw1.TabIndex = 50;
            this.lbl_psw1.Text = " Старый пароль";
            // 
            // txt_newPsw2
            // 
            this.txt_newPsw2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_newPsw2.Location = new System.Drawing.Point(641, 179);
            this.txt_newPsw2.Name = "txt_newPsw2";
            this.txt_newPsw2.Size = new System.Drawing.Size(287, 32);
            this.txt_newPsw2.TabIndex = 49;
            this.txt_newPsw2.UseSystemPasswordChar = true;
            // 
            // txt_newPsw
            // 
            this.txt_newPsw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_newPsw.Location = new System.Drawing.Point(641, 135);
            this.txt_newPsw.Name = "txt_newPsw";
            this.txt_newPsw.Size = new System.Drawing.Size(287, 32);
            this.txt_newPsw.TabIndex = 54;
            this.txt_newPsw.UseSystemPasswordChar = true;
            // 
            // lbl_psw2
            // 
            this.lbl_psw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_psw2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_psw2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_psw2.Location = new System.Drawing.Point(377, 135);
            this.lbl_psw2.Name = "lbl_psw2";
            this.lbl_psw2.Size = new System.Drawing.Size(258, 32);
            this.lbl_psw2.TabIndex = 53;
            this.lbl_psw2.Text = " Новый пароль";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_save.Location = new System.Drawing.Point(373, 285);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(225, 40);
            this.btn_save.TabIndex = 55;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_cancel.Location = new System.Drawing.Point(604, 285);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(225, 40);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "Отменить";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 542);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_newPsw);
            this.Controls.Add(this.lbl_psw2);
            this.Controls.Add(this.txt_oldPsw);
            this.Controls.Add(this.lbl_psw3);
            this.Controls.Add(this.lbl_psw1);
            this.Controls.Add(this.txt_newPsw2);
            this.Controls.Add(this.btn_changePsw);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_o);
            this.Controls.Add(this.txt_i);
            this.Controls.Add(this.txt_f);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.Text = "Профиль";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_o;
        private System.Windows.Forms.TextBox txt_i;
        private System.Windows.Forms.TextBox txt_f;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_changePsw;
        private System.Windows.Forms.TextBox txt_oldPsw;
        private System.Windows.Forms.Label lbl_psw3;
        private System.Windows.Forms.Label lbl_psw1;
        private System.Windows.Forms.TextBox txt_newPsw2;
        private System.Windows.Forms.TextBox txt_newPsw;
        private System.Windows.Forms.Label lbl_psw2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}