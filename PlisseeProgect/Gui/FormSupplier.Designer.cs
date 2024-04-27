namespace PlisseeProgect.Gui
{
    partial class FormSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.add_sup = new System.Windows.Forms.Button();
            this.change_sup = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_raanen = new System.Windows.Forms.Button();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_home1 = new PlisseeProgect.lab_home();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_supplier.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_supplier.Location = new System.Drawing.Point(3, 66);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_supplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplier.Size = new System.Drawing.Size(517, 261);
            this.dgv_supplier.TabIndex = 0;
            // 
            // add_sup
            // 
            this.add_sup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_sup.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.add_sup.ForeColor = System.Drawing.Color.White;
            this.add_sup.Location = new System.Drawing.Point(526, 66);
            this.add_sup.Name = "add_sup";
            this.add_sup.Size = new System.Drawing.Size(110, 27);
            this.add_sup.TabIndex = 2;
            this.add_sup.Text = "הוספת ספק";
            this.add_sup.UseVisualStyleBackColor = false;
            this.add_sup.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_sup
            // 
            this.change_sup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.change_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_sup.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.change_sup.ForeColor = System.Drawing.Color.White;
            this.change_sup.Location = new System.Drawing.Point(526, 108);
            this.change_sup.Name = "change_sup";
            this.change_sup.Size = new System.Drawing.Size(110, 27);
            this.change_sup.TabIndex = 2;
            this.change_sup.Text = "עריכת ספק";
            this.change_sup.UseVisualStyleBackColor = false;
            this.change_sup.Click += new System.EventHandler(this.change_sup_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Location = new System.Drawing.Point(526, 192);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(110, 27);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "הצגת ספק";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_erase.ForeColor = System.Drawing.Color.White;
            this.btn_erase.Location = new System.Drawing.Point(526, 150);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(110, 27);
            this.btn_erase.TabIndex = 2;
            this.btn_erase.Text = "מחיקת ספק";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_raanen
            // 
            this.btn_raanen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_raanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raanen.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_raanen.ForeColor = System.Drawing.Color.White;
            this.btn_raanen.Location = new System.Drawing.Point(526, 235);
            this.btn_raanen.Name = "btn_raanen";
            this.btn_raanen.Size = new System.Drawing.Size(110, 27);
            this.btn_raanen.TabIndex = 2;
            this.btn_raanen.Text = "רענן תצוגה";
            this.btn_raanen.UseVisualStyleBackColor = false;
            this.btn_raanen.Click += new System.EventHandler(this.btn_raanen_Click);
            // 
            // cmb_search
            // 
            this.cmb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(3, 25);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 21);
            this.cmb_search.TabIndex = 5;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlisseeProgect.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(130, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(423, 25);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(81, 27);
            this.lab_home1.TabIndex = 6;
            this.lab_home1.Text = "ספקים";
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_raanen);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.change_sup);
            this.Controls.Add(this.add_sup);
            this.Controls.Add(this.dgv_supplier);
            this.Location = new System.Drawing.Point(148, 98);
            this.Name = "FormSupplier";
            this.Size = new System.Drawing.Size(651, 340);
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_sup;
        private System.Windows.Forms.Button change_sup;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_raanen;
        public System.Windows.Forms.DataGridView dgv_supplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_search;
        private lab_home lab_home1;
    }
}
