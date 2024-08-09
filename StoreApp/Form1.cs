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
    }
}
