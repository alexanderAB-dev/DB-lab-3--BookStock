
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
                cboStore.DataSource = stores;
                cboStore.ValueMember = "Id";
                cboStore.DisplayMember = "Name";
            }
        }
 
        private void cboStore_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Object selectedItem = cboStore.SelectedItem;
            int storeName = Int32.Parse(cboStore.SelectedValue.ToString());
           
            if (selectedItem != null)
            {
                storeView.DataSource = false;
                Cursor.Current = Cursors.WaitCursor;
                try
                {                    
                    using (var context = new StoreContext())
                    {
                        StoreContext.FetchStores(storeName);                      
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
             

        private void removeBook_Click(object sender, EventArgs e)
        {
            var form = new RemoveBook();
            form.ShowDialog();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            var form = new AddBook();
            form.ShowDialog();
        }
    }
}
