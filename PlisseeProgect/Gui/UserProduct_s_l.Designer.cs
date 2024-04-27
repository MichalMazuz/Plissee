
namespace PlisseeProgect.Gui
{
    partial class UserProduct_s_l
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
            this.checkedListBox_size = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_length = new System.Windows.Forms.CheckedListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.lab_ = new PlisseeProgect.lab_home();
            this.lab_size = new PlisseeProgect.lab_home();
            this.SuspendLayout();
            // 
            // checkedListBox_size
            // 
            this.checkedListBox_size.CheckOnClick = true;
            this.checkedListBox_size.FormattingEnabled = true;
            this.checkedListBox_size.Location = new System.Drawing.Point(356, 47);
            this.checkedListBox_size.Name = "checkedListBox_size";
            this.checkedListBox_size.Size = new System.Drawing.Size(120, 229);
            this.checkedListBox_size.TabIndex = 0;
            this.checkedListBox_size.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_size_ItemCheck);
            // 
            // checkedListBox_length
            // 
            this.checkedListBox_length.CheckOnClick = true;
            this.checkedListBox_length.FormattingEnabled = true;
            this.checkedListBox_length.Location = new System.Drawing.Point(143, 47);
            this.checkedListBox_length.Name = "checkedListBox_length";
            this.checkedListBox_length.Size = new System.Drawing.Size(120, 229);
            this.checkedListBox_length.TabIndex = 1;
            this.checkedListBox_length.Visible = false;
            this.checkedListBox_length.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_length_ItemCheck);
            this.checkedListBox_length.SelectedIndexChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(18, 293);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(248, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(500, 294);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(103, 27);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "חזור";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lab_
            // 
            this.lab_.AutoSize = true;
            this.lab_.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_.ForeColor = System.Drawing.Color.White;
            this.lab_.Location = new System.Drawing.Point(169, 23);
            this.lab_.Name = "lab_";
            this.lab_.Size = new System.Drawing.Size(71, 21);
            this.lab_.TabIndex = 4;
            this.lab_.Text = "אורכים";
            this.lab_.Click += new System.EventHandler(this.lab__Click);
            // 
            // lab_size
            // 
            this.lab_size.AutoSize = true;
            this.lab_size.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_size.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_size.ForeColor = System.Drawing.Color.White;
            this.lab_size.Location = new System.Drawing.Point(392, 23);
            this.lab_size.Name = "lab_size";
            this.lab_size.Size = new System.Drawing.Size(60, 21);
            this.lab_size.TabIndex = 3;
            this.lab_size.Text = "מידות";
            // 
            // UserProduct_s_l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lab_);
            this.Controls.Add(this.lab_size);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.checkedListBox_length);
            this.Controls.Add(this.checkedListBox_size);
            this.Name = "UserProduct_s_l";
            this.Size = new System.Drawing.Size(651, 340);
            this.Load += new System.EventHandler(this.UserProduct_s_l_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_size;
        private System.Windows.Forms.CheckedListBox checkedListBox_length;
        private lab_home lab_size;
        private lab_home lab_;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_return;
    }
}
