using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using domain;
using service;
using System.Configuration;
using System.Diagnostics;

namespace StoreApp
{
    public partial class NewItem : Form
    {
        private Item item = null;
        private OpenFileDialog file = null;
        public NewItem()
        {
            InitializeComponent();
        }
        public NewItem(Item item)
        {
            InitializeComponent();
            this.item = item;
            Text = "Edit Item";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void NewItem_Load(object sender, EventArgs e)
        {
            BrandServices brandServices = new BrandServices();
            CategoryServices categoryServices = new CategoryServices();
            try
            {
                cboBrand.DataSource = brandServices.list();
                cboBrand.ValueMember = "Id";
                cboBrand.DisplayMember = "Description";
                cboCategory.DataSource = categoryServices.list();
                cboCategory.ValueMember = "Id";
                cboCategory.DisplayMember = "Description";
                loadImage(txtUrlImage.Text);

                if (item != null)
                {
                    txtCode.Text = item.Code;
                    txtName.Text = item.Name;
                    txtDescription.Text = item.Description;
                    cboBrand.SelectedValue = item.Brand.Id;
                    cboCategory.SelectedValue = item.Category.Id;
                    txtUrlImage.Text = item.UrlImage;
                    txtPrice.Text = item.Price.ToString();
                    loadImage(txtUrlImage.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void loadImage(string image)
        {
            try
            {
                pbxItem.Load(image);
                if (pbxItem.Image.Width > 250 & pbxItem.Image.Height > 300)
                {
                    pbxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbxItem.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                pbxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxItem.Load("https://media.istockphoto.com/vectors/no-image-available-icon-vector-id1216251206?k=20&m=1216251206&s=170667a&w=0&h=A72dFkHkDdSfmT6iWl6eMN9t_JZmqGeMoAycP-LMAw4=");
            }
        }

        private void txtUrlImage_Leave(object sender, EventArgs e)
        {
            loadImage(txtUrlImage.Text);
        }

        private bool onlyNumbers(string chain)
        {
            foreach (char character in chain)
            {
                if (!(char.IsNumber(character)))
                    return false;

            }
            return true;            
        }


        private bool validateFilter()
        {
            if (!onlyNumbers(txtPrice.Text))
            {
                MessageBox.Show("The price must be a number");
                return true;
            }
            if (txtCode.Text == "")
            {
                MessageBox.Show("You must enter a code.");
                return true;
            }                       
            if (txtName.Text == "")
            {
                MessageBox.Show("You must enter a name.");
                return true;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("You must enter a description.");
                return true;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("You must enter a price.");
                return true;
            }


            return false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            StoreServices service = new StoreServices();
            try
            {
                if (validateFilter())
                    return;
                if (item == null)
                    item = new Item();

                item.Code = txtCode.Text;
                item.Name = txtName.Text;
                item.Description = txtDescription.Text;
                item.Brand = (Brand)cboBrand.SelectedItem;
                item.Category = (Category)cboCategory.SelectedItem;
                item.UrlImage = txtUrlImage.Text;
                item.Price = Convert.ToInt32(txtPrice.Text);              

                if (item.Id != 0)
                {
                    service.modify(item);
                    MessageBox.Show("Item edited");
                }
                else
                {
                    service.add(item);
                    MessageBox.Show("Item added");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
