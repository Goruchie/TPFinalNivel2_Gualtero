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
                if (pbxItem.Image.Width > 229 & pbxItem.Image.Height > 300)
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
            Item selected;
            selected = (Item)dgvStore.CurrentRow.DataBoundItem;
            NewItem modify = new NewItem(selected);
            modify.ShowDialog();
            load();
        }
    }
}
