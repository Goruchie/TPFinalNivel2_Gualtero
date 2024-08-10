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
            Text = "Modify Item";
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

                if (item != null)
                {
                    txtCode.Text = item.Code;
                    txtName.Text = item.Name;
                    txtDescription.Text = item.Description;
                    cboBrand.SelectedValue = item.Brand.Id;
                    cboCategory.SelectedValue = item.Category.Id;
                    txtUrlImage.Text = item.UrlImage;
                    txtPrice.Text = item.Price.ToString();
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            StoreServices service = new StoreServices();
            try
            {
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
                    MessageBox.Show("Item modified");
                }
                else
                {
                    service.add(item);
                    MessageBox.Show("Item added");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }
    }
}
