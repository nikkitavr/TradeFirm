
namespace DBCourseEmployees
{
    partial class StorageManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageManagment));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_storage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_testMode = new System.Windows.Forms.CheckBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.btn_makeOrder = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.StorageTabControl = new System.Windows.Forms.TabControl();
            this.tab_storage = new System.Windows.Forms.TabPage();
            this.tab_shipments = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dg_shipments = new System.Windows.Forms.DataGridView();
            this.btn_dock = new System.Windows.Forms.Button();
            this.chb_onlyToday = new System.Windows.Forms.CheckBox();
            this.txt_count2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_title2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_storage)).BeginInit();
            this.StorageTabControl.SuspendLayout();
            this.tab_storage.SuspendLayout();
            this.tab_shipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_shipments)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.dg_storage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_testMode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_id);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_capacity);
            this.splitContainer1.Panel2.Controls.Add(this.btn_makeOrder);
            this.splitContainer1.Panel2.Controls.Add(this.txt_num);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt_title);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 565);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 0;
            // 
            // dg_storage
            // 
            this.dg_storage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_storage.Location = new System.Drawing.Point(0, 0);
            this.dg_storage.Name = "dg_storage";
            this.dg_storage.RowHeadersWidth = 51;
            this.dg_storage.RowTemplate.Height = 24;
            this.dg_storage.Size = new System.Drawing.Size(418, 565);
            this.dg_storage.TabIndex = 0;
            this.dg_storage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_storage_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(360, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "/";
            // 
            // checkBox_testMode
            // 
            this.checkBox_testMode.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBox_testMode.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_testMode.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_testMode.Location = new System.Drawing.Point(470, 31);
            this.checkBox_testMode.Name = "checkBox_testMode";
            this.checkBox_testMode.Size = new System.Drawing.Size(295, 32);
            this.checkBox_testMode.TabIndex = 84;
            this.checkBox_testMode.Text = "Режим тестирования";
            this.checkBox_testMode.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_id.Location = new System.Drawing.Point(229, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(172, 32);
            this.txt_id.TabIndex = 74;
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_capacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_capacity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_capacity.Location = new System.Drawing.Point(373, 118);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(28, 24);
            this.lbl_capacity.TabIndex = 41;
            this.lbl_capacity.Text = "xx";
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_makeOrder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_makeOrder.Location = new System.Drawing.Point(470, 104);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(302, 43);
            this.btn_makeOrder.TabIndex = 72;
            this.btn_makeOrder.Text = "Обновить ассортимент";
            this.btn_makeOrder.UseVisualStyleBackColor = false;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_num.Location = new System.Drawing.Point(229, 115);
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(125, 32);
            this.txt_num.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 32);
            this.label5.TabIndex = 73;
            this.label5.Text = "Артикул фирмы";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(21, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 32);
            this.label11.TabIndex = 81;
            this.label11.Text = "Количество";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(21, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 32);
            this.label7.TabIndex = 75;
            this.label7.Text = "Название";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title.Location = new System.Drawing.Point(229, 73);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(172, 32);
            this.txt_title.TabIndex = 76;
            // 
            // StorageTabControl
            // 
            this.StorageTabControl.Controls.Add(this.tab_storage);
            this.StorageTabControl.Controls.Add(this.tab_shipments);
            this.StorageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageTabControl.Location = new System.Drawing.Point(0, 0);
            this.StorageTabControl.Name = "StorageTabControl";
            this.StorageTabControl.SelectedIndex = 0;
            this.StorageTabControl.Size = new System.Drawing.Size(1271, 608);
            this.StorageTabControl.TabIndex = 1;
            // 
            // tab_storage
            // 
            this.tab_storage.Controls.Add(this.splitContainer1);
            this.tab_storage.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_storage.Location = new System.Drawing.Point(4, 33);
            this.tab_storage.Name = "tab_storage";
            this.tab_storage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_storage.Size = new System.Drawing.Size(1263, 571);
            this.tab_storage.TabIndex = 0;
            this.tab_storage.Text = "Склад";
            this.tab_storage.UseVisualStyleBackColor = true;
            // 
            // tab_shipments
            // 
            this.tab_shipments.Controls.Add(this.splitContainer3);
            this.tab_shipments.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_shipments.Location = new System.Drawing.Point(4, 33);
            this.tab_shipments.Name = "tab_shipments";
            this.tab_shipments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_shipments.Size = new System.Drawing.Size(1263, 571);
            this.tab_shipments.TabIndex = 1;
            this.tab_shipments.Text = "Поступления";
            this.tab_shipments.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dg_shipments);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer3.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.Panel2.BackgroundImage")));
            this.splitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel2.Controls.Add(this.btn_dock);
            this.splitContainer3.Panel2.Controls.Add(this.chb_onlyToday);
            this.splitContainer3.Panel2.Controls.Add(this.txt_count2);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.txt_title2);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.txt_id2);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Size = new System.Drawing.Size(1257, 565);
            this.splitContainer3.SplitterDistance = 419;
            this.splitContainer3.TabIndex = 0;
            // 
            // dg_shipments
            // 
            this.dg_shipments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_shipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_shipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_shipments.Location = new System.Drawing.Point(0, 0);
            this.dg_shipments.Name = "dg_shipments";
            this.dg_shipments.RowHeadersWidth = 51;
            this.dg_shipments.RowTemplate.Height = 24;
            this.dg_shipments.Size = new System.Drawing.Size(419, 565);
            this.dg_shipments.TabIndex = 0;
            this.dg_shipments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_shipments_CellClick);
            // 
            // btn_dock
            // 
            this.btn_dock.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_dock.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dock.Location = new System.Drawing.Point(441, 102);
            this.btn_dock.Name = "btn_dock";
            this.btn_dock.Size = new System.Drawing.Size(337, 43);
            this.btn_dock.TabIndex = 90;
            this.btn_dock.Text = "Разгрузить";
            this.btn_dock.UseVisualStyleBackColor = false;
            this.btn_dock.Click += new System.EventHandler(this.btn_dock_Click);
            // 
            // chb_onlyToday
            // 
            this.chb_onlyToday.BackColor = System.Drawing.Color.Transparent;
            this.chb_onlyToday.Checked = true;
            this.chb_onlyToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_onlyToday.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_onlyToday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chb_onlyToday.Location = new System.Drawing.Point(441, 27);
            this.chb_onlyToday.Name = "chb_onlyToday";
            this.chb_onlyToday.Size = new System.Drawing.Size(358, 32);
            this.chb_onlyToday.TabIndex = 89;
            this.chb_onlyToday.Text = "Только сегодняшние поставки";
            this.chb_onlyToday.UseVisualStyleBackColor = false;
            this.chb_onlyToday.CheckedChanged += new System.EventHandler(this.chb_onlyToday_CheckedChanged);
            // 
            // txt_count2
            // 
            this.txt_count2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_count2.Location = new System.Drawing.Point(221, 113);
            this.txt_count2.Name = "txt_count2";
            this.txt_count2.ReadOnly = true;
            this.txt_count2.Size = new System.Drawing.Size(172, 32);
            this.txt_count2.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 87;
            this.label4.Text = "Количество";
            // 
            // txt_title2
            // 
            this.txt_title2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title2.Location = new System.Drawing.Point(221, 68);
            this.txt_title2.Name = "txt_title2";
            this.txt_title2.ReadOnly = true;
            this.txt_title2.Size = new System.Drawing.Size(172, 32);
            this.txt_title2.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 85;
            this.label6.Text = "Название";
            // 
            // txt_id2
            // 
            this.txt_id2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_id2.Location = new System.Drawing.Point(221, 27);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.ReadOnly = true;
            this.txt_id2.Size = new System.Drawing.Size(172, 32);
            this.txt_id2.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(13, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 32);
            this.label8.TabIndex = 83;
            this.label8.Text = "Артикул фирмы";
            // 
            // StorageManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 608);
            this.Controls.Add(this.StorageTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StorageManagment";
            this.Text = "Склад";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StorageManagment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_storage)).EndInit();
            this.StorageTabControl.ResumeLayout(false);
            this.tab_storage.ResumeLayout(false);
            this.tab_shipments.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_shipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dg_storage;
        private System.Windows.Forms.TabControl StorageTabControl;
        private System.Windows.Forms.TabPage tab_storage;
        private System.Windows.Forms.TabPage tab_shipments;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_makeOrder;
        private System.Windows.Forms.CheckBox checkBox_testMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dg_shipments;
        private System.Windows.Forms.TextBox txt_count2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_title2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_onlyToday;
        private System.Windows.Forms.Button btn_dock;
    }
}