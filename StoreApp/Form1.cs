using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using service;
using static System.Net.Mime.MediaTypeNames;

namespace StoreApp
{
    public partial class frmStore : Form
    {
        private List<Item> itemList;
        public frmStore()
        {
            InitializeComponent();
        }
        private void load()
        {
            StoreServices service = new StoreServices();
            try
            {
                itemList = service.list();
                dgvStore.DataSource = itemList;
                hidenColumns();
                loadImage(itemList[0].UrlImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            load();
            cboFilterBy.Items.Add("Code");
            cboFilterBy.Items.Add("Name");
            cboFilterBy.Items.Add("Price");
        }
        private void hidenColumns()
        {
            dgvStore.Columns["Id"].Visible = false;
            dgvStore.Columns["UrlImage"].Visible = false;
            dgvStore.Columns["Description"].Visible = false;
            dgvStore.Columns["Brand"].Visible = false;
            dgvStore.Columns["Category"].Visible = false;
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

        private void dgvStore_SelectionChanged(object sender, EventArgs e)
        {
            Item selected = (Item)dgvStore.CurrentRow.DataBoundItem;
            loadImage(selected.UrlImage);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewItem register = new NewItem();
            register.ShowDialog();
            load();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
            Item selected;
                if (dgvStore.CurrentRow == null)
                {
                    MessageBox.Show("You must select an item to edit.");
                    return;
                }
            selected = (Item)dgvStore.CurrentRow.DataBoundItem;
            NewItem modify = new NewItem(selected);
            modify.ShowDialog();            
            load();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StoreServices service = new StoreServices();
            Item selected;
            if (dgvStore.CurrentRow == null)
            {
                MessageBox.Show("You must select an item to delete.");
                return;
            }
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this item?", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                selected = (Item)dgvStore.CurrentRow.DataBoundItem;
                service.delete(selected.Id);
                load();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btbDetails_Click(object sender, EventArgs e)
        {
            Item selected;
            if (dgvStore.CurrentRow == null)
            {
                MessageBox.Show("You must select an item to see details.");
                return;
            }
            try
            {
            selected = (Item)dgvStore.CurrentRow.DataBoundItem;
            Details details = new Details(selected);
            details.ShowDialog();
            load();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cboFilterBy.SelectedItem.ToString();
            if (option == "Price")
            {
                cboCriteria.Items.Clear();
                cboCriteria.Items.Add("Less than");
                cboCriteria.Items.Add("Greater than");
                cboCriteria.Items.Add("Equal to");
            }
            else
            {
                cboCriteria.Items.Clear();
                cboCriteria.Items.Add("Contains");
                cboCriteria.Items.Add("Starts with");
                cboCriteria.Items.Add("Ends with");
            }
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
            if (cboFilterBy.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a filter option.");
                return true;
            }
            if (cboCriteria.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a criteria option.");
                return true;
            }
            if (cboFilterBy.SelectedItem.ToString() == "Price")
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("You must enter a number to filter.");
                    return true;
                }
                if (!onlyNumbers(txtSearch.Text))
                {
                    MessageBox.Show("You must enter numbers for this field.");
                    return true;
                }
               
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StoreServices service = new StoreServices();
            try
            {
                if (validateFilter())
                    return;
                string filterBy = cboFilterBy.SelectedItem.ToString();
                string criteria = cboCriteria.SelectedItem.ToString();
                string search = txtSearch.Text;
                dgvStore.DataSource = service.filter(filterBy, criteria, search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
