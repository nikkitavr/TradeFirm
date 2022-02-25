
namespace DBCourseEmployees
{
    partial class ShopManagment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopManagment));
            this.ShopTabControl = new System.Windows.Forms.TabControl();
            this.tab_shop = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_shop = new System.Windows.Forms.DataGridView();
            this.btn_shipToStorage = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.txt_shelfDate = new System.Windows.Forms.TextBox();
            this.lbl_shelf = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_deliveryDate = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_orderId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_shipments = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dg_shipments = new System.Windows.Forms.DataGridView();
            this.chb_onlyToday = new System.Windows.Forms.CheckBox();
            this.btn_shipToStorage2 = new System.Windows.Forms.Button();
            this.btn_unload = new System.Windows.Forms.Button();
            this.txt_status2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_deliveryDate2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_orderId2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update_dgs = new System.Windows.Forms.Timer(this.components);
            this.ShopTabControl.SuspendLayout();
            this.tab_shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_shop)).BeginInit();
            this.tab_shipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_shipments)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopTabControl
            // 
            this.ShopTabControl.Controls.Add(this.tab_shop);
            this.ShopTabControl.Controls.Add(this.tab_shipments);
            this.ShopTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopTabControl.Location = new System.Drawing.Point(0, 0);
            this.ShopTabControl.Name = "ShopTabControl";
            this.ShopTabControl.SelectedIndex = 0;
            this.ShopTabControl.Size = new System.Drawing.Size(1247, 627);
            this.ShopTabControl.TabIndex = 2;
            // 
            // tab_shop
            // 
            this.tab_shop.Controls.Add(this.splitContainer1);
            this.tab_shop.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_shop.Location = new System.Drawing.Point(4, 33);
            this.tab_shop.Name = "tab_shop";
            this.tab_shop.Padding = new System.Windows.Forms.Padding(3);
            this.tab_shop.Size = new System.Drawing.Size(1239, 590);
            this.tab_shop.TabIndex = 0;
            this.tab_shop.Text = "Магазин";
            this.tab_shop.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.dg_shop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.btn_shipToStorage);
            this.splitContainer1.Panel2.Controls.Add(this.btn_accept);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shelfDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_shelf);
            this.splitContainer1.Panel2.Controls.Add(this.txt_status);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txt_deliveryDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_orderId);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1233, 584);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // dg_shop
            // 
            this.dg_shop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_shop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_shop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_shop.Location = new System.Drawing.Point(0, 0);
            this.dg_shop.Name = "dg_shop";
            this.dg_shop.RowHeadersWidth = 51;
            this.dg_shop.RowTemplate.Height = 24;
            this.dg_shop.Size = new System.Drawing.Size(410, 584);
            this.dg_shop.TabIndex = 0;
            this.dg_shop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_shop_CellClick);
            // 
            // btn_shipToStorage
            // 
            this.btn_shipToStorage.BackColor = System.Drawing.Color.DarkRed;
            this.btn_shipToStorage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_shipToStorage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_shipToStorage.Location = new System.Drawing.Point(19, 256);
            this.btn_shipToStorage.Name = "btn_shipToStorage";
            this.btn_shipToStorage.Size = new System.Drawing.Size(275, 43);
            this.btn_shipToStorage.TabIndex = 129;
            this.btn_shipToStorage.Text = "Отправить на склад";
            this.btn_shipToStorage.UseVisualStyleBackColor = false;
            this.btn_shipToStorage.Click += new System.EventHandler(this.btn_shipToStorage_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_accept.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_accept.Location = new System.Drawing.Point(19, 207);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(275, 43);
            this.btn_accept.TabIndex = 128;
            this.btn_accept.Text = "Подтвердить получение";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txt_shelfDate
            // 
            this.txt_shelfDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_shelfDate.Location = new System.Drawing.Point(194, 158);
            this.txt_shelfDate.Name = "txt_shelfDate";
            this.txt_shelfDate.ReadOnly = true;
            this.txt_shelfDate.Size = new System.Drawing.Size(180, 32);
            this.txt_shelfDate.TabIndex = 127;
            // 
            // lbl_shelf
            // 
            this.lbl_shelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_shelf.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_shelf.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_shelf.Location = new System.Drawing.Point(14, 158);
            this.lbl_shelf.Name = "lbl_shelf";
            this.lbl_shelf.Size = new System.Drawing.Size(174, 32);
            this.lbl_shelf.TabIndex = 126;
            this.lbl_shelf.Text = "Хранение до";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status.Location = new System.Drawing.Point(194, 113);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(180, 32);
            this.txt_status.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 124;
            this.label2.Text = "Статус";
            // 
            // txt_deliveryDate
            // 
            this.txt_deliveryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_deliveryDate.Location = new System.Drawing.Point(194, 72);
            this.txt_deliveryDate.Name = "txt_deliveryDate";
            this.txt_deliveryDate.ReadOnly = true;
            this.txt_deliveryDate.Size = new System.Drawing.Size(180, 32);
            this.txt_deliveryDate.TabIndex = 123;
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_3.Location = new System.Drawing.Point(14, 72);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(174, 32);
            this.lbl_3.TabIndex = 122;
            this.lbl_3.Text = "Дата доставки";
            // 
            // txt_orderId
            // 
            this.txt_orderId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_orderId.Location = new System.Drawing.Point(194, 28);
            this.txt_orderId.Name = "txt_orderId";
            this.txt_orderId.ReadOnly = true;
            this.txt_orderId.Size = new System.Drawing.Size(180, 32);
            this.txt_orderId.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(14, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 32);
            this.label7.TabIndex = 120;
            this.label7.Text = "Номер заказа";
            // 
            // tab_shipments
            // 
            this.tab_shipments.Controls.Add(this.splitContainer3);
            this.tab_shipments.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_shipments.Location = new System.Drawing.Point(4, 33);
            this.tab_shipments.Name = "tab_shipments";
            this.tab_shipments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_shipments.Size = new System.Drawing.Size(1239, 590);
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
            this.splitContainer3.Panel2.Controls.Add(this.chb_onlyToday);
            this.splitContainer3.Panel2.Controls.Add(this.btn_shipToStorage2);
            this.splitContainer3.Panel2.Controls.Add(this.btn_unload);
            this.splitContainer3.Panel2.Controls.Add(this.txt_status2);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.txt_deliveryDate2);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.txt_orderId2);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Size = new System.Drawing.Size(1233, 584);
            this.splitContainer3.SplitterDistance = 411;
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
            this.dg_shipments.Size = new System.Drawing.Size(411, 584);
            this.dg_shipments.TabIndex = 0;
            this.dg_shipments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_shipments_CellClick);
            // 
            // chb_onlyToday
            // 
            this.chb_onlyToday.BackColor = System.Drawing.Color.Transparent;
            this.chb_onlyToday.Checked = true;
            this.chb_onlyToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_onlyToday.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_onlyToday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chb_onlyToday.Location = new System.Drawing.Point(420, 21);
            this.chb_onlyToday.Name = "chb_onlyToday";
            this.chb_onlyToday.Size = new System.Drawing.Size(358, 32);
            this.chb_onlyToday.TabIndex = 134;
            this.chb_onlyToday.Text = "Только сегодняшние поставки";
            this.chb_onlyToday.UseVisualStyleBackColor = false;
            this.chb_onlyToday.CheckedChanged += new System.EventHandler(this.chb_onlyToday_CheckedChanged);
            // 
            // btn_shipToStorage2
            // 
            this.btn_shipToStorage2.BackColor = System.Drawing.Color.DarkRed;
            this.btn_shipToStorage2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_shipToStorage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_shipToStorage2.Location = new System.Drawing.Point(15, 206);
            this.btn_shipToStorage2.Name = "btn_shipToStorage2";
            this.btn_shipToStorage2.Size = new System.Drawing.Size(262, 43);
            this.btn_shipToStorage2.TabIndex = 133;
            this.btn_shipToStorage2.Text = "Отправить на склад";
            this.btn_shipToStorage2.UseVisualStyleBackColor = false;
            this.btn_shipToStorage2.Click += new System.EventHandler(this.btn_shipToStorage2_Click);
            // 
            // btn_unload
            // 
            this.btn_unload.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_unload.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_unload.Location = new System.Drawing.Point(15, 157);
            this.btn_unload.Name = "btn_unload";
            this.btn_unload.Size = new System.Drawing.Size(262, 43);
            this.btn_unload.TabIndex = 132;
            this.btn_unload.Text = "Разгрузить";
            this.btn_unload.UseVisualStyleBackColor = false;
            this.btn_unload.Click += new System.EventHandler(this.btn_unload_Click);
            // 
            // txt_status2
            // 
            this.txt_status2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status2.Location = new System.Drawing.Point(190, 106);
            this.txt_status2.Name = "txt_status2";
            this.txt_status2.ReadOnly = true;
            this.txt_status2.Size = new System.Drawing.Size(180, 32);
            this.txt_status2.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 130;
            this.label1.Text = "Статус";
            // 
            // txt_deliveryDate2
            // 
            this.txt_deliveryDate2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_deliveryDate2.Location = new System.Drawing.Point(190, 65);
            this.txt_deliveryDate2.Name = "txt_deliveryDate2";
            this.txt_deliveryDate2.ReadOnly = true;
            this.txt_deliveryDate2.Size = new System.Drawing.Size(180, 32);
            this.txt_deliveryDate2.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 128;
            this.label3.Text = "Дата доставки";
            // 
            // txt_orderId2
            // 
            this.txt_orderId2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_orderId2.Location = new System.Drawing.Point(190, 21);
            this.txt_orderId2.Name = "txt_orderId2";
            this.txt_orderId2.ReadOnly = true;
            this.txt_orderId2.Size = new System.Drawing.Size(180, 32);
            this.txt_orderId2.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 126;
            this.label4.Text = "Номер заказа";
            // 
            // update_dgs
            // 
            this.update_dgs.Enabled = true;
            this.update_dgs.Interval = 5000;
            this.update_dgs.Tick += new System.EventHandler(this.update_dgs_Tick);
            // 
            // ShopManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 627);
            this.Controls.Add(this.ShopTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopManagment";
            this.Text = "Магазин";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShopManagment_Load);
            this.ShopTabControl.ResumeLayout(false);
            this.tab_shop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_shop)).EndInit();
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

        private System.Windows.Forms.TabControl ShopTabControl;
        private System.Windows.Forms.TabPage tab_shop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dg_shop;
        private System.Windows.Forms.TabPage tab_shipments;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dg_shipments;
        private System.Windows.Forms.TextBox txt_shelfDate;
        private System.Windows.Forms.Label lbl_shelf;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_deliveryDate;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.TextBox txt_orderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_shipToStorage;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_shipToStorage2;
        private System.Windows.Forms.Button btn_unload;
        private System.Windows.Forms.TextBox txt_status2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_deliveryDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_orderId2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_onlyToday;
        private System.Windows.Forms.Timer update_dgs;
    }
}