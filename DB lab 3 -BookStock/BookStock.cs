
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DB_lab_3__BookStock
{
    public partial class BookStock : Form
    {
        public BookStock()
        {
            InitializeComponent();
            BindData();
        }
                

        public void BindData()
        {
            using (var context = new StoreContext())
            {
                var stores = context.Stores.ToList();
                cboStores.DataSource = stores;
                cboStores.ValueMember = "Id";
                cboStores.DisplayMember = "Name";
            }
        }
 
        private void PopulateTable(object sender, EventArgs e)
        {
            Object selectedItem = cboStores.SelectedItem;
            string selectedStore = cboStores.GetItemText(cboStores.SelectedItem);

            if (selectedItem != null)
            {
                storeView.DataSource = false;
                Cursor.Current = Cursors.WaitCursor;
                try
                {                    
                    using (var context = new StoreContext())
                    {
                        int storeId = (from s in context.Stores where s.Name == selectedStore select s.Id).FirstOrDefault();
                        StoreContext.FetchStores(storeId);                      
                        storeView.DataSource = StoreContext.stockView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Cursor.Current = Cursors.Default;
            }

        }   
             

        private void RemoveBook_Click(object sender, EventArgs e)
        {
            var form = new RemoveBook();
            form.ShowDialog();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var form = new AddBook();
            form.ShowDialog();
        }
    }
}
