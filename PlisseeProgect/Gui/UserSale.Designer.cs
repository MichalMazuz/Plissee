namespace PlisseeProgect.Gui
{
    partial class UserSale
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
            this.components = new System.ComponentModel.Container();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.cmb_length = new System.Windows.Forms.ComboBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listview_salling = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_payment = new System.Windows.Forms.Panel();
            this.radioB_cheq = new System.Windows.Forms.RadioButton();
            this.radiob_cash = new System.Windows.Forms.RadioButton();
            this.radioB_creditcard = new System.Windows.Forms.RadioButton();
            this.panel_visa = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.nupdown_paymentNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTxtb_creditcard = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cw = new System.Windows.Forms.TextBox();
            this.panel_check = new System.Windows.Forms.Panel();
            this.txt_bank_number = new System.Windows.Forms.TextBox();
            this.txt_branch_number = new System.Windows.Forms.TextBox();
            this.txt_user_account = new System.Windows.Forms.TextBox();
            this.txt_cheque_number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rb_general = new System.Windows.Forms.RadioButton();
            this.rb_members = new System.Windows.Forms.RadioButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_finalPrice = new System.Windows.Forms.TextBox();
            this.label_f_price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remove = new PlisseeProgect.btn_home();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_return = new PlisseeProgect.btn_home();
            this.btn_payments = new PlisseeProgect.btn_home();
            this.lab_home4 = new PlisseeProgect.lab_home();
            this.lab_home3 = new PlisseeProgect.lab_home();
            this.lab_home2 = new PlisseeProgect.lab_home();
            this.btn_sale = new PlisseeProgect.btn_home();
            this.lab_home1 = new PlisseeProgect.lab_home();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_payment.SuspendLayout();
            this.panel_visa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_paymentNumber)).BeginInit();
            this.panel_check.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_search
            // 
            this.cmb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(6, 32);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(110, 21);
            this.cmb_search.TabIndex = 10;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // cmb_length
            // 
            this.cmb_length.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_length.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_length.FormattingEnabled = true;
            this.cmb_length.Location = new System.Drawing.Point(531, 145);
            this.cmb_length.Name = "cmb_length";
            this.cmb_length.Size = new System.Drawing.Size(110, 21);
            this.cmb_length.TabIndex = 11;
            this.cmb_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_length_KeyPress);
            // 
            // cmb_size
            // 
            this.cmb_size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(531, 89);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(110, 21);
            this.cmb_size.TabIndex = 17;
            this.cmb_size.SelectedIndexChanged += new System.EventHandler(this.cmb_size_SelectedIndexChanged);
            this.cmb_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_size_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 197);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // listview_salling
            // 
            this.listview_salling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.listview_salling.FullRowSelect = true;
            this.listview_salling.GridLines = true;
            this.listview_salling.HideSelection = false;
            this.listview_salling.Location = new System.Drawing.Point(3, 3);
            this.listview_salling.Name = "listview_salling";
            this.listview_salling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listview_salling.RightToLeftLayout = true;
            this.listview_salling.Size = new System.Drawing.Size(516, 214);
            this.listview_salling.TabIndex = 20;
            this.listview_salling.UseCompatibleStateImageBehavior = false;
            this.listview_salling.View = System.Windows.Forms.View.Details;
            // 
            // code
            // 
            this.code.Text = "קוד מוצר";
            this.code.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "שם מוצר";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מידה";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "אורך";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "כמות";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 72;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מחיר ליחידה";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "מחיר סופי";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // panel_payment
            // 
            this.panel_payment.Controls.Add(this.radioB_cheq);
            this.panel_payment.Controls.Add(this.radiob_cash);
            this.panel_payment.Controls.Add(this.radioB_creditcard);
            this.panel_payment.Location = new System.Drawing.Point(418, 224);
            this.panel_payment.Name = "panel_payment";
            this.panel_payment.Size = new System.Drawing.Size(101, 114);
            this.panel_payment.TabIndex = 27;
            // 
            // radioB_cheq
            // 
            this.radioB_cheq.AutoSize = true;
            this.radioB_cheq.Location = new System.Drawing.Point(57, 73);
            this.radioB_cheq.Name = "radioB_cheq";
            this.radioB_cheq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioB_cheq.Size = new System.Drawing.Size(41, 17);
            this.radioB_cheq.TabIndex = 26;
            this.radioB_cheq.TabStop = true;
            this.radioB_cheq.Text = "צ\'ק";
            this.radioB_cheq.UseVisualStyleBackColor = true;
            this.radioB_cheq.CheckedChanged += new System.EventHandler(this.radioB_cheq_CheckedChanged);
            // 
            // radiob_cash
            // 
            this.radiob_cash.AutoSize = true;
            this.radiob_cash.Location = new System.Drawing.Point(44, 19);
            this.radiob_cash.Name = "radiob_cash";
            this.radiob_cash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiob_cash.Size = new System.Drawing.Size(54, 17);
            this.radiob_cash.TabIndex = 24;
            this.radiob_cash.TabStop = true;
            this.radiob_cash.Text = "מזומן";
            this.radiob_cash.UseVisualStyleBackColor = true;
            this.radiob_cash.CheckedChanged += new System.EventHandler(this.radiob_cash_CheckedChanged);
            // 
            // radioB_creditcard
            // 
            this.radioB_creditcard.AutoSize = true;
            this.radioB_creditcard.Location = new System.Drawing.Point(2, 47);
            this.radioB_creditcard.Name = "radioB_creditcard";
            this.radioB_creditcard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioB_creditcard.Size = new System.Drawing.Size(96, 17);
            this.radioB_creditcard.TabIndex = 25;
            this.radioB_creditcard.TabStop = true;
            this.radioB_creditcard.Text = "כרטיס אשראי";
            this.radioB_creditcard.UseVisualStyleBackColor = true;
            this.radioB_creditcard.CheckedChanged += new System.EventHandler(this.radioB_creditcard_CheckedChanged);
            // 
            // panel_visa
            // 
            this.panel_visa.Controls.Add(this.label8);
            this.panel_visa.Controls.Add(this.nupdown_paymentNumber);
            this.panel_visa.Controls.Add(this.dateTimePicker1);
            this.panel_visa.Controls.Add(this.maskedTxtb_creditcard);
            this.panel_visa.Controls.Add(this.label2);
            this.panel_visa.Controls.Add(this.label3);
            this.panel_visa.Controls.Add(this.label1);
            this.panel_visa.Controls.Add(this.txt_cw);
            this.panel_visa.Location = new System.Drawing.Point(13, 218);
            this.panel_visa.Name = "panel_visa";
            this.panel_visa.Size = new System.Drawing.Size(404, 51);
            this.panel_visa.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "מספר תשלומים";
            // 
            // nupdown_paymentNumber
            // 
            this.nupdown_paymentNumber.Location = new System.Drawing.Point(3, 3);
            this.nupdown_paymentNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdown_paymentNumber.Name = "nupdown_paymentNumber";
            this.nupdown_paymentNumber.Size = new System.Drawing.Size(35, 20);
            this.nupdown_paymentNumber.TabIndex = 8;
            this.nupdown_paymentNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "בחר";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // maskedTxtb_creditcard
            // 
            this.maskedTxtb_creditcard.Location = new System.Drawing.Point(141, 3);
            this.maskedTxtb_creditcard.Mask = "0000-0000-0000-0000";
            this.maskedTxtb_creditcard.Name = "maskedTxtb_creditcard";
            this.maskedTxtb_creditcard.Size = new System.Drawing.Size(117, 20);
            this.maskedTxtb_creditcard.TabIndex = 6;
            this.maskedTxtb_creditcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtb_creditcard_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "שלוש ספרות בגב הכרטיס";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "תוקף";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "מספר כרטיס אשראי";
            // 
            // txt_cw
            // 
            this.txt_cw.Location = new System.Drawing.Point(189, 29);
            this.txt_cw.MaxLength = 3;
            this.txt_cw.Name = "txt_cw";
            this.txt_cw.Size = new System.Drawing.Size(69, 20);
            this.txt_cw.TabIndex = 2;
            this.txt_cw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cw_KeyPress);
            // 
            // panel_check
            // 
            this.panel_check.Controls.Add(this.txt_bank_number);
            this.panel_check.Controls.Add(this.txt_branch_number);
            this.panel_check.Controls.Add(this.txt_user_account);
            this.panel_check.Controls.Add(this.txt_cheque_number);
            this.panel_check.Controls.Add(this.label7);
            this.panel_check.Controls.Add(this.label6);
            this.panel_check.Controls.Add(this.label5);
            this.panel_check.Controls.Add(this.label4);
            this.panel_check.Location = new System.Drawing.Point(125, 333);
            this.panel_check.Name = "panel_check";
            this.panel_check.Size = new System.Drawing.Size(278, 47);
            this.panel_check.TabIndex = 29;
            // 
            // txt_bank_number
            // 
            this.txt_bank_number.Location = new System.Drawing.Point(0, 24);
            this.txt_bank_number.MaxLength = 2;
            this.txt_bank_number.Name = "txt_bank_number";
            this.txt_bank_number.Size = new System.Drawing.Size(69, 20);
            this.txt_bank_number.TabIndex = 13;
            this.txt_bank_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bank_number_KeyPress);
            // 
            // txt_branch_number
            // 
            this.txt_branch_number.Location = new System.Drawing.Point(0, 3);
            this.txt_branch_number.MaxLength = 3;
            this.txt_branch_number.Name = "txt_branch_number";
            this.txt_branch_number.Size = new System.Drawing.Size(69, 20);
            this.txt_branch_number.TabIndex = 12;
            this.txt_branch_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_branch_number_KeyPress);
            // 
            // txt_user_account
            // 
            this.txt_user_account.Location = new System.Drawing.Point(117, 24);
            this.txt_user_account.MaxLength = 9;
            this.txt_user_account.Name = "txt_user_account";
            this.txt_user_account.Size = new System.Drawing.Size(82, 20);
            this.txt_user_account.TabIndex = 11;
            this.txt_user_account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_account_KeyPress);
            // 
            // txt_cheque_number
            // 
            this.txt_cheque_number.Location = new System.Drawing.Point(117, 3);
            this.txt_cheque_number.MaxLength = 7;
            this.txt_cheque_number.Name = "txt_cheque_number";
            this.txt_cheque_number.Size = new System.Drawing.Size(82, 20);
            this.txt_cheque_number.TabIndex = 10;
            this.txt_cheque_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cheque_number_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "מס\' בנק";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "סניף";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "מספר המחאה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "מספר חשבון";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rb_general
            // 
            this.rb_general.AutoSize = true;
            this.rb_general.Location = new System.Drawing.Point(366, 310);
            this.rb_general.Name = "rb_general";
            this.rb_general.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_general.Size = new System.Drawing.Size(51, 17);
            this.rb_general.TabIndex = 30;
            this.rb_general.TabStop = true;
            this.rb_general.Text = "כללי";
            this.rb_general.UseVisualStyleBackColor = true;
            this.rb_general.CheckedChanged += new System.EventHandler(this.rb_general_CheckedChanged);
            // 
            // rb_members
            // 
            this.rb_members.AutoSize = true;
            this.rb_members.Location = new System.Drawing.Point(308, 310);
            this.rb_members.Name = "rb_members";
            this.rb_members.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_members.Size = new System.Drawing.Size(52, 17);
            this.rb_members.TabIndex = 31;
            this.rb_members.TabStop = true;
            this.rb_members.Text = "רשום";
            this.rb_members.UseVisualStyleBackColor = true;
            this.rb_members.CheckedChanged += new System.EventHandler(this.rb_members_CheckedChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(216, 307);
            this.txt_id.MaxLength = 9;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(94, 20);
            this.txt_id.TabIndex = 32;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_finalPrice
            // 
            this.txt_finalPrice.Location = new System.Drawing.Point(135, 307);
            this.txt_finalPrice.Name = "txt_finalPrice";
            this.txt_finalPrice.ReadOnly = true;
            this.txt_finalPrice.Size = new System.Drawing.Size(75, 20);
            this.txt_finalPrice.TabIndex = 33;
            // 
            // label_f_price
            // 
            this.label_f_price.AutoSize = true;
            this.label_f_price.Location = new System.Drawing.Point(139, 291);
            this.label_f_price.Name = "label_f_price";
            this.label_f_price.Size = new System.Drawing.Size(77, 13);
            this.label_f_price.TabIndex = 34;
            this.label_f_price.Text = "מחיר לתשלום";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::PlisseeProgect.Properties.Resources.shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(37, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_search);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(525, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 291);
            this.panel1.TabIndex = 36;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(6, 224);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(29, 59);
            this.btn_remove.TabIndex = 22;
            this.btn_remove.Text = "הסר";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_return.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_return.Location = new System.Drawing.Point(3, 276);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(120, 21);
            this.btn_return.TabIndex = 35;
            this.btn_return.Text = "החזרת מוצרים";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_payments
            // 
            this.btn_payments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payments.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_payments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_payments.Location = new System.Drawing.Point(531, 293);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(120, 49);
            this.btn_payments.TabIndex = 23;
            this.btn_payments.Text = "אופן התשלום";
            this.btn_payments.UseVisualStyleBackColor = false;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // lab_home4
            // 
            this.lab_home4.AutoSize = true;
            this.lab_home4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home4.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home4.ForeColor = System.Drawing.Color.White;
            this.lab_home4.Location = new System.Drawing.Point(564, 176);
            this.lab_home4.Name = "lab_home4";
            this.lab_home4.Size = new System.Drawing.Size(43, 18);
            this.lab_home4.TabIndex = 19;
            this.lab_home4.Text = "כמות";
            // 
            // lab_home3
            // 
            this.lab_home3.AutoSize = true;
            this.lab_home3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home3.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home3.ForeColor = System.Drawing.Color.White;
            this.lab_home3.Location = new System.Drawing.Point(559, 68);
            this.lab_home3.Name = "lab_home3";
            this.lab_home3.Size = new System.Drawing.Size(48, 18);
            this.lab_home3.TabIndex = 16;
            this.lab_home3.Text = "מידות";
            // 
            // lab_home2
            // 
            this.lab_home2.AutoSize = true;
            this.lab_home2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home2.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home2.ForeColor = System.Drawing.Color.White;
            this.lab_home2.Location = new System.Drawing.Point(559, 124);
            this.lab_home2.Name = "lab_home2";
            this.lab_home2.Size = new System.Drawing.Size(56, 18);
            this.lab_home2.TabIndex = 15;
            this.lab_home2.Text = "אורכים";
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sale.Location = new System.Drawing.Point(3, 303);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(120, 34);
            this.btn_sale.TabIndex = 14;
            this.btn_sale.Text = "רכש מוצרים";
            this.btn_sale.UseVisualStyleBackColor = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(538, 11);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(99, 18);
            this.lab_home1.TabIndex = 8;
            this.lab_home1.Text = "קודי המוצרים";
            // 
            // UserSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label_f_price);
            this.Controls.Add(this.txt_finalPrice);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rb_members);
            this.Controls.Add(this.rb_general);
            this.Controls.Add(this.panel_check);
            this.Controls.Add(this.panel_visa);
            this.Controls.Add(this.panel_payment);
            this.Controls.Add(this.btn_payments);
            this.Controls.Add(this.listview_salling);
            this.Controls.Add(this.lab_home4);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.lab_home3);
            this.Controls.Add(this.lab_home2);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.cmb_length);
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.panel1);
            this.Name = "UserSale";
            this.Size = new System.Drawing.Size(651, 340);
            this.Load += new System.EventHandler(this.UserSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_payment.ResumeLayout(false);
            this.panel_payment.PerformLayout();
            this.panel_visa.ResumeLayout(false);
            this.panel_visa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_paymentNumber)).EndInit();
            this.panel_check.ResumeLayout(false);
            this.panel_check.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private lab_home lab_home1;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.ComboBox cmb_length;
        private btn_home btn_sale;
        private lab_home lab_home2;
        private lab_home lab_home3;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private lab_home lab_home4;
        public System.Windows.Forms.ColumnHeader code;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ListView listview_salling;
        private System.Windows.Forms.PictureBox pictureBox1;
        private btn_home btn_remove;
        private btn_home btn_payments;
        private System.Windows.Forms.Panel panel_payment;
        private System.Windows.Forms.RadioButton radioB_cheq;
        private System.Windows.Forms.RadioButton radiob_cash;
        private System.Windows.Forms.RadioButton radioB_creditcard;
        private System.Windows.Forms.Panel panel_visa;
        private System.Windows.Forms.Panel panel_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cw;
        private System.Windows.Forms.TextBox txt_user_account;
        private System.Windows.Forms.TextBox txt_cheque_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bank_number;
        private System.Windows.Forms.TextBox txt_branch_number;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTxtb_creditcard;
        private System.Windows.Forms.RadioButton rb_members;
        private System.Windows.Forms.RadioButton rb_general;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_f_price;
        private System.Windows.Forms.TextBox txt_finalPrice;
        private btn_home btn_return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupdown_paymentNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
