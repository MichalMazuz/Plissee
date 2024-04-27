namespace PlisseeProgect.Gui
{
    partial class UserOrdersArriving
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.dgv_orders_details = new System.Windows.Forms.DataGridView();
            this.lab_home1 = new PlisseeProgect.lab_home();
            this.lab_home2 = new PlisseeProgect.lab_home();
            this.btn_change_amount = new PlisseeProgect.btn_home();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(384, 32);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(137, 21);
            this.cmb_search.TabIndex = 0;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_orders.Location = new System.Drawing.Point(384, 93);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orders.Size = new System.Drawing.Size(264, 244);
            this.dgv_orders.TabIndex = 1;
            this.dgv_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellClick);
            // 
            // dgv_orders_details
            // 
            this.dgv_orders_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders_details.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_orders_details.Location = new System.Drawing.Point(21, 33);
            this.dgv_orders_details.Name = "dgv_orders_details";
            this.dgv_orders_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orders_details.Size = new System.Drawing.Size(357, 210);
            this.dgv_orders_details.TabIndex = 19;
            this.dgv_orders_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_details_CellClick);
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(478, 72);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(87, 18);
            this.lab_home1.TabIndex = 17;
            this.lab_home1.Text = "הצג פריטים";
            // 
            // lab_home2
            // 
            this.lab_home2.AutoSize = true;
            this.lab_home2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home2.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home2.ForeColor = System.Drawing.Color.White;
            this.lab_home2.Location = new System.Drawing.Point(527, 33);
            this.lab_home2.Name = "lab_home2";
            this.lab_home2.Size = new System.Drawing.Size(38, 18);
            this.lab_home2.TabIndex = 16;
            this.lab_home2.Text = "ספק";
            // 
            // btn_change_amount
            // 
            this.btn_change_amount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_change_amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_amount.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_change_amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change_amount.Location = new System.Drawing.Point(182, 246);
            this.btn_change_amount.Name = "btn_change_amount";
            this.btn_change_amount.Size = new System.Drawing.Size(70, 25);
            this.btn_change_amount.TabIndex = 22;
            this.btn_change_amount.Text = "עדכן";
            this.btn_change_amount.UseVisualStyleBackColor = false;
            this.btn_change_amount.Click += new System.EventHandler(this.btn_change_amount_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 249);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // UserOrdersArriving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_change_amount);
            this.Controls.Add(this.dgv_orders_details);
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.lab_home2);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.cmb_search);
            this.Name = "UserOrdersArriving";
            this.Size = new System.Drawing.Size(651, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_search;
        private lab_home lab_home2;
        private lab_home lab_home1;
        public System.Windows.Forms.DataGridView dgv_orders;
        private btn_home btn_change_amount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.DataGridView dgv_orders_details;
    }
}
