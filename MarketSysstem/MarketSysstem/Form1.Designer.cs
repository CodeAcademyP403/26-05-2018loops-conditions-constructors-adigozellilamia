namespace MarketSysstem
{
    partial class Frm_market
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_etMehsullari = new System.Windows.Forms.Label();
            this.lbl_sudMehsullari = new System.Windows.Forms.Label();
            this.lbl_meyveTerevez = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_exdt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_allCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(22, 37);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(146, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(22, 88);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(146, 20);
            this.txt_weight.TabIndex = 1;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(22, 201);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(146, 20);
            this.txt_price.TabIndex = 4;
            // 
            // cmb_categories
            // 
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(22, 145);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(146, 21);
            this.cmb_categories.TabIndex = 3;
            this.cmb_categories.SelectedIndexChanged += new System.EventHandler(this.cmb_categories_SelectedIndexChanged);
            this.cmb_categories.TextChanged += new System.EventHandler(this.cmb_categories_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(124, 309);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(203, 49);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stok.Location = new System.Drawing.Point(316, 37);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(73, 17);
            this.lbl_stok.TabIndex = 7;
            this.lbl_stok.Text = "Stok sayi :";
            this.lbl_stok.Visible = false;
            // 
            // lbl_etMehsullari
            // 
            this.lbl_etMehsullari.AutoSize = true;
            this.lbl_etMehsullari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_etMehsullari.Location = new System.Drawing.Point(292, 102);
            this.lbl_etMehsullari.Name = "lbl_etMehsullari";
            this.lbl_etMehsullari.Size = new System.Drawing.Size(97, 17);
            this.lbl_etMehsullari.TabIndex = 8;
            this.lbl_etMehsullari.Text = "Et mehsullari :";
            this.lbl_etMehsullari.Visible = false;
            // 
            // lbl_sudMehsullari
            // 
            this.lbl_sudMehsullari.AutoSize = true;
            this.lbl_sudMehsullari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sudMehsullari.Location = new System.Drawing.Point(243, 129);
            this.lbl_sudMehsullari.Name = "lbl_sudMehsullari";
            this.lbl_sudMehsullari.Size = new System.Drawing.Size(146, 17);
            this.lbl_sudMehsullari.TabIndex = 9;
            this.lbl_sudMehsullari.Text = "Shirniyyat mehsullari :";
            this.lbl_sudMehsullari.Visible = false;
            // 
            // lbl_meyveTerevez
            // 
            this.lbl_meyveTerevez.AutoSize = true;
            this.lbl_meyveTerevez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_meyveTerevez.Location = new System.Drawing.Point(212, 162);
            this.lbl_meyveTerevez.Name = "lbl_meyveTerevez";
            this.lbl_meyveTerevez.Size = new System.Drawing.Size(177, 17);
            this.lbl_meyveTerevez.TabIndex = 10;
            this.lbl_meyveTerevez.Text = "Meyve-terevez mehsullari :";
            this.lbl_meyveTerevez.Visible = false;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(22, 264);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(19, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 15);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Name";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weight.Location = new System.Drawing.Point(19, 72);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(45, 15);
            this.lbl_weight.TabIndex = 12;
            this.lbl_weight.Text = "Weight";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category.Location = new System.Drawing.Point(19, 129);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(55, 15);
            this.lbl_category.TabIndex = 13;
            this.lbl_category.Text = "Category";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_price.Location = new System.Drawing.Point(19, 185);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 15);
            this.lbl_price.TabIndex = 14;
            this.lbl_price.Text = "Price";
            // 
            // lbl_exdt
            // 
            this.lbl_exdt.AutoSize = true;
            this.lbl_exdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exdt.Location = new System.Drawing.Point(19, 248);
            this.lbl_exdt.Name = "lbl_exdt";
            this.lbl_exdt.Size = new System.Drawing.Size(39, 15);
            this.lbl_exdt.TabIndex = 15;
            this.lbl_exdt.Text = "EXDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // lbl_allCategory
            // 
            this.lbl_allCategory.AutoSize = true;
            this.lbl_allCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_allCategory.Location = new System.Drawing.Point(254, 70);
            this.lbl_allCategory.Name = "lbl_allCategory";
            this.lbl_allCategory.Size = new System.Drawing.Size(123, 17);
            this.lbl_allCategory.TabIndex = 17;
            this.lbl_allCategory.Text = "Kateqoriya uzre";
            this.lbl_allCategory.Visible = false;
            // 
            // Frm_market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.lbl_allCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_exdt);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lbl_meyveTerevez);
            this.Controls.Add(this.lbl_sudMehsullari);
            this.Controls.Add(this.lbl_etMehsullari);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_categories);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_name);
            this.Name = "Frm_market";
            this.Text = "Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cmb_categories;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_etMehsullari;
        private System.Windows.Forms.Label lbl_sudMehsullari;
        private System.Windows.Forms.Label lbl_meyveTerevez;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_exdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_allCategory;
    }
}

