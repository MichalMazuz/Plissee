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
    public partial class FormOneSupplier : UserControl
    {
        CityDB tblCity;
        SupplierDB tblSuppliers;
        Supplier s;
        bool flagUpdate = false;
        public FormOneSupplier()
        {
            InitializeComponent();
            tblSuppliers = new SupplierDB();
            tblCity = new CityDB();
            cmb_city.DataSource = tblCity.GetList();
            cmb_city.SelectedIndex = -1;
        }
        public FormOneSupplier(Supplier sup):this()
        {
            this.s = sup;
            Fill(sup);
            flagUpdate = true;
           
        }
        public void Fill(Supplier s)
        {
            Supplier sup = s;
            txt_mail.Text = s.Mail;
            txt_name.Text = s.SupplierName;
            txt_phone.Text = s.Phone;
            txt_note1.Text = s.Note1;
            cmb_city.SelectedItem = s.CityOfSupplier();
            cmb_city.Text = s.CityOfSupplier().ToString();
        }
        public void ReadOnly()
        {
            btn_save.Visible = false;
            txt_mail.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_note1.ReadOnly = true;
            cmb_city.Enabled = false;
            btn_save.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public bool CreateField(Supplier s)
        {
            bool flagOk = true;
            errorProvider1.Clear();
            try
            {
                if (txt_name.Text == "")
                    throw new Exception("הקש שם");
                if (txt_name.Text.Length < 2)
                    throw new Exception("הקש שם מלא ");
                s.SupplierName = txt_name.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_name, ex.Message);
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
                s.Mail=txt_mail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_mail, ex.Message);
                flagOk = false;
            }
            if(!flagUpdate)//אם אתה במצב הוספה צור קוד חדש
           s.SupplierCode= tblSuppliers.GetNextKey();
            s.Note1 = txt_note1.Text;
            s.Status = "פעיל";
            return flagOk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
            {
                if (CreateField(s))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן ספק זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        btn_save.Enabled = false;
                        tblSuppliers.UpDateRow(s);
                        OpenUc();
                    }
                }
            }
            else
            {
                Supplier s = new Supplier();
                if (CreateField(s))
                {

                    DialogResult d = MessageBox.Show("?האם בצונך להוסיף ספק זה", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        btn_save.Enabled = false;
                        tblSuppliers.AddNew(s);
                        OpenUc();
                    }
                }
            }
        }
        private void OpenUc()
        {
            FormSupplier f1 = new FormSupplier();
            f1.Location = new Point(148, 98);
            this.Controls.Clear();
            Controls.Add(f1);
            f1.Dock = DockStyle.Fill;
            f1.dgv_supplier.DataSource = tblSuppliers.GetList().
                Select(v => new { קוד_ספק = v.SupplierCode,
                    הערות = v.Note1, שם = v.SupplierName,
                    טלפון = v.Phone,
                    עיר = v.CityOfSupplier().NameCity,
                    סטטוס = v.Status })
                .OrderBy(v=>v.שם).ToList();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }

        private void cmb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}
