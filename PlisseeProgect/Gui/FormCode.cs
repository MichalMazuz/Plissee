using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlisseeProgect.Bll;

namespace PlisseeProgect.Gui
{
    public partial class FormCode : Form
    {
        public FormCode()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
            if (e.KeyChar == 13)
            {
                if (textBox1.Text == "1234")
                {
                    FormHome op = new FormHome();
                    this.Hide();
                    op.ShowDialog();
                }
                else
                {
                    MessageBox.Show("הקוד שהוקש שגוי");
                    textBox1.Text = "";
                }
            }

        }
    }
}
