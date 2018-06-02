using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSysstem
{
    public partial class Frm_market : Form
    {
        public Frm_market()
        {
            InitializeComponent();
            Categories();
            CategoryToCombobox();
        }
        List<Categories> categories= new List<Categories>();
        public void Categories()
        {

            //Categories categories1 = new Categories();
            //categories1._Name = "Food categories";
            //categories.Add(categories1);
            Categories categories2 = new Categories();
            categories2._Name = "Meyve-terevez mehsullari";
            categories.Add(categories2);
            Categories categories3 = new Categories();
            categories3._Name = "Et mehsullari";
            categories.Add(categories3);
            Categories categories4 = new Categories();
            categories4._Name = "Shirniyyat mehsullari";
            categories.Add(categories4);
        }

        private void CategoryToCombobox()
        {
            foreach (Categories item in categories)
            {
                cmb_categories.Items.Add(item._Name);
            }
        }
        int etMehsullariCounter=0;
        int shirniyyatMehsullariCounter = 0;
        int terevezMehsullariCounter = 0;
        List<Food> foods = new List<Food>();
        private void btn_add_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            //MessageBox.Show(txt_name.Text);

            if (txt_name.Text.Length > 3 && txt_name.Text.Length < 50)
            {
                food._Name = txt_name.Text;
            }
            food._Weight = Convert.ToDouble(txt_weight.Text);
            food._Price = Convert.ToDouble(txt_price.Text);
            food._CategoryName = Convert.ToString(cmb_categories.Text);
            //MessageBox.Show(Convert.ToString(cmb_categories.Text));
            food._EXDT = Convert.ToDateTime(dateTime.Text);
            foods.Add(food);

            switch (Convert.ToString(cmb_categories.Text))
            {
                case "Et mehsullari":etMehsullariCounter++; break;
                case "Shirniyyat mehsullari": shirniyyatMehsullariCounter++; break;
                case "Meyve-terevez mehsullari":terevezMehsullariCounter++; break;

            }
            lbl_allCategory.Visible = true;
            lbl_stok.Visible = true;
            lbl_sudMehsullari.Visible = true;
            lbl_etMehsullari.Visible = true;
            lbl_meyveTerevez.Visible = true;
            lbl_stok.Text = "Stok sayi: "+(etMehsullariCounter+ shirniyyatMehsullariCounter + terevezMehsullariCounter);
            lbl_etMehsullari.Text = "Et mehsullari: " + etMehsullariCounter;
            lbl_meyveTerevez.Text = "Meyve-terevez mehsullari: " + terevezMehsullariCounter;
            lbl_sudMehsullari.Text = "Shirniyyat mehsullari: " + shirniyyatMehsullariCounter;

            txt_name.Text = "";
            txt_weight.Text = "";
            txt_price.Text = "";
            cmb_categories.Text = "";
            
        }

        private void cmb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_categories_TextChanged(object sender, EventArgs e)
        {  
        }
    }
}
