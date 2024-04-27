namespace PlisseeProgect.Gui
{
    partial class UserCustomer
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
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.btn_erase = new PlisseeProgect.btn_home();
            this.btn_raanen = new PlisseeProgect.btn_home();
            this.btn_show_cus = new PlisseeProgect.btn_home();
            this.btn_change_cus = new PlisseeProgect.btn_home();
            this.btn_add_cus = new PlisseeProgect.btn_home();
            this.lab_cust = new PlisseeProgect.lab_home();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customers
            // 
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customers.Location = new System.Drawing.Point(3, 66);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customers.Size = new System.Drawing.Size(517, 261);
            this.dgv_customers.TabIndex = 0;
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_erase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_erase.Location = new System.Drawing.Point(527, 239);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(110, 27);
            this.btn_erase.TabIndex = 6;
            this.btn_erase.Text = "מחיקת לקוח";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_home2_Click);
            // 
            // btn_raanen
            // 
            this.btn_raanen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_raanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raanen.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_raanen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_raanen.Location = new System.Drawing.Point(526, 195);
            this.btn_raanen.Name = "btn_raanen";
            this.btn_raanen.Size = new System.Drawing.Size(110, 27);
            this.btn_raanen.TabIndex = 5;
            this.btn_raanen.Text = "רענן תצוגה";
            this.btn_raanen.UseVisualStyleBackColor = false;
            this.btn_raanen.Click += new System.EventHandler(this.btn_reanun_cus_Click);
            // 
            // btn_show_cus
            // 
            this.btn_show_cus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_show_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_cus.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_show_cus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_cus.Location = new System.Drawing.Point(526, 151);
            this.btn_show_cus.Name = "btn_show_cus";
            this.btn_show_cus.Size = new System.Drawing.Size(110, 27);
            this.btn_show_cus.TabIndex = 4;
            this.btn_show_cus.Text = "הצגת לקוח";
            this.btn_show_cus.UseVisualStyleBackColor = false;
            this.btn_show_cus.Click += new System.EventHandler(this.btn_show_cus_Click);
            // 
            // btn_change_cus
            // 
            this.btn_change_cus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_change_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_cus.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_change_cus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change_cus.Location = new System.Drawing.Point(526, 108);
            this.btn_change_cus.Name = "btn_change_cus";
            this.btn_change_cus.Size = new System.Drawing.Size(110, 27);
            this.btn_change_cus.TabIndex = 3;
            this.btn_change_cus.Text = "עריכת לקוח";
            this.btn_change_cus.UseVisualStyleBackColor = false;
            this.btn_change_cus.Click += new System.EventHandler(this.btn_change_cus_Click);
            // 
            // btn_add_cus
            // 
            this.btn_add_cus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_cus.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_add_cus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_cus.Location = new System.Drawing.Point(526, 66);
            this.btn_add_cus.Name = "btn_add_cus";
            this.btn_add_cus.Size = new System.Drawing.Size(110, 27);
            this.btn_add_cus.TabIndex = 2;
            this.btn_add_cus.Text = "הוספת לקוח";
            this.btn_add_cus.UseVisualStyleBackColor = false;
            this.btn_add_cus.Click += new System.EventHandler(this.btn_add_cus_Click);
            // 
            // lab_cust
            // 
            this.lab_cust.AutoSize = true;
            this.lab_cust.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_cust.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_cust.ForeColor = System.Drawing.Color.White;
            this.lab_cust.Location = new System.Drawing.Point(423, 25);
            this.lab_cust.Name = "lab_cust";
            this.lab_cust.Size = new System.Drawing.Size(90, 27);
            this.lab_cust.TabIndex = 1;
            this.lab_cust.Text = "לקוחות";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(16, 31);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 7;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlisseeProgect.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(113, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_raanen);
            this.Controls.Add(this.btn_show_cus);
            this.Controls.Add(this.btn_change_cus);
            this.Controls.Add(this.btn_add_cus);
            this.Controls.Add(this.lab_cust);
            this.Controls.Add(this.dgv_customers);
            this.Location = new System.Drawing.Point(3, 66);
            this.Name = "UserCustomer";
            this.Size = new System.Drawing.Size(651, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private lab_home lab_cust;
        private btn_home btn_add_cus;
        public System.Windows.Forms.DataGridView dgv_customers;
        private btn_home btn_change_cus;
        private btn_home btn_show_cus;
        private btn_home btn_raanen;
        private btn_home btn_erase;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
