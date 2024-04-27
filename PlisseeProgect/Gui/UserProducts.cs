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
   public partial class UserProducts : UserControl
    {
        bool flagUpdate = false;
        ProductModelsDB tblProductModels;
        ProductModels product;
        ProductTypeDB tblProductType;
        InstitutionDB tblInstitution;
        InstitutionProduct ip;
        Institution ins;
        Company c;
        CompanyDB tblc;
        Supplier s;
        SupplierDB tbls;
        InstitutionProductDB tblInstitutionProduct = new InstitutionProductDB();
        List<Institution> lstInstitutions = new List<Institution>();
        List<Institution> lstIns = new List<Institution>();
        public UserProducts()
        {
            InitializeComponent();
            panel1.Visible = false;
            tblProductModels = new ProductModelsDB();
            product = new ProductModels();
            tblProductType = new ProductTypeDB();
            tblInstitution = new InstitutionDB();
            ip = new InstitutionProduct();
            c = new Company();
            tblc = new CompanyDB();
            s = new Supplier();
            tbls = new SupplierDB();
            ins = new Institution();
            cmb_type_p.DataSource = tblProductType.GetList();
            cmb_type_p.SelectedIndex = -1;
            cmb_company.DataSource = tblc.GetList();
            cmb_company.SelectedIndex = -1;
            cmb_instituation.DataSource = tblInstitution.GetList();
            cmb_instituation.SelectedIndex = -1;
            panel4.Visible = false;
            btn_add2.Visible = false;
            btn_erase1.Visible = false;
            notPossible();
        }
        
        public UserProducts(ProductModels pro) : this()
        {
            this.product = pro;
            Fill(pro);
            flagUpdate = true;
        }
        public void Fill(ProductModels p)
        {
            ProductModels pro = p;
            InstitutionProduct ip = tblInstitutionProduct.GetList().FirstOrDefault(x => x.ProductCode == pro.ProductCode);
            txt_descr_p.Text = p.ProductDescription;
            txt_descr_p.Text = p.ProductOfModels().TypeDescription.ToString();
            txt_pur_p.Text = p.PurchasePrice.ToString();
            txt_salling_p.Text = p.SallingPrice.ToString();
            cmb_type_p.SelectedItem = p.ProductOfModels().ToString();
            cmb_type_p.Text = p.ProductOfModels().ToString();
            cmb_company.SelectedItem = p.CompanyOfP().ToString();
            cmb_company.Text = p.CompanyOfP().ToString();
            cmb_instituation.SelectedItem = p.Status.ToString();
            txt_code_p.Text = p.ProductCode.ToString();
        }
        public void ReadOnly()
        {
            btn_continue_p.Visible = false;
            txt_descr_p.ReadOnly = true;
            txt_pur_p.ReadOnly = true;
            txt_salling_p.ReadOnly = true;
            cmb_company.Enabled = false;
            btn_add.Visible = false;
            btn_add2.Visible = false;
            btn_erase1.Visible = false;
            cmb_type_p.Enabled = false;
            txt_code_p.ReadOnly = true;
        }
        public bool CreateField(ProductModels p)
        {

            bool flagOk = true;
            errorProvider1.Clear();

            try
            {
                if (Convert.ToInt32( txt_pur_p.Text)>Convert.ToInt32(txt_salling_p.Text))
                    throw new Exception("ערך לא חוקי\nמחיר הזמנה גדול ממחיר המכירה");
               
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_salling_p, ex.Message);
                errorProvider1.SetError(txt_pur_p, ex.Message);

                flagOk = false;
            }
            try
            {
                if (cmb_company.SelectedIndex < 0)
                    throw new Exception("הקש שם חברה");
                p.CompanyCode = ((Company)cmb_company.SelectedItem).CompanyCode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_company, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_descr_p.Text == "")
                    throw new Exception("הקש תאור מוצר");
                p.ProductDescription = txt_descr_p.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_descr_p, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_salling_p.Text == "")
                    throw new Exception("הקש מחיר מכירה");
                if (!Validation.IsNum(txt_salling_p.Text))
                    throw new Exception("יש להקיש ספרות");
                p.SallingPrice = Convert.ToInt32(txt_salling_p.Text); ;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_salling_p, ex.Message);
                flagOk = false;
            }
            try
            {
                if (txt_pur_p.Text == "")
                    throw new Exception("הקש מחיר רכישה");
                if (!Validation.IsNum(txt_pur_p.Text))
                    throw new Exception("יש להקיש ספרות");
                p.PurchasePrice = Convert.ToInt32(txt_pur_p.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_pur_p, ex.Message);
                flagOk = false;
            }
            try
            {
                if (cmb_type_p.SelectedIndex < 0)
                    throw new Exception("בחר סוג");
                p.TypeCode = ((ProductType)cmb_type_p.SelectedItem).TypeCode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_type_p, ex.Message);
                flagOk = false;
            }
            if (!flagUpdate)//אם אתה במצב הוספה צור קוד חדש
                p.ProductCode = tblProductModels.GetNextKey();
            p.Status = "פעיל";
            return flagOk;
        }
        public void Possible()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            txt_code_p.ReadOnly = true;
        }
        public void notPossible()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            flagUpdate = false;
            txt_code_p.ReadOnly = false;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
             Possible();
            btn_add2.Visible = true;
            btn_erase1.Visible = true;
            cmb_instituation.DataSource = tblInstitutionProduct.GetList().Where(x => x.ProductCode == product.ProductCode).Select(x => x.InstituationOfInstProduct().InstitutionName).ToList();
            txt_code_p.Text = tblProductModels.GetNextKey().ToString();
            txt_descr_p.Text = "";
            txt_pur_p.Text = "";
            txt_salling_p.Text = "";
            cmb_instituation.Text = "";
            cmb_type_p.Text = "";
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void txt_code_p_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
                Where(x => x.ProductCode.ToString().
                StartsWith(txt_code_p.Text)).Select(x => new
                {
                    קוד_מוצר = x.ProductCode,
                    מחיר_קניה = x.PurchasePrice,
                    מחיר_מכירה = x.SallingPrice,
                    שם_החברה = x.CompanyOfP().CompanyName,
                    סוג_מוצר = x.ProductOfModels().TypeDescription,
                    תאור_מוצר = x.ProductDescription,
                    שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
                }
            ).ToList();
        }

        private void txt_descr_p_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
                Where(x => x.ProductDescription.ToString().
                StartsWith(txt_descr_p.Text)).Select(x => new
                {
                    קוד_מוצר = x.ProductCode,
                    מחיר_קניה = x.PurchasePrice,
                    מחיר_מכירה = x.SallingPrice,
                    שם_החברה = x.CompanyOfP().CompanyName,
                    סוג_מוצר = x.ProductOfModels().TypeDescription,
                    תאור_מוצר = x.ProductDescription,
                    שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
                }
           ).ToList();
        }

        private void txt_pur_p_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
                Where(x => x.PurchasePrice.ToString().
                StartsWith(txt_pur_p.Text)).Select(x => new
                {
                    קוד_מוצר = x.ProductCode,
                    מחיר_הזמנה = x.PurchasePrice,
                    מחיר_מכירה = x.SallingPrice,
                    שם_החברה = x.CompanyOfP().CompanyName,
                    סוג_מוצר = x.ProductOfModels().TypeDescription,
                    תאור_מוצר = x.ProductDescription,
                    שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
                }
          ).ToList();
          
        }

        private void txt_salling_p_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
                Where(x => x.SallingPrice.ToString().
                StartsWith(txt_salling_p.Text)).Select(x => new
                {
                    קוד_מוצר = x.ProductCode,
                   מחיר_הזמנה= x.PurchasePrice,
                    מחיר_מכירה = x.SallingPrice,
                    שם_החברה = x.CompanyOfP().CompanyName,
                    סוג_מוצר = x.ProductOfModels().TypeDescription,
                    תאור_מוצר = x.ProductDescription,
                    שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
                }
          ).ToList();
        }

        private void cmb_type_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_type_p.SelectedIndex > -1)
            {
                dgv_products.DataSource = tblProductModels.GetList().
                    Where(x => x.ProductOfModels().TypeDescription.ToString().
                    StartsWith(cmb_type_p.SelectedItem.ToString())).Select(x => new
                    {
                        קוד_מוצר = x.ProductCode,
                       מחיר_הזמנה = x.PurchasePrice,
                        מחיר_מכירה = x.SallingPrice,
                        שם_החברה = x.CompanyOfP().CompanyName,
                        סוג_מוצר = x.ProductOfModels().TypeDescription,
                        תאור_מוצר = x.ProductDescription,

                    }
               ).ToList();
            }
        }

        private void txt_company_TextChanged(object sender, EventArgs e)
        {
            if (cmb_company.SelectedIndex > -1)
            {
                dgv_products.DataSource = tblProductModels.GetList().
                    Where(x => x.CompanyOfP().CompanyName.ToString().
                    StartsWith(cmb_company.SelectedItem.ToString())).Select(x => new
                    {
                        קוד_מוצר = x.ProductCode,
                        מחיר_הזמנה = x.PurchasePrice,
                        מחיר_מכירה = x.SallingPrice,
                        שם_החברה = x.CompanyOfP().CompanyName,
                        סוג_מוצר = x.ProductOfModels().TypeDescription,
                        תאור_מוצר = x.ProductDescription,
                        שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
                    }
              ).ToList();
            }
        }

       
        public bool CreateType(ProductType t)
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_new_p.Text == "")
                    throw new Exception("יש להקיש סוג מוצר");
                t.TypeDescription = txt_new_p.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_new_p, ex.Message);
                flag = false;
            }
            t.TypeCode = tblProductType.GetNextKey();
            return flag;
        }
        private void btn_save_p_Click(object sender, EventArgs e)
        {

            if (flagUpdate)
            {
                if (CreateField(product))
                {
                    DialogResult d = MessageBox.Show("?האם ברצונך לערוך מוצר זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                       
                        tblProductModels.UpDateRow(product);
                        OpenU(2);
                        
                    }
                }
            }
            else
            {
                product = new ProductModels();
                
                if (CreateField(product))
                {

                    DialogResult d = MessageBox.Show("?האם ברצונך להוסיף מוצר זה", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        btn_save.Enabled = false;
                        tblProductModels.AddNew(product);
                        foreach (Institution i in lstInstitutions)
                        {
                            ip = new InstitutionProduct();
                            ip.InstitutionCode = i.InstitutionCode;
                            ip.ProductCode = product.ProductCode;
                            tblInstitutionProduct.AddNew(ip);
                        }
                        OpenU(1);
                    }
                }
            }
           
        }

        private void OpenU(int num)
        {
          
            UserProduct_s_l f1 = new UserProduct_s_l(product);
            if (num == 2)
            {
                f1.btn_save.Visible = false;
                f1.btn_return.Visible = true;
            }
            else
            {
                f1.btn_return.Visible = false;
            }
            f1.Location = new Point(148, 98);
            Controls.Add(f1);
            f1.BringToFront();
            f1.Dock = DockStyle.Fill;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            foreach (ProductType item in tblProductType.GetList())
            {
                if (item.ToString().Equals(txt_new_p.Text))
                {
                    MessageBox.Show("סוג זה קיים במערכת");
                    flag1 = false;
                }
            }

            if (flag1)
            {
                ProductType p = new ProductType();
                if (CreateType(p))
                {
                    DialogResult d = MessageBox.Show("? האם ברצונך להוסיף סוג זה  ", "הוספת מוצר", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        tblProductType.AddNew(p);
                        this.Visible = false;
                        cmb_type_p.DataSource = null;
                        cmb_type_p.DataSource = tblProductType.GetList();
                        cmb_type_p.Text = p.ToString();
                        cmb_type_p.DataSource = tblProductType.GetList();
                        this.Visible = true;
                        this.Controls.Clear();
                        UserProducts s = new UserProducts();
                        s.Location = new Point(148, 98);
                        this.Controls.Add(s);
                        s.Dock = DockStyle.Fill;
                    }
                }
            }
            else
            {
                txt_new_p.Text = "";
                panel1.Visible = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_new_p.Text = "";
            panel1.Visible = false;
        }
        private void btn_home5_Click(object sender, EventArgs e)
        {
            if (dgv_products.SelectedRows.Count > 0)
            {
                btn_add2.Visible = true;
                btn_erase1.Visible = true;
                flagUpdate = true;
                int code = Convert.ToInt32(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
                product = tblProductModels.Find(code);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                Possible();
                cmb_instituation.DataSource = tblInstitutionProduct.GetList().Where(x => x.ProductCode == product.ProductCode).Select(x => x.InstituationOfInstProduct().InstitutionName).ToList();
                cmb_instituation.SelectedIndex = -1;
                Fill(product);

            }
        }

        private void cmb_status_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_instituation.SelectedIndex > -1)
            {
                dgv_products.DataSource = tblInstitutionProduct.GetList().Where(x=> x.InstituationOfInstProduct().InstitutionName.StartsWith(cmb_instituation.Text)).Select(x => new { קוד_מוצר = x.ProductModelsOfInstituation().ProductCode,
                    מחיר_הזמנה = x.ProductModelsOfInstituation().PurchasePrice,
                    מחיר_מכירה = x.ProductModelsOfInstituation().SallingPrice,
                    שם_החברה = x.ProductModelsOfInstituation().CompanyOfP().CompanyName,
                    סוג_מוצר = x.ProductModelsOfInstituation().ProductOfModels().TypeDescription,
                    תאור_מוצר = x.ProductModelsOfInstituation().ProductDescription,
                    שם_ספק = x.ProductModelsOfInstituation().CompanyOfP().SupplierOfCompany().SupplierName
                }).ToList();
            }
        }

        private void btn_cancel_p_Click(object sender, EventArgs e)
        {
            notPossible();
            errorProvider1.Clear();
            txt_descr_p.Text = "";
            txt_new_p.Text = "";
            txt_pur_p.Text = "";
            txt_salling_p.Text ="";
            txt_code_p.Text = "";
            cmb_company.SelectedIndex = -1;
            cmb_instituation.SelectedIndex = -1;
            cmb_type_p.SelectedIndex = -1;
            cmb_company.Enabled = true;
            cmb_instituation.Enabled = true;
            cmb_type_p.Enabled = true;
            txt_descr_p.ReadOnly = false;
            txt_pur_p.ReadOnly = false;
            txt_salling_p.ReadOnly = false;
            txt_code_p.ReadOnly = false;
        }

        private void btn_home4_Click(object sender, EventArgs e)
        {
            if (dgv_products.SelectedRows.Count > 0)
            {
                int code = Convert.ToInt32(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
                product = tblProductModels.Find(code);//חיפוש עצם הלקוח עפ תז שנבחרה בגריד
                Possible();                                
                Fill(product);
                cmb_instituation.DataSource = tblInstitutionProduct.GetList().Where(x => x.ProductCode == product.ProductCode).Select(x => x.InstituationOfInstProduct().InstitutionName).ToList();
                ReadOnly();
            }
        }
        private void txt_instituation_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
             Select(x => new
             {
                 קוד_מוצר = x.ProductCode,
                 מחיר_קניה = x.PurchasePrice,
                 מחיר_מכירה = x.SallingPrice,
                 שם_החברה = x.CompanyOfP().CompanyName,
                 סוג_מוצר = x.ProductOfModels().TypeDescription,
                 תאור_מוצר = x.ProductDescription,
                 שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
             });
        }
        private void btn_home3_Click(object sender, EventArgs e)
        {
            dgv_products.DataSource = tblProductModels.GetList().
             Select(x => new
             {
                 קוד_מוצר = x.ProductCode,
                 מחיר_קניה = x.PurchasePrice,
                 מחיר_מכירה = x.SallingPrice,
                 שם_החברה = x.CompanyOfP().CompanyName,
                 סוג_מוצר = x.ProductOfModels().TypeDescription,
                 תאור_מוצר = x.ProductDescription,
                 שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
             }
           ).ToList();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            if (dgv_products.SelectedRows.Count > 0)
            {
                DialogResult s = MessageBox.Show("?האם ברצונך למחוק מוצר זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (s == DialogResult.Yes)
                {
                    int code = Convert.ToInt32(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
                    product = tblProductModels.Find(code);
                    product.Status = "לא פעיל";
                    tblProductModels.UpDateRow(product);
                    dgv_products.DataSource = tblProductModels.GetList().Where(x=>x.Status=="פעיל").
             Select(x => new
             {
                 קוד_מוצר = x.ProductCode,
                 מחיר_קניה = x.PurchasePrice,
                 מחיר_מכירה = x.SallingPrice,
                 שם_החברה = x.CompanyOfP().CompanyName,
                 סוג_מוצר = x.ProductOfModels().TypeDescription,
                 תאור_מוצר = x.ProductDescription,
                 שם_ספק = x.CompanyOfP().SupplierOfCompany().SupplierName
             }
           ).OrderBy(v => v.קוד_מוצר).ToList();
               
                }
            }
        }

        private void txt_pur_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_code_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_salling_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_new_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txt_descr_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_company_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btn_home1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            if (flagUpdate)
            {
            
                cmb_instituation.DataSource = tblInstitution.GetList().Where
                    (x => !tblInstitutionProduct.GetList().Where(z => z.ProductCode == Convert.ToInt32(txt_code_p.Text)).ToList().Exists
                    (y => y.InstitutionCode == x.InstitutionCode)).
                    Select(r => r.InstitutionName).ToList();
                cmb_instituation.SelectedIndex = -1;
            }
            else
            {
                cmb_instituation.DataSource = tblInstitution.GetList().Where
                    (x => !lstInstitutions.Exists
                    (y => y.InstitutionCode == x.InstitutionCode)).
                    Select(r => r.InstitutionName).ToList();
                cmb_instituation.SelectedIndex = -1;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel4.Visible = false;
            if (flagUpdate)
            {
                cmb_instituation.DataSource = tblInstitution.GetList().
                                Where(x => lstInstitutions.Exists(y => y.InstitutionCode == x.InstitutionCode))
                                .Select(y => y.InstitutionName).ToList();
                cmb_instituation.SelectedIndex = -1;
            }
            else
            {
                cmb_instituation.DataSource = lstInstitutions.Select(x => x.InstitutionName).ToList();
                cmb_instituation.SelectedIndex = -1;
            }
            
        }
        InstitutionProduct institutionProduct;
        Institution institution; 

        private void btn_home2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            if (flagUpdate)
            {
                if(tblInstitutionProduct.GetList().FirstOrDefault(x=> x.ProductCode==Convert.ToInt32(txt_code_p.Text) && x.InstituationOfInstProduct().InstitutionName == cmb_instituation.Text) == null)
                {
                    MessageBox.Show("מוסד זה אינו קיים למוצר זה ");
                }
                else
                {
                    institutionProduct = new InstitutionProduct();
                    institutionProduct = tblInstitutionProduct.Find(Convert.ToInt32(txt_code_p.Text), tblInstitution.GetList().FirstOrDefault(x => x.InstitutionName == cmb_instituation.Text).InstitutionCode);
                    tblInstitutionProduct.DeleteRow(institutionProduct.ProductCode, institutionProduct.InstitutionCode);
                    cmb_instituation.DataSource = tblInstitutionProduct.GetList().
    Where(x => x.ProductCode == Convert.ToInt32(txt_code_p.Text)).
    Select(y => y.InstituationOfInstProduct().InstitutionName).ToList();
                    cmb_instituation.SelectedIndex = -1;
                    cmb_instituation.Text = "";
                }
               
            }
            else
            {
                if (lstInstitutions.FirstOrDefault(x => x.InstitutionName == cmb_instituation.Text) == null)
                {
                    MessageBox.Show("מוסד זה אינו קיים למוצר זה ");
                }
                else
                {
                    institution = new Institution();
                    institution = lstInstitutions.FirstOrDefault(x => x.InstitutionName == cmb_instituation.Text);
                    lstInstitutions.Remove(institution);
                    cmb_instituation.DataSource = lstInstitutions.Select(x => x.InstitutionName).ToList();
                    cmb_instituation.SelectedIndex = -1;
                    cmb_instituation.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (cmb_instituation.SelectedIndex>-1)
            {
                if(flagUpdate)
                {
                    if (tblInstitutionProduct.GetList().
                        Where(x => x.ProductCode == Convert.ToInt32(txt_code_p.Text)).FirstOrDefault(y=> y.InstituationOfInstProduct().InstitutionName==cmb_instituation.Text)!=null)
                        MessageBox.Show(" מוסד זה קיים למוצר זה", "הופס");
                    else
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף מוסד זה  ", "הוספת מוסד", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                                ip = new InstitutionProduct();
                                ip.ProductCode = Convert.ToInt32(txt_code_p.Text);
                                ip.InstitutionCode = tblInstitution.GetList().FirstOrDefault(x => x.InstitutionName == cmb_instituation.Text).InstitutionCode;
                                tblInstitutionProduct.AddNew(ip);
                                cmb_instituation.DataSource = tblInstitutionProduct.GetList().
                                    Where(x => x.ProductCode == Convert.ToInt32(txt_code_p.Text)).
                                    Select(y => y.InstituationOfInstProduct().InstitutionName).ToList();
                                cmb_instituation.SelectedIndex = -1;
                            
                        }
                    }

                }
                else
                {
                    if (lstInstitutions.FirstOrDefault(y => y.InstitutionName == cmb_instituation.Text) != null)
                        MessageBox.Show(" מוסד זה קיים למוצר זה", "הופס");
                    else
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף מוסד זה  ", "הוספת מוסד", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {                            
                                lstInstitutions.Add(tblInstitution.GetList().FirstOrDefault(x => x.InstitutionName == cmb_instituation.Text));
                                cmb_instituation.DataSource = lstInstitutions.Select(x => x.InstitutionName).ToList();
                            cmb_instituation.SelectedIndex = -1;
                        }

                }
               
                }
                
            }
            else
            {
                MessageBox.Show("בחר שם מוסד");
            }

        }
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_instituation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }

        private void cmb_type_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}
