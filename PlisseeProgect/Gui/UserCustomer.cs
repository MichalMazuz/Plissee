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
    public partial class UserCustomer : UserControl
    {
        CustomerDB tblCustomers;
        Customer cus;
        public UserCustomer()
        {
            InitializeComponent();
            tblCustomers = new CustomerDB();
            cus = new Customer();
        }

        private void btn_add_cus_Click(object sender, EventArgs e)
        {
            Control c = this.Parent;
            UserSingleCustomer f1 = new UserSingleCustomer();
            f1.Location = new Point(148, 98);
            this.Parent.Controls.Clear();
            c.Controls.Add(f1);
            f1.Dock = DockStyle.Fill;
        }

        private void btn_change_cus_Click(object sender, EventArgs e)
        {
            if (dgv_customers.SelectedRows.Count > 0)
            {
                string tz = dgv_customers.SelectedRows[0].Cells[0].Value.ToString();
                cus = tblCustomers.Find(tz);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                UserSingleCustomer f = new UserSingleCustomer(cus);//שולחת את העצם שמצא לטופס 
                f.Location = new Point(148, 98);
                Control c = this.Parent;
                this.Parent.Controls.Clear();
                c.Controls.Add(f);
                f.Dock = DockStyle.Fill;
            }
        }

        private void btn_show_cus_Click(object sender, EventArgs e)
        {
            if (dgv_customers.SelectedRows.Count > 0)
            {
                string tz = dgv_customers.SelectedRows[0].Cells[0].Value.ToString();
                cus = tblCustomers.Find(tz);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                UserSingleCustomer f = new UserSingleCustomer(cus);//שולחת את העצם שמצא לטופס 
                f.ReadOnly();
                f.Location = new Point(148, 98);
                Control c = this.Parent;
                this.Parent.Controls.Clear();
                c.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                dgv_customers.DataSource = tblCustomers.GetList().Select(x => new 
                { 
                    תעודת_זהות = x.Tz,
                    שם_פרטי = x.FirstName,
                    שם_משפחה = x.LastName,
                    טלפון = x.Phone,
                    עיר = x.CityOfC().NameCity,
                }).OrderBy(x=>x.שם_משפחה).ToList();
            }
        }

        private void btn_reanun_cus_Click(object sender, EventArgs e)
        {
            dgv_customers.DataSource = tblCustomers.GetList().Select(x => new
            {
                תעודת_זהות = x.Tz,
                שם_פרטי = x.FirstName,
                שם_משפחה = x.LastName,
                טלפון = x.Phone,
                עיר = x.CityOfC().NameCity,
            }).OrderBy(x => x.שם_משפחה).ToList();
        }

        private void btn_home2_Click(object sender, EventArgs e)
        {
            if (dgv_customers.SelectedRows.Count > 0)
            {
                DialogResult s = MessageBox.Show("?האם ברצונך למחוק לקוח זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (s == DialogResult.Yes)
                {
                    string tz = dgv_customers.SelectedRows[0].Cells[0].Value.ToString();
                    cus = tblCustomers.Find(tz);
                    cus.Status = "לא פעיל";
                    tblCustomers.UpDateRow(cus);
                    dgv_customers.DataSource = tblCustomers.GetList().Select(x => new 
                    {
                        תעודת_זהות = x.Tz,
                        שם_פרטי = x.FirstName,
                        שם_משפחה = x.LastName,
                        טלפון = x.Phone,
                        עיר = x.CityOfC().NameCity 
                    }).OrderBy(x => x.שם_משפחה).ToList();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text!=" ")
           dgv_customers.DataSource= tblCustomers.GetList().Where(x => x.LastName.ToString().StartsWith(txt_search.Text)).Select(x => new 
           {
               תעודת_זהות = x.Tz,
               שם_פרטי = x.FirstName,
               שם_משפחה = x.LastName,
               טלפון = x.Phone,
               עיר = x.CityOfC().NameCity
           }).OrderBy(x => x.שם_משפחה).ToList();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}
