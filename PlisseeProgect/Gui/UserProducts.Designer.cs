namespace PlisseeProgect.Gui
{
    partial class UserProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.txt_code_p = new System.Windows.Forms.TextBox();
            this.txt_salling_p = new System.Windows.Forms.TextBox();
            this.txt_pur_p = new System.Windows.Forms.TextBox();
            this.txt_descr_p = new System.Windows.Forms.TextBox();
            this.cmb_type_p = new System.Windows.Forms.ComboBox();
            this.cmb_instituation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelP = new System.Windows.Forms.Label();
            this.txt_new_p = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_new = new PlisseeProgect.btn_home();
            this.btn_erase = new PlisseeProgect.btn_home();
            this.btn_raanen = new PlisseeProgect.btn_home();
            this.btn_show = new PlisseeProgect.btn_home();
            this.btn_change = new PlisseeProgect.btn_home();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancel_p = new PlisseeProgect.btn_home();
            this.btn_continue_p = new PlisseeProgect.btn_home();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_company = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_erase1 = new PlisseeProgect.btn_home();
            this.btn_add2 = new PlisseeProgect.btn_home();
            this.lab_home5 = new PlisseeProgect.lab_home();
            this.btn_add = new PlisseeProgect.btn_home();
            this.lab_home2 = new PlisseeProgect.lab_home();
            this.lab_home1 = new PlisseeProgect.lab_home();
            this.lab_salling_p = new PlisseeProgect.lab_home();
            this.lab_purchase_p = new PlisseeProgect.lab_home();
            this.lab_pro_des = new PlisseeProgect.lab_home();
            this.lab_code = new PlisseeProgect.lab_home();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_products.Location = new System.Drawing.Point(163, 10);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(471, 284);
            this.dgv_products.TabIndex = 0;
            // 
            // txt_code_p
            // 
            this.txt_code_p.Location = new System.Drawing.Point(6, 17);
            this.txt_code_p.Name = "txt_code_p";
            this.txt_code_p.Size = new System.Drawing.Size(73, 25);
            this.txt_code_p.TabIndex = 6;
            this.txt_code_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code_p.TextChanged += new System.EventHandler(this.txt_code_p_TextChanged);
            this.txt_code_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_p_KeyPress);
            // 
            // txt_salling_p
            // 
            this.txt_salling_p.Location = new System.Drawing.Point(82, 62);
            this.txt_salling_p.Name = "txt_salling_p";
            this.txt_salling_p.Size = new System.Drawing.Size(72, 25);
            this.txt_salling_p.TabIndex = 7;
            this.txt_salling_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_salling_p.TextChanged += new System.EventHandler(this.txt_salling_p_TextChanged);
            this.txt_salling_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salling_p_KeyPress);
            // 
            // txt_pur_p
            // 
            this.txt_pur_p.Location = new System.Drawing.Point(82, 17);
            this.txt_pur_p.Name = "txt_pur_p";
            this.txt_pur_p.Size = new System.Drawing.Size(73, 25);
            this.txt_pur_p.TabIndex = 8;
            this.txt_pur_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pur_p.TextChanged += new System.EventHandler(this.txt_pur_p_TextChanged);
            this.txt_pur_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pur_p_KeyPress);
            // 
            // txt_descr_p
            // 
            this.txt_descr_p.Location = new System.Drawing.Point(6, 107);
            this.txt_descr_p.Name = "txt_descr_p";
            this.txt_descr_p.Size = new System.Drawing.Size(148, 25);
            this.txt_descr_p.TabIndex = 9;
            this.txt_descr_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_descr_p.TextChanged += new System.EventHandler(this.txt_descr_p_TextChanged);
            this.txt_descr_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descr_p_KeyPress);
            // 
            // cmb_type_p
            // 
            this.cmb_type_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_type_p.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_type_p.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_type_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_type_p.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmb_type_p, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.cmb_type_p.Items.AddRange(new object[] {
            "חצאית",
            "חולצה"});
            this.cmb_type_p.Location = new System.Drawing.Point(6, 240);
            this.cmb_type_p.Name = "cmb_type_p";
            this.cmb_type_p.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_type_p.Size = new System.Drawing.Size(148, 21);
            this.cmb_type_p.TabIndex = 14;
            this.cmb_type_p.SelectedIndexChanged += new System.EventHandler(this.cmb_type_p_SelectedIndexChanged);
            this.cmb_type_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_type_p_KeyPress);
            // 
            // cmb_instituation
            // 
            this.cmb_instituation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_instituation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_instituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_instituation.FormattingEnabled = true;
            this.cmb_instituation.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל"});
            this.cmb_instituation.Location = new System.Drawing.Point(6, 152);
            this.cmb_instituation.Name = "cmb_instituation";
            this.cmb_instituation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_instituation.Size = new System.Drawing.Size(148, 21);
            this.cmb_instituation.TabIndex = 15;
            this.cmb_instituation.SelectedIndexChanged += new System.EventHandler(this.cmb_status_p_SelectedIndexChanged);
            this.cmb_instituation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_instituation_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelP);
            this.panel1.Controls.Add(this.txt_new_p);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(3, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 51);
            this.panel1.TabIndex = 19;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Bodoni MT Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelP.Location = new System.Drawing.Point(103, 3);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(48, 14);
            this.labelP.TabIndex = 20;
            this.labelP.Text = "שם מוצר";
            // 
            // txt_new_p
            // 
            this.txt_new_p.Location = new System.Drawing.Point(3, 0);
            this.txt_new_p.Name = "txt_new_p";
            this.txt_new_p.Size = new System.Drawing.Size(100, 25);
            this.txt_new_p.TabIndex = 2;
            this.txt_new_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_new_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_new_p_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(24, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(49, 22);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "בטל";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(79, 27);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(47, 22);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Controls.Add(this.btn_erase);
            this.panel2.Controls.Add(this.btn_raanen);
            this.panel2.Controls.Add(this.btn_show);
            this.panel2.Controls.Add(this.btn_change);
            this.panel2.Location = new System.Drawing.Point(163, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 50);
            this.panel2.TabIndex = 20;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new.Location = new System.Drawing.Point(388, 20);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 25);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "חדש";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_erase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_erase.Location = new System.Drawing.Point(298, 20);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(75, 25);
            this.btn_erase.TabIndex = 2;
            this.btn_erase.Text = "מחק";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn__Click);
            // 
            // btn_raanen
            // 
            this.btn_raanen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_raanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raanen.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_raanen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_raanen.Location = new System.Drawing.Point(206, 20);
            this.btn_raanen.Name = "btn_raanen";
            this.btn_raanen.Size = new System.Drawing.Size(75, 25);
            this.btn_raanen.TabIndex = 3;
            this.btn_raanen.Text = "רענן";
            this.btn_raanen.UseVisualStyleBackColor = false;
            this.btn_raanen.Click += new System.EventHandler(this.btn_home3_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show.Location = new System.Drawing.Point(116, 20);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 25);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "הצג";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_home4_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change.Location = new System.Drawing.Point(20, 20);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 25);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "עדכן";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_home5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancel_p);
            this.panel3.Controls.Add(this.btn_continue_p);
            this.panel3.Location = new System.Drawing.Point(3, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 29);
            this.panel3.TabIndex = 21;
            // 
            // btn_cancel_p
            // 
            this.btn_cancel_p.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cancel_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_p.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_cancel_p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel_p.Location = new System.Drawing.Point(16, 3);
            this.btn_cancel_p.Name = "btn_cancel_p";
            this.btn_cancel_p.Size = new System.Drawing.Size(57, 25);
            this.btn_cancel_p.TabIndex = 1;
            this.btn_cancel_p.Text = "בטל";
            this.btn_cancel_p.UseVisualStyleBackColor = false;
            this.btn_cancel_p.Click += new System.EventHandler(this.btn_cancel_p_Click);
            // 
            // btn_continue_p
            // 
            this.btn_continue_p.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_continue_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue_p.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_continue_p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_continue_p.Location = new System.Drawing.Point(79, 3);
            this.btn_continue_p.Name = "btn_continue_p";
            this.btn_continue_p.Size = new System.Drawing.Size(57, 25);
            this.btn_continue_p.TabIndex = 0;
            this.btn_continue_p.Text = "המשך";
            this.btn_continue_p.UseVisualStyleBackColor = false;
            this.btn_continue_p.Click += new System.EventHandler(this.btn_save_p_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_company
            // 
            this.cmb_company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_company.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmb_company, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.cmb_company.Items.AddRange(new object[] {
            "חצאית",
            "חולצה"});
            this.cmb_company.Location = new System.Drawing.Point(0, 66);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_company.Size = new System.Drawing.Size(79, 21);
            this.cmb_company.TabIndex = 61;
            this.cmb_company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_company_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 34);
            this.panel4.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "בטל";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "שמור";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_erase1
            // 
            this.btn_erase1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_erase1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_erase1.Font = new System.Drawing.Font("Yu Gothic Medium", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_erase1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_erase1.Location = new System.Drawing.Point(116, 134);
            this.btn_erase1.Name = "btn_erase1";
            this.btn_erase1.Size = new System.Drawing.Size(38, 19);
            this.btn_erase1.TabIndex = 65;
            this.btn_erase1.Text = "מחק";
            this.btn_erase1.UseVisualStyleBackColor = false;
            this.btn_erase1.Click += new System.EventHandler(this.btn_home2_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add2.Font = new System.Drawing.Font("Yu Gothic Medium", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_add2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add2.Location = new System.Drawing.Point(11, 134);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(38, 19);
            this.btn_add2.TabIndex = 64;
            this.btn_add2.Text = "חדש";
            this.btn_add2.UseVisualStyleBackColor = false;
            this.btn_add2.Click += new System.EventHandler(this.btn_home1_Click);
            // 
            // lab_home5
            // 
            this.lab_home5.AutoSize = true;
            this.lab_home5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home5.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home5.ForeColor = System.Drawing.Color.White;
            this.lab_home5.Location = new System.Drawing.Point(16, 45);
            this.lab_home5.Name = "lab_home5";
            this.lab_home5.Size = new System.Drawing.Size(59, 14);
            this.lab_home5.TabIndex = 62;
            this.lab_home5.Text = "שם חברה";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Yu Gothic Medium", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(11, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(38, 19);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "חדש";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_home2
            // 
            this.lab_home2.AutoSize = true;
            this.lab_home2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home2.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home2.ForeColor = System.Drawing.Color.White;
            this.lab_home2.Location = new System.Drawing.Point(55, 135);
            this.lab_home2.Name = "lab_home2";
            this.lab_home2.Size = new System.Drawing.Size(56, 14);
            this.lab_home2.TabIndex = 17;
            this.lab_home2.Text = "שם מוסד";
            // 
            // lab_home1
            // 
            this.lab_home1.AutoSize = true;
            this.lab_home1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_home1.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_home1.ForeColor = System.Drawing.Color.White;
            this.lab_home1.Location = new System.Drawing.Point(56, 223);
            this.lab_home1.Name = "lab_home1";
            this.lab_home1.Size = new System.Drawing.Size(55, 14);
            this.lab_home1.TabIndex = 16;
            this.lab_home1.Text = "סוג מוצר";
            // 
            // lab_salling_p
            // 
            this.lab_salling_p.AutoSize = true;
            this.lab_salling_p.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_salling_p.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_salling_p.ForeColor = System.Drawing.Color.White;
            this.lab_salling_p.Location = new System.Drawing.Point(85, 45);
            this.lab_salling_p.Name = "lab_salling_p";
            this.lab_salling_p.Size = new System.Drawing.Size(71, 14);
            this.lab_salling_p.TabIndex = 13;
            this.lab_salling_p.Text = "מחיר מכירה";
            // 
            // lab_purchase_p
            // 
            this.lab_purchase_p.AutoSize = true;
            this.lab_purchase_p.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_purchase_p.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_purchase_p.ForeColor = System.Drawing.Color.White;
            this.lab_purchase_p.Location = new System.Drawing.Point(85, 0);
            this.lab_purchase_p.Name = "lab_purchase_p";
            this.lab_purchase_p.Size = new System.Drawing.Size(72, 14);
            this.lab_purchase_p.TabIndex = 12;
            this.lab_purchase_p.Text = "מחיר הזמנה";
            // 
            // lab_pro_des
            // 
            this.lab_pro_des.AutoSize = true;
            this.lab_pro_des.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_pro_des.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_pro_des.ForeColor = System.Drawing.Color.White;
            this.lab_pro_des.Location = new System.Drawing.Point(47, 90);
            this.lab_pro_des.Name = "lab_pro_des";
            this.lab_pro_des.Size = new System.Drawing.Size(64, 14);
            this.lab_pro_des.TabIndex = 11;
            this.lab_pro_des.Text = "תאור מוצר";
            // 
            // lab_code
            // 
            this.lab_code.AutoSize = true;
            this.lab_code.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lab_code.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lab_code.ForeColor = System.Drawing.Color.White;
            this.lab_code.Location = new System.Drawing.Point(16, 0);
            this.lab_code.Name = "lab_code";
            this.lab_code.Size = new System.Drawing.Size(55, 14);
            this.lab_code.TabIndex = 10;
            this.lab_code.Text = "קוד מוצר";
            // 
            // UserProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btn_erase1);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lab_home5);
            this.Controls.Add(this.cmb_company);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lab_home2);
            this.Controls.Add(this.lab_home1);
            this.Controls.Add(this.cmb_instituation);
            this.Controls.Add(this.cmb_type_p);
            this.Controls.Add(this.lab_salling_p);
            this.Controls.Add(this.lab_purchase_p);
            this.Controls.Add(this.lab_pro_des);
            this.Controls.Add(this.lab_code);
            this.Controls.Add(this.txt_descr_p);
            this.Controls.Add(this.txt_pur_p);
            this.Controls.Add(this.txt_salling_p);
            this.Controls.Add(this.txt_code_p);
            this.Controls.Add(this.dgv_products);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "UserProducts";
            this.Size = new System.Drawing.Size(651, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_products;
        private btn_home btn_new;
        private btn_home btn_erase;
        private btn_home btn_raanen;
        private btn_home btn_show;
        private btn_home btn_change;
        private System.Windows.Forms.TextBox txt_code_p;
        private System.Windows.Forms.TextBox txt_salling_p;
        private System.Windows.Forms.TextBox txt_pur_p;
        private System.Windows.Forms.TextBox txt_descr_p;
        private lab_home lab_code;
        private lab_home lab_pro_des;
        private lab_home lab_purchase_p;
        private lab_home lab_salling_p;
        private System.Windows.Forms.ComboBox cmb_type_p;
        private System.Windows.Forms.ComboBox cmb_instituation;
        private lab_home lab_home1;
        private lab_home lab_home2;
        private btn_home btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_new_p;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private btn_home btn_cancel_p;
        private btn_home btn_continue_p;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_company;
        private lab_home lab_home5;
        private btn_home btn_erase1;
        private btn_home btn_add2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
