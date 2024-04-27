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
    public partial class UserProduct_s_l : UserControl
    {
        SizeDB tblsize;
        LengthDB tblLength;
        ProductModels p;
        ProductModelsDB tblPm;
        ProductSizeDB tblPro_Size;
        ProductSize ps;
        bool flagUpdate = false;
        public UserProduct_s_l(ProductModels pm)
        {
            InitializeComponent();
            btn_return.Visible = false;
            tblLength = new LengthDB();
            tblsize = new SizeDB();
            tblPro_Size = new ProductSizeDB();
            ps = new ProductSize();
            tblPm = new ProductModelsDB();
            this.p = pm;
            FillSizeLength();
            flagUpdate = true;
        }

        private void FillSizeLength()
        {
            int m = 0;
            int l = 0;
            foreach (Bll.Size item in tblsize.GetList())
            {
                //בנית צק בוקס מידות ןאורכים
                checkedListBox_size.Items.Add(item);
                if (tblPro_Size.GetList().Count(x => (x.SizeCode == item.SizeCode)  && (p.ProductCode == x.ProductCode) && x.Status==0)!=0 )
                    checkedListBox_size.SetItemChecked(m,true);
                m++;
            }
            
            foreach (Length item in tblLength.GetList().Where(x=>x.LengthNum!=0))
            {
                checkedListBox_length.Items.Add(item);
                if (tblPro_Size.GetList().Count(x => (x.LengthCode == item.LengthCode) && (p.ProductCode == x.ProductCode && x.Status == 0)) != 0)
                    checkedListBox_length.SetItemChecked(l, true);
                l++;
            }
        }
        public bool CreateField(ProductSize ps,Length l,Bll.Size s)
        {
            bool flagOk = true;
            ps.ProductCode = p.ProductCode;
            ps.LengthCode =l.LengthCode;
            ps.SizeCode =s.SizeCode;
            return flagOk;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("?האם בצונך להוסיף מידות ואורכים אלו", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                btn_return.Visible = true;
                foreach (Bll.Size itemSize in checkedListBox_size.CheckedItems)
                {
                    if (checkBox1.Checked)
                    {
                        OpenUc();
                    }
                    else//הוספת מידות למוצרים ללא אורך
                    { 
                        ps = new ProductSize();
                        ps.ProductCode = p.ProductCode;
                        ps.LengthCode =1;
                        ps.SizeCode = itemSize.SizeCode;
                        
                        if (tblPro_Size.Find(ps.ProductCode, ps.SizeOfProductSize().SizeCode, ps.LengthCode) == null)
                        {
                            tblPro_Size.AddNew(ps);
                        }
                        else
                        {
                            ps = tblPro_Size.Find(ps.ProductCode, ps.SizeOfProductSize().SizeCode, ps.LengthCode);
                            ps.Status = 0;
                            tblPro_Size.UpDateRow(ps);
                        }
                        OpenUc();
                    }
                }
            }
           
        }
        private void OpenUc()
        {
            UserProducts f1 = new UserProducts();
            f1.Location = new Point(148, 98);
            this.Controls.Clear();
            Controls.Add(f1);
            f1.Dock = DockStyle.Fill;
            f1.dgv_products.DataSource = tblPm.GetList().
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

        private void lab__Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkedListBox_length.Visible = true;
            else
                checkedListBox_length.Visible = false;
        }

        private void checkedListBox_length_ItemCheck(object sender, ItemCheckEventArgs e)
        {//בודק אם הוסיף וי או הוריד
            int status = 0;
            if (flagUpdate)
            {
                if (checkedListBox_length.GetItemChecked(checkedListBox_length.SelectedIndex))
                {
                    status = 1;
                }
                int countL = tblPro_Size.GetList().Count(x => x.ProductCode == p.ProductCode && ((Length)(checkedListBox_length.SelectedItem)).LengthCode == x.LengthCode);
                if (countL > 0)
                {
                    foreach (ProductSize item in tblPro_Size.GetList().Where(x => x.ProductCode == p.ProductCode && ((Length)(checkedListBox_length.SelectedItem)).LengthCode == x.LengthCode))
                    {
                        item.Status = status;
                        tblPro_Size.UpDateRow(item);
                    }
                }
                //אם לא קקים עדיין בודק האם להוסיף
                else if ((checkedListBox_length.GetItemChecked(checkedListBox_length.SelectedIndex)) == false)
                {
                    //עובר על כל המידות ומוסיף אורך לכל מידה
                    foreach (Bll.Size itemSize in checkedListBox_size.CheckedItems)
                    {
                       
                        {
                            ps = new ProductSize();
                            if (CreateField(ps, ((Length)(checkedListBox_length.SelectedItem)), itemSize))
                            {
                                tblPro_Size.AddNew(ps);
                            }
                        }
                        //בדיקה שלא קיים בטבלה מוצר במידה ובאורך הנוכחי

                        //הוספת לטבלת productSize
                    }
                }
            }
            //אם לא קיים בכלל צריך לעשות הוספה

           


        }


        private void checkedListBox_size_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int status = 0;
            if (flagUpdate)
            {
                if (checkedListBox_size.GetItemChecked(checkedListBox_size.SelectedIndex))
                {
                    status = 1;
                }
                //בודק אם המידה כבר קיימת במוצר אם לא מבצע הוספה אם קיים מבצע רק עדכון
                int countL = tblPro_Size.GetList().Count(x => x.ProductCode == p.ProductCode && ((Bll.Size)(checkedListBox_size.SelectedItem)).SizeCode == x.SizeCode);
                if (countL > 0)
                {
                    foreach (ProductSize item in tblPro_Size.GetList().Where(x => x.ProductCode == p.ProductCode && ((Bll.Size)(checkedListBox_size.SelectedItem)).SizeCode == x.SizeCode))
                    {
                        item.Status = status;
                        tblPro_Size.UpDateRow(item);
                    }
                }
                //אם לא קיים מבצע הוספה
                else if ((checkedListBox_size.GetItemChecked(checkedListBox_size.SelectedIndex)) == false)
                {
                    foreach (Bll.Length itemLength in checkedListBox_length.CheckedItems)
                    {
                       
                        {//מוסיף חדש 
                            ps = new ProductSize();
                            if (CreateField(ps, itemLength, ((Bll.Size)(checkedListBox_size.SelectedItem))))
                            {
                                tblPro_Size.AddNew(ps);
                            }
                        }
                        //בדיקה שלא קיים בטבלה מוצר במידה ובאורך הנוכחי

                        //הוספת לטבלת productSize
                    }
                }
                //אם לא קיים בכלל צריך לעשות הוספה

              


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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(checkedListBox_size.CheckedItems.Count==0)
            {
                DialogResult dia = MessageBox.Show("אין מידות קיימות למוצר, המוצר יהפוך ללא פעיל, האם ברצונך להמשיך?", "", MessageBoxButtons.YesNo);
                if(dia==DialogResult.Yes)
                {
                    p.Status = "לא פעיל";
                    tblPm.UpDateRow(p);
                    this.Parent.Controls.Remove(this);
                }
            } 
            else
                this.Parent.Controls.Remove(this);
        }

        private void UserProduct_s_l_Load(object sender, EventArgs e)
        {

        }
    }
    }

