using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                

            }
        }

        private void CboStores_LoadBooks(object sender, EventArgs e)
        {
            Object selectedItem = cboStores.SelectedItem;
            string selectedStore = cboStores.GetItemText(cboStores.SelectedItem);

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
                        int storeId = (from s in context.Stores where s.Name == selectedStore select s.Id).FirstOrDefault();
                        StoreContext.LoadStoreBooks(storeId);
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
            string selectedStore = cboStores.GetItemText(cboStores.SelectedItem);
            string selectedBook = cboBooks.GetItemText(cboBooks.SelectedItem);
            try
            {
                using (var context = new StoreContext())
                {
                    int storeId = (from s in context.Stores where s.Name == selectedStore select s.Id).FirstOrDefault();
                    string isbn = (from b in context.Books where b.Title == selectedBook select b.Isbn13).FirstOrDefault();

                    context.DeleteBook(storeId, isbn);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
