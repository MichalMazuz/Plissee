using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlisseeProgect.Bll;

namespace PlisseeProgect.Gui
{
    public partial class UserSingleCustomer : UserControl
    { 
        CityDB tblCity;
        CustomerDB tblCustomers;
        Customer c;
        bool flagUpdate = false;
        int num = 0;
        public UserSingleCustomer()
        {
            InitializeComponent();
            tblCustomers = new CustomerDB();
            tblCity = new CityDB();
            cmb_city.DataSource = tblCity.GetList();
            cmb_city.SelectedIndex = -1;
        }
        public UserSingleCustomer(string customerId,int num):this()
        {
            txt_tz.Text = customerId;
            txt_tz.ReadOnly = true;
            this.num = num;
        }
        public UserSingleCustomer(Customer cu) : this()
        {
            this.c = cu;
            Fill(cu);
            flagUpdate = true;
        }
        public void Fill(Customer cu)
        {
            Customer c = cu;
            txt_tz.Text = c.Tz;
            txt_tz.ReadOnly = true;
            txt_fname.Text = c.FirstName;
            txt_lname.Text = c.LastName;
            txt_phone.Text = c.Phone;
            txt_note2.Text = c.Note;
            txt_mail.Text = c.Mail;
            cmb_city.SelectedItem = c.CityOfC();
            cmb_city.Text = c.CityOfC().ToString();
        }
        public void ReadOnly()
        {
            btn_save.Visible = false;
            txt_tz.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_note2.ReadOnly = true;
            cmb_city.Enabled = false;
            txt_mail.ReadOnly = true;
        }
        public bool CreateField(Customer s)
        {
            bool flagOk = true;
            errorProvider1.Clear();
            try
            {
                if (txt_tz.Text == "")
                    throw new Exception("הקש תעודת זהות");
                s.Tz = txt_tz.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_tz, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_fname.Text == "")
                    throw new Exception("הקש שם פרטי");
                if(txt_fname.Text.Length<2)
                    throw new Exception("הקש שם מלא");
                s.FirstName = txt_fname.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_fname, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_phone.Text == "")
                    throw new Exception("הקש מספר טלפון");
                s.Phone = txt_phone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_phone, ex.Message);
                flagOk = false;
            }
            try
            {
                if (cmb_city.SelectedIndex < 0)
                    throw new Exception("בחר עיר");
                s.Citycode = ((City)cmb_city.SelectedItem).CityCode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_city, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_mail.Text == "")
                    throw new Exception("הקש כתובת מייל");
                s.Mail = txt_mail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_mail, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_lname.Text == "")
                    throw new Exception("הקש שם משפחה");
                if (txt_fname.Text.Length < 2)
                    throw new Exception("הקש שם משפחה מלא");
                s.LastName = txt_lname.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_lname, ex.Message);
                flagOk = false;
            }
            s.Note = txt_note2.Text;
            s.Status="פעיל";
            return flagOk;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
            {
                if (CreateField(c))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן לקוח זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        
                        btn_save.Enabled = false;
                        tblCustomers.UpDateRow(c);
                        OpenUc();
                        txt_tz.Text = "";
                    }
                }
            }
            else
            {
                Customer s = new Customer();
                if (this.tblCustomers.Find(txt_tz.Text) != null) 
                    MessageBox.Show("ת.ז זו קיימת במערכת");
                else
                {
                    if (CreateField(s))
                    {
                        DialogResult d = MessageBox.Show("?האם בצונך להוסיף לקוח זה", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (d == DialogResult.Yes)
                        {
                            btn_save.Enabled = false;
                            tblCustomers.AddNew(s);
                           
                        }
                        if (num == 1)
                        {
                            Control c = this.Parent;
                            CloseSingleCustomer();
                        }
                        else
                            OpenUc();
                    }
                }
              
            }
            
        }

        private void CloseSingleCustomer()
        {
            foreach (Control item in this.Parent.Controls)
            {
                if (item is UserSale)
                {
                    item.Visible = true;
                }
            }
            this.Parent.Controls.Remove(this);
        }

        private void OpenUc()
        {
            UserCustomer f1 = new UserCustomer();
            f1.Location = new Point(148, 98);
            this.Controls.Clear();
            Controls.Add(f1);
            f1.Dock = DockStyle.Fill;
            f1.dgv_customers.DataSource = tblCustomers.GetList().Select(x => new { תעודת_זהות = x.Tz, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, עיר = x.CityOfC().NameCity}).ToList();

        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txt_tz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}
