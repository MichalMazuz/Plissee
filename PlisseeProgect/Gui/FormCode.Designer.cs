
namespace PlisseeProgect.Gui
{
    partial class FormCode
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_home1 = new PlisseeProgect.lab_home();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 368);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(356, 346);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(71, 19);
            this.lab_home1.TabIndex = 1;
            this.lab_home1.Text = "הקש קוד";
            // 
            // FormCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlisseeProgect.Properties.Resources.פליסה_לוגו_רקע_שקוף_PNG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "FormCode";
            this.Text = "FormCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private lab_home lab_home1;
    }
}