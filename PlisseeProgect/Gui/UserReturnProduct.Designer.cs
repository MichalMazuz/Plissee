namespace PlisseeProgect.Gui
{
    partial class UserReturnProduct
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgv_salling_details = new System.Windows.Forms.DataGridView();
            this.dgv_salling = new System.Windows.Forms.DataGridView();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.btn_change_amount = new PlisseeProgect.btn_home();
            this.lab_home1 = new PlisseeProgect.lab_home();
            this.lab_home2 = new PlisseeProgect.lab_home();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salling_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salling)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(287, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // dgv_salling_details
            // 
            this.dgv_salling_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_salling_details.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_salling_details.Location = new System.Drawing.Point(12, 19);
            this.dgv_salling_details.Name = "dgv_salling_details";
            this.dgv_salling_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_salling_details.Size = new System.Drawing.Size(357, 210);
            this.dgv_salling_details.TabIndex = 28;
            this.dgv_salling_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salling_details_CellClick);
            // 
            // dgv_salling
            // 
            this.dgv_salling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_salling.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_salling.Location = new System.Drawing.Point(375, 79);
            this.dgv_salling.Name = "dgv_salling";
            this.dgv_salling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_salling.Size = new System.Drawing.Size(264, 244);
            this.dgv_salling.TabIndex = 25;
            this.dgv_salling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salling_CellClick);
            // 
            // cmb_search
            // 
            this.cmb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(375, 18);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(137, 21);
            this.cmb_search.TabIndex = 24;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // btn_change_amount
            // 
            this.btn_change_amount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_change_amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_amount.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_change_amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change_amount.Location = new System.Drawing.Point(182, 232);
            this.btn_change_amount.Name = "btn_change_amount";
            this.btn_change_amount.Size = new System.Drawing.Size(99, 25);
            this.btn_change_amount.TabIndex = 29;
            this.btn_change_amount.Text = "עדכן מלאי";
            this.btn_change_amount.UseVisualStyleBackColor = false;
            this.btn_change_amount.Click += new System.EventHandler(this.btn_change_amount_Click);
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(490, 58);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(46, 18);
            this.lab_home1.TabIndex = 27;
            this.lab_home1.Text = "קניות";
            // 
            // lab_home2
            // 
            this.lab_home2.AutoSize = true;
            this.lab_home2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home2.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home2.ForeColor = System.Drawing.Color.White;
            this.lab_home2.Location = new System.Drawing.Point(518, 19);
            this.lab_home2.Name = "lab_home2";
            this.lab_home2.Size = new System.Drawing.Size(68, 18);
            this.lab_home2.TabIndex = 26;
            this.lab_home2.Text = "קוד קניה";
            // 
            // UserReturnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_change_amount);
            this.Controls.Add(this.dgv_salling_details);
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.lab_home2);
            this.Controls.Add(this.dgv_salling);
            this.Controls.Add(this.cmb_search);
            this.Name = "UserReturnProduct";
            this.Size = new System.Drawing.Size(651, 340);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salling_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private btn_home btn_change_amount;
        public System.Windows.Forms.DataGridView dgv_salling_details;
        private lab_home lab_home1;
        private lab_home lab_home2;
        public System.Windows.Forms.DataGridView dgv_salling;
        private System.Windows.Forms.ComboBox cmb_search;
    }
}
