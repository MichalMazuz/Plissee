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
using PlisseeProgect.Dal;
using PlisseeProgect.Gui;

namespace PlisseeProgect.Gui
{
    public partial class FormSupplier : UserControl
    {
        SupplierDB tblSuppliers;
        Supplier su;
        public FormSupplier()
        {
            InitializeComponent();
            tblSuppliers = new SupplierDB();
            su = new Supplier();
            cmb_search.DataSource = tblSuppliers.GetList().Where(x => x.Status == "פעיל").ToList();
            cmb_search.SelectedIndex = -1;
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Control c = this.Parent;
            FormOneSupplier f1 = new FormOneSupplier();
            f1.Location = new Point(148, 98);
            this.Parent.Controls.Clear();
            c.Controls.Add(f1);
            f1.Dock = DockStyle.Fill;
        }

        private void btn_raanen_Click(object sender, EventArgs e)
        {
            dgv_supplier.DataSource = tblSuppliers.GetList().Select(s => new 
            {
                קוד_ספק = s.SupplierCode,
                הערות = s.Note1,
                שם = s.SupplierName,
                טלפון = s.Phone,
                עיר = s.CityOfSupplier().NameCity,
                סטטוס = s.Status 
            }
            ).OrderBy(s=>s.שם).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_supplier.SelectedRows.Count > 0)
            {
                DialogResult s = MessageBox.Show("?האם ברצונך למחוק ספק זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (s == DialogResult.Yes)
                {
                    int code = Convert.ToInt32(dgv_supplier.SelectedRows[0].Cells[0].Value.ToString());
                    su = tblSuppliers.Find(code);
                    su.Status="לא פעיל";
                    tblSuppliers.UpDateRow(su);
                    dgv_supplier.DataSource = tblSuppliers.GetList().Select(v => new
                    {
                        קוד_ספק = v.SupplierCode,
                        הערות = v.Note1,
                        שם = v.SupplierName,
                        טלפון = v.Phone,
                        עיר = v.CityOfSupplier().NameCity 
                    }).OrderBy(v=>v.שם).ToList();
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_supplier.SelectedRows.Count > 0)
            {
                int code = Convert.ToInt32(dgv_supplier.SelectedRows[0].Cells[0].Value.ToString());
                su = tblSuppliers.Find(code);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                FormOneSupplier f = new FormOneSupplier(su);//שולחת את העצם שמצא לטופס 
                f.ReadOnly();
                f.Location = new Point(148, 98);
                Control c = this.Parent;
                this.Parent.Controls.Clear();
                c.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                dgv_supplier.DataSource = tblSuppliers.GetList().Select(s => new
                { 
                    קוד_ספק = s.SupplierCode,
                    הערות = s.Note1,
                    שם = s.SupplierName,
                    טלפון = s.Phone,
                    עיר = s.CityOfSupplier().NameCity,
                    סטטוס = s.Status
                }).ToList();
               
            }
        }

        private void change_sup_Click(object sender, EventArgs e)
        {
            if (dgv_supplier.SelectedRows.Count > 0)
            {
                int code = Convert.ToInt32(dgv_supplier.SelectedRows[0].Cells[0].Value.ToString());
                su = tblSuppliers.Find(code);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                FormOneSupplier f = new FormOneSupplier(su);//שולחת את העצם שמצא לטופס 
                f.Location = new Point(148, 98);
                Control c = this.Parent;
                this.Parent.Controls.Clear();
                c.Controls.Add(f);
                f.Dock = DockStyle.Fill;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_supplier.DataSource = tblSuppliers.GetList().Where(x => x.ToString() == cmb_search.Text).Select(s => new 
            { 
                קוד_ספק = s.SupplierCode,
                הערות = s.Note1,
                שם = s.SupplierName,
                טלפון = s.Phone,
                עיר = s.CityOfSupplier().NameCity,
                סטטוס = s.Status 
            }).ToList();
        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }

}

