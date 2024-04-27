namespace PlisseeProgect.Gui
{
    partial class UserOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.listbox_company = new System.Windows.Forms.ListBox();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_size_length = new PlisseeProgect.btn_home();
            this.lab_home1 = new PlisseeProgect.lab_home();
            this.btn_remove = new PlisseeProgect.btn_home();
            this.btn_save = new PlisseeProgect.btn_home();
            this.btn_continue = new PlisseeProgect.btn_home();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(34, 15);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 21);
            this.cmb_search.TabIndex = 6;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // listbox_company
            // 
            this.listbox_company.FormattingEnabled = true;
            this.listbox_company.Location = new System.Drawing.Point(66, 42);
            this.listbox_company.Name = "listbox_company";
            this.listbox_company.Size = new System.Drawing.Size(121, 69);
            this.listbox_company.TabIndex = 8;
            this.listbox_company.SelectedIndexChanged += new System.EventHandler(this.company_SelectedIndexChanged);
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orders.Location = new System.Drawing.Point(4, 117);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orders.Size = new System.Drawing.Size(240, 150);
            this.dgv_orders.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 21);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(389, 251);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "קוד מוצר";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "שם מוצר";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מחיר ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "כמות";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "תאור";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "מידה";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "אורך";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "סך הכל";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_size_length);
            this.panel1.Controls.Add(this.dgv_orders);
            this.panel1.Controls.Add(this.listbox_company);
            this.panel1.Controls.Add(this.lab_home1);
            this.panel1.Controls.Add(this.cmb_search);
            this.panel1.Location = new System.Drawing.Point(394, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 334);
            this.panel1.TabIndex = 16;
            // 
            // btn_size_length
            // 
            this.btn_size_length.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_size_length.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_size_length.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_size_length.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_size_length.Location = new System.Drawing.Point(55, 283);
            this.btn_size_length.Name = "btn_size_length";
            this.btn_size_length.Size = new System.Drawing.Size(159, 25);
            this.btn_size_length.TabIndex = 14;
            this.btn_size_length.Text = "בחירת מידות ואורכים";
            this.btn_size_length.UseVisualStyleBackColor = false;
            this.btn_size_length.Click += new System.EventHandler(this.btn_home2_Click);
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(161, 16);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(53, 18);
            this.lab_home1.TabIndex = 7;
            this.lab_home1.Text = "ספקים";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(158, 293);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(139, 25);
            this.btn_remove.TabIndex = 17;
            this.btn_remove.Text = "הסר מסל הרכישה";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(13, 288);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 34);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_home1_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_continue.Location = new System.Drawing.Point(335, 293);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(57, 25);
            this.btn_continue.TabIndex = 11;
            this.btn_continue.Text = "המשך";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_save_p_Click);
            // 
            // UserOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_continue);
            this.Name = "UserOrders";
            this.Size = new System.Drawing.Size(651, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_search;
        private lab_home lab_home1;
        private System.Windows.Forms.ListBox listbox_company;
        private btn_home btn_continue;
        private btn_home btn_save;
        public System.Windows.Forms.DataGridView dgv_orders;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private btn_home btn_size_length;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private btn_home btn_remove;
    }
}
