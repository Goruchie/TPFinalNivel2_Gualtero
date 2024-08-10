using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using domain;
using service;

namespace StoreApp
{
    public partial class Details : Form
    {
        private List<Item> itemList;
        private Item item = null;
       
        public Details()
        {
            InitializeComponent();
        }

        public Details(Item item)
        {
            InitializeComponent();
            this.item = item;            
        }

        private void Details_Load(object sender, EventArgs e)
        {
            StoreServices service = new StoreServices();
            try
            {                
                lblCodeD.Text = item.Code;
                lblNameD.Text = item.Name;
                lblDescriptionD.Text = item.Description;                
                lblBrandD.Text = item.Brand.Description;
                lblCategoryD.Text = item.Category.Description;
                lblPriceD.Text = item.Price.ToString();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

    }
}
