using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DB_lab_3__BookStock
{
    public partial class RemoveBook : Form
    {
        public RemoveBook()
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
                var books = context.Books.ToList();

            }
        }

        private void CboStores_LoadStores(object sender, EventArgs e)
        {
            Object selectedItem = cboStores.SelectedItem;
            int storeName = Int32.Parse(cboStores.SelectedValue.ToString());

            if (selectedItem != null)
            {
                cboBooks.DataSource = null;               
                cboBooks.ValueMember = "ISBN13";
                cboBooks.DisplayMember = "Title";
                Cursor.Current = Cursors.WaitCursor;
                try
                {

                    using (var context = new StoreContext())
                    {
                        StoreContext.LoadStoreBooks(storeName);                    
                        cboBooks.DataSource = StoreContext.bookView;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Cursor.Current = Cursors.Default;
            }

        }     
                       

        private void RemoveBook1_Click(object sender, EventArgs e)
        {
            int storeID = Convert.ToInt32(cboStores.SelectedValue.GetHashCode());
            string selectedBook = cboBooks.GetItemText(cboBooks.SelectedItem);
            
            using (var context = new StoreContext())
            {
                var id = (from b in context.Books where b.Title == selectedBook select b.Isbn13).FirstOrDefault();
                string isbn = id.ToString();
                context.DeleteBook(storeID, isbn);
            }
        }

       
    }
}
