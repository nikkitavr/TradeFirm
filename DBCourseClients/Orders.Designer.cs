
namespace DBCourseClients
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_orders = new System.Windows.Forms.DataGridView();
            this.txt_shelfDate = new System.Windows.Forms.TextBox();
            this.lbl_shelf = new System.Windows.Forms.Label();
            this.btn_terminate = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orderDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_deliveryDate = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dg_orders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.txt_shelfDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_shelf);
            this.splitContainer1.Panel2.Controls.Add(this.btn_terminate);
            this.splitContainer1.Panel2.Controls.Add(this.txt_status);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txt_orderDate);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_price);
            this.splitContainer1.Panel2.Controls.Add(this.txt_deliveryDate);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_3);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_2);
            this.splitContainer1.Panel2.Controls.Add(this.txt_num);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_title);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 550);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // dg_orders
            // 
            this.dg_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_orders.Location = new System.Drawing.Point(0, 0);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.RowHeadersWidth = 51;
            this.dg_orders.RowTemplate.Height = 24;
            this.dg_orders.Size = new System.Drawing.Size(450, 550);
            this.dg_orders.TabIndex = 0;
            this.dg_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orders_CellClick);
            // 
            // txt_shelfDate
            // 
            this.txt_shelfDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_shelfDate.Location = new System.Drawing.Point(557, 271);
            this.txt_shelfDate.Name = "txt_shelfDate";
            this.txt_shelfDate.ReadOnly = true;
            this.txt_shelfDate.Size = new System.Drawing.Size(180, 32);
            this.txt_shelfDate.TabIndex = 119;
            // 
            // lbl_shelf
            // 
            this.lbl_shelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_shelf.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_shelf.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_shelf.Location = new System.Drawing.Point(377, 271);
            this.lbl_shelf.Name = "lbl_shelf";
            this.lbl_shelf.Size = new System.Drawing.Size(174, 32);
            this.lbl_shelf.TabIndex = 118;
            this.lbl_shelf.Text = "Хранение до";
            // 
            // btn_terminate
            // 
            this.btn_terminate.BackColor = System.Drawing.Color.DarkRed;
            this.btn_terminate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_terminate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminate.Location = new System.Drawing.Point(557, 15);
            this.btn_terminate.Name = "btn_terminate";
            this.btn_terminate.Size = new System.Drawing.Size(210, 43);
            this.btn_terminate.TabIndex = 117;
            this.btn_terminate.Text = "Отменить заказ";
            this.btn_terminate.UseVisualStyleBackColor = false;
            this.btn_terminate.Click += new System.EventHandler(this.btn_terminate_Click);
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status.Location = new System.Drawing.Point(189, 271);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(180, 32);
            this.txt_status.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 115;
            this.label2.Text = "Статус";
            // 
            // txt_orderDate
            // 
            this.txt_orderDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_orderDate.Location = new System.Drawing.Point(189, 170);
            this.txt_orderDate.Name = "txt_orderDate";
            this.txt_orderDate.ReadOnly = true;
            this.txt_orderDate.Size = new System.Drawing.Size(180, 32);
            this.txt_orderDate.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 113;
            this.label1.Text = "Дата заказа";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_price.Location = new System.Drawing.Point(189, 120);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(180, 32);
            this.txt_price.TabIndex = 112;
            // 
            // txt_deliveryDate
            // 
            this.txt_deliveryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_deliveryDate.Location = new System.Drawing.Point(189, 217);
            this.txt_deliveryDate.Name = "txt_deliveryDate";
            this.txt_deliveryDate.ReadOnly = true;
            this.txt_deliveryDate.Size = new System.Drawing.Size(180, 32);
            this.txt_deliveryDate.TabIndex = 111;
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_3.Location = new System.Drawing.Point(9, 220);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(174, 32);
            this.lbl_3.TabIndex = 110;
            this.lbl_3.Text = "Дата доставки";
            // 
            // lbl_2
            // 
            this.lbl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_2.Location = new System.Drawing.Point(9, 120);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(174, 32);
            this.lbl_2.TabIndex = 109;
            this.lbl_2.Text = "Стоимость";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_num.Location = new System.Drawing.Point(189, 71);
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(180, 32);
            this.txt_num.TabIndex = 108;
            // 
            // lbl_1
            // 
            this.lbl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_1.Location = new System.Drawing.Point(9, 71);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(174, 32);
            this.lbl_1.TabIndex = 107;
            this.lbl_1.Text = "Количество";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title.Location = new System.Drawing.Point(189, 22);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(341, 32);
            this.txt_title.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 32);
            this.label7.TabIndex = 105;
            this.label7.Text = "Название";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 550);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Мои заказы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dg_orders;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_orderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_deliveryDate;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_terminate;
        private System.Windows.Forms.TextBox txt_shelfDate;
        private System.Windows.Forms.Label lbl_shelf;
    }
}