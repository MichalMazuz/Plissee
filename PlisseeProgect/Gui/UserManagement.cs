using PlisseeProgect.Bll;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Drawing;



namespace PlisseeProgect.Gui
{
   public partial class UserManagement : UserControl
    {
        ProductTypeDB tblProductType;
        CityDB tblCity;
        LengthDB tblLength;
        CompanyDB tblCompany;
        InstitutionDB tblInstitution;
        SizeDB tblSize;
        SupplierDB tblS;
        Supplier s;
        City c;
        Institution i;
        Bll.Size ss;
        Company cc;
        ProductType p;
        Length l;
        bool flagUpdate = false;
        public UserManagement()
        {
            InitializeComponent();
            tblProductType = new ProductTypeDB();
            tblCity = new CityDB();
            tblLength = new LengthDB();
            tblCompany = new CompanyDB();
            tblInstitution = new InstitutionDB();
            tblSize = new SizeDB();
            tblS = new SupplierDB();
            s = new Supplier();
            c = new City();
            i = new Institution();
            ss = new Bll.Size();
            cc = new Company();
            p = new ProductType();
            l = new Length();
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            cmb_city.DataSource = tblCity.GetList().OrderBy(x=>x.NameCity).ToList();
            cmb_city.SelectedIndex = -1;
            cmb_type_p.DataSource = tblProductType.GetList();
            cmb_type_p.SelectedIndex = -1;
            cmb_length.DataSource = tblLength.GetList().OrderBy(x=>x.LengthNum).ToList();
            cmb_length.SelectedIndex = -1;
            cmb_company.DataSource = tblCompany.GetList();
            cmb_company.SelectedIndex = -1;
            cmb_institution.DataSource = tblInstitution.GetList();
            cmb_institution.SelectedIndex = -1;
            cmb_sizes.DataSource = tblSize.GetList().OrderBy(x=>x.Description).ToList();
            cmb_sizes.SelectedIndex = -1;
            cmb_supplier.DataSource = tblS.GetList().OrderBy(x=>x.SupplierName).ToList();
            cmb_supplier.SelectedIndex = -1;
        }

        private void btn_home7_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_home1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void btn_home2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            flagUpdate = false;
        }

        private void btn_home6_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void btn_home8_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }
        public bool CreateType(ProductType t)
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_new_p.Text == "")
                    throw new Exception("יש להקיש סוג מוצר");
                if (!Validation.IsHebrew(txt_new_p.Text))
                    throw new Exception("יש להקיש אותיות בעברית");
                t.TypeDescription = txt_new_p.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_new_p, ex.Message);
                flag = false;
            }
            if(!flagUpdate)
                t.TypeCode = tblProductType.GetNextKey();
            return flag;
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
            if (flagUpdate&&flag1)
            {
                if (CreateType(p))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן סוג זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        tblProductType.UpDateRow(p);
                        cmb_type_p.DataSource = null;
                        cmb_type_p.DataSource = tblProductType.GetList();
                        cmb_type_p.SelectedIndex = -1;
                        txt_new_p.Text = "";
                        panel1.Visible = false;

                    }
                }
            }
            else
            {
               

                if (flag1)
                {
                    ProductType p = new ProductType();
                    if (CreateType(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף סוג זה  ", "הוספת מוצר", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblProductType.AddNew(p);
                            cmb_type_p.DataSource = null;
                            cmb_type_p.DataSource = tblProductType.GetList();
                            cmb_type_p.Text = p.ToString();
                            cmb_type_p.DataSource = tblProductType.GetList();
                            txt_new_p.Text = "";
                        }
                    }
                }
                else
                {
                    txt_new_p.Text = "";
                    panel1.Visible = false;
                }
            }
        }
         public bool CreateCompany(Company t)
         {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_company.Text == "")
                    throw new Exception("יש להקיש שם חברה");
                if (!Validation.IsHebrew(txt_company.Text))
                    throw new Exception("יש להקיש אותיות בעברית");
                t.CompanyName = txt_company.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_company, ex.Message);
                flag = false;
            }
            try
            {
                if(cmb_supplier.SelectedIndex<0)
                    throw new Exception("הקש שם ספק");
                t.SupplierCode = ((Supplier)cmb_supplier.SelectedItem).SupplierCode; ;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_supplier, ex.Message);
                flag = false;
            }
            if(!flagUpdate)
            t.CompanyCode = tblCompany.GetNextKey();
            return flag;
         }
        private void button2_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            Company c = new Company();
            c = tblCompany.GetList().FirstOrDefault(x => x.CompanyName == cmb_company.Text);
            foreach (Company item in tblCompany.GetList())
            {
                if (item.CompanyName==txt_company.Text&&item.CompanyCode!=c.CompanyCode)
                {
                    MessageBox.Show("חברה זו קיימת במערכת");
                    flag1 = false;
                }
            }
            if (flagUpdate&&flag1)
            {
                if (CreateCompany(cc))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן פרטים אלו", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        tblCompany.UpDateRow(cc);
                        cmb_company.DataSource = null;
                        cmb_company.DataSource = tblCompany.GetList();
                        cmb_company.SelectedIndex = -1;
                        txt_company.Text = "";
                        panel4.Visible = false;
                    }
                }
            }
            else
            {
                if (flag1)
                {
                    Company p = new Company();
                    if (CreateCompany(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף שם זה  ", "הוספת חברה", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblCompany.AddNew(p);
                            cmb_company.DataSource = null;
                            cmb_company.DataSource = tblCompany.GetList();
                            cmb_company.Text = p.ToString();
                            cmb_company.DataSource = tblCompany.GetList();
                            txt_company.Text = "";
                            cmb_supplier.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    txt_company.Text = "";
                    panel4.Visible = false;
                }
            }
        }

        public bool CreateLength(Length l)
        {
            bool flagOk = true;
            errorProvider1.Clear();
            try
            {
                if (txt_length.Text == "")
                    throw new Exception("הקש אורך ");
                if (!Bll.Validation.IsNum(txt_length.Text))
                    throw new Exception("יש להקיש ספרות");
                l.LengthNum =Convert.ToInt32( txt_length.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_length, ex.Message);
                flagOk = false;
            }
            if(!flagUpdate)
            l.LengthCode = tblLength.GetNextKey();
            return flagOk;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            foreach (Length item in tblLength.GetList())
            {
                if (item.ToString().Equals(txt_length.Text))
                {
                    MessageBox.Show("אורך זה קיים במערכת");
                    flag1 = false;
                }
            }
            if (flagUpdate&&flag1)
            {
                if (CreateLength(l))
                {
                    foreach (Length item in tblLength.GetList())
                    {
                        if (item.ToString().Equals(txt_length.Text))
                        {
                            MessageBox.Show("אורך זה קיים במערכת");
                            flag1 = false;
                        }
                    }
                    if (flag1)//אם האורך לא קיים במערכת
                    {
                        DialogResult d = MessageBox.Show("?האם בצונך לעדכן אורך זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (d == DialogResult.Yes)
                        {
                            l.LengthNum =Convert.ToInt32( txt_length.Text);
                            tblLength.UpDateRow(l);
                            cmb_length.DataSource = null;
                            cmb_length.DataSource = tblLength.GetList();
                            cmb_length.SelectedIndex = -1;
                            txt_length.Text = "";
                            panel5.Visible = false;

                        }
                    }
                }
            }
            else
            {
               

                if (flag1)
                {
                    Length p = new Length();
                    if (CreateLength(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף אורך זה  ", "הוספת אורך", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblLength.AddNew(p);
                            cmb_length.DataSource = null;
                            cmb_length.DataSource = tblLength.GetList();
                            cmb_length.Text = p.ToString();
                            cmb_length.DataSource = tblLength.GetList();
                            txt_length.Text = "";
                        }
                    }
                }
                else
                {
                    txt_length.Text = "";
                    panel1.Visible = false;
                }
               
            }
        }
        public bool CreateCity(City t)
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_city.Text == "")
                    throw new Exception("יש להקיש שם עיר");
                if (!Validation.IsHebrew(txt_city.Text))
                    throw new Exception("יש להקיש אותיות בעברית");
                t.NameCity = txt_city.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_city, ex.Message);
                flag = false;
            }
            if(!flagUpdate)
            t.CityCode = tblCity.GetNextKey();
            return flag;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            foreach (City item in tblCity.GetList())
            {
                if (item.ToString().Equals(txt_city.Text))
                {
                    MessageBox.Show("עיר זו קיימת במערכת");
                    flag1 = false;
                }
            }
            //עידכון
            if (flagUpdate)
            {
                if (CreateCity(c)&& flag1)
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן עיר זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        tblCity.UpDateRow(c);
                        cmb_city.DataSource = null;
                        cmb_city.DataSource = tblCity.GetList();
                        cmb_city.SelectedIndex = -1;
                        txt_city.Text = "";
                        panel8.Visible = false;

                    }
                }

            }
            else
            {
               
                //הוספה
                if (flag1)
                {

                    City p = new City();
                    if (CreateCity(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף עיר זאת  ", "הוספת עיר", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblCity.AddNew(p);
                            cmb_city.DataSource = null;
                            cmb_city.DataSource = tblCity.GetList();
                            cmb_city.Text = p.ToString();
                            cmb_city.DataSource = tblCity.GetList();
                            txt_city.Text = "";
                        }
                    }
                }
                else
                {
                    txt_city.Text = "";
                    panel8.Visible = false;
                }
            }
        }
        public bool CreateInstituation(Institution t)
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_instituation.Text == "")
                    throw new Exception("יש להקיש שם עיר");
                if (!Validation.IsHebrew(txt_instituation.Text))
                    throw new Exception("יש להקיש אותיות בעברית");
                t.InstitutionName = txt_instituation.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_instituation, ex.Message);
                flag = false;
            }
            if(!flagUpdate)
            t.InstitutionCode = tblInstitution.GetNextKey();
            return flag;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            foreach (Institution item in tblInstitution.GetList())
            {
                if (item.ToString().Equals(txt_instituation.Text))
                {
                    MessageBox.Show("מוסד זה קיים במערכת");
                    flag1 = false;
                }
            }
            if (flagUpdate&&flag1)
            {
                if (CreateInstituation(i))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן מוסד זה", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        tblInstitution.UpDateRow(i);
                        cmb_institution.DataSource = null;
                        cmb_institution.DataSource = tblInstitution.GetList();
                        cmb_institution.SelectedIndex = -1;
                        txt_instituation.Text = "";
                        panel7.Visible = false;

                    }
                }
            }
            else
            {
                if (flag1)
                {
                    Institution p = new Institution();
                    if (CreateInstituation(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף מוסד זה  ", "הוספת מוסד", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblInstitution.AddNew(p);
                            this.Visible = false;
                            cmb_institution.DataSource = null;
                            cmb_institution.DataSource = tblInstitution.GetList();
                            cmb_institution.Text = p.ToString();
                            cmb_institution.DataSource = tblInstitution.GetList();
                            txt_instituation.Text = "";
                        }
                    }
                }
                else
                {
                    txt_instituation.Text = "";
                    panel7.Visible = false;
                }

            }
        }
        public bool CreateSize(Bll.Size t)
        {
            bool flag = true;
            errorProvider1.Clear();
            try
            {
                if (txt_size.Text == "")
                    throw new Exception("שדה חובה");
                if (!Validation.IsNum(txt_size.Text))
                    throw new Exception("הקש מספרים");
                t.Description = txt_size.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_size, ex.Message);
                flag = false;
            }
            if(!flagUpdate)
            t.SizeCode = tblSize.GetNextKey();
            return flag;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            foreach (Bll.Size item in tblSize.GetList())
            {
                if (item.ToString().Equals(txt_size.Text))
                {
                    MessageBox.Show("מידה זו קיימת במערכת");
                    flag1 = false;
                }
            }
            if (flagUpdate&&flag1)
            {
                if (CreateSize(ss))
                {
                    DialogResult d = MessageBox.Show("?האם בצונך לעדכן מידה זו", "אישור עריכה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        tblSize.UpDateRow(ss);
                        cmb_sizes.DataSource = null;
                        cmb_sizes.DataSource = tblSize.GetList();
                        cmb_sizes.SelectedIndex = -1;
                        txt_size.Text = "";
                        panel6.Visible = false;

                    }
                }
            }
            else
            {
               

                if (flag1)
                {
                    Bll.Size p = new Bll.Size();
                    if (CreateSize(p))
                    {
                        DialogResult d = MessageBox.Show("? האם ברצונך להוסיף מידה זו  ", "הוספת מידה", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            tblSize.AddNew(p);
                          
                            cmb_sizes.DataSource = null;
                            cmb_sizes.DataSource = tblSize.GetList();
                            cmb_sizes.Text = p.ToString();
                            cmb_sizes.DataSource = tblSize.GetList();
                            txt_size.Text = "";
                        }
                    }
                }
                else
                {
                    txt_size.Text = "";
                    panel6.Visible = false;
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_company.Text = "";
            cmb_supplier.SelectedIndex = -1;
            panel4.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_new_p.Text = "";
            cmb_type_p.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_length.Text = "";
            cmb_length.SelectedIndex = -1;
            panel5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_size.Text = "";
            cmb_sizes.SelectedIndex = -1;
            panel6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_instituation.Text = "";
            cmb_institution.SelectedIndex = -1;
            panel7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_city.Text = "";
            cmb_city.SelectedIndex = -1;
            panel8.Visible = false;
        }
        private void btn_home11_Click(object sender, EventArgs e)
        {
            if (cmb_city.SelectedIndex>-1)
            {
                int code = ((City)cmb_city.SelectedItem).CityCode;
                c = tblCity.Find(code);
                panel8.Visible = true;
                txt_city.Text = c.NameCity;
                flagUpdate = true;
            }
            else
                MessageBox.Show("בחר עיר שברצונך לעדכן");
        }

        private void btn_home12_Click(object sender, EventArgs e)
        {
            if (cmb_institution.SelectedIndex > -1)
            {
                int code = ((Institution)cmb_institution.SelectedItem).InstitutionCode;
                i = tblInstitution.Find(code);
                panel7.Visible = true;
                txt_instituation.Text = i.InstitutionName;
                flagUpdate = true;
            }
            else
                MessageBox.Show("בחר מוסד שברצונך לעדכן");
        }

        private void btn_home14_Click(object sender, EventArgs e)
        {
            if (cmb_sizes.SelectedIndex > -1)
            {
                int code = ((Bll.Size)cmb_sizes.SelectedItem).SizeCode;
                ss = tblSize.Find(code);
                panel6.Visible = true;
                txt_size.Text = ss.Description;
                flagUpdate = true;
            }
            else 
                MessageBox.Show("בחר מידה שברצונך לעדכן");
        }

        private void btn_home10_Click(object sender, EventArgs e)
        {
            if (cmb_company.SelectedIndex > -1)
            {
                cc = ((Company)cmb_company.SelectedItem);
                panel4.Visible = true;
                txt_company.Text = cc.CompanyName;
                cmb_supplier.SelectedItem = cc.SupplierOfCompany();
                cmb_supplier.Text = cc.SupplierOfCompany().SupplierName;
                flagUpdate = true;
            }
            else
                MessageBox.Show("בחר חברה שברצונך לעדכן");
        }

        private void btn_home9_Click(object sender, EventArgs e)
        {
            if (cmb_type_p.SelectedIndex > -1)
            {
                int code = ((ProductType)cmb_type_p.SelectedItem).TypeCode;
                p = tblProductType.Find(code);
                panel1.Visible = true;
                txt_new_p.Text = p.TypeDescription;
                flagUpdate = true;
            }
            else
                MessageBox.Show("בחר סוג שברצונך לעדכן");
        }

        private void btn_home13_Click(object sender, EventArgs e)
        {
            if (cmb_length.SelectedIndex > -1)
            {
                int code = ((Length)cmb_length.SelectedItem).LengthCode;
                l = tblLength.Find(code);
                panel5.Visible = true;
                txt_length.Text =l.LengthNum.ToString();
                flagUpdate = true;
            }
            else
                MessageBox.Show("בחר אורך שברצונך לעדכן");
        }

        private void txt_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_new_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txt_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txt_instituation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_institution_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_sizes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_type_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void cmb_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void cmb_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }

        private void txt_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }

        private void cmb_supplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}

