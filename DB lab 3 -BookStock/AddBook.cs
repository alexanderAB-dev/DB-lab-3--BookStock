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
    public partial class AddBook : Form
    {
        public AddBook()
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
                cboBooks.DataSource = books;
                cboBooks.ValueMember = "Isbn13";
                cboBooks.DisplayMember = "Title";
            }
        }          
       
        

        private void AddBook_Click(object sender, EventArgs e)
        {
            string selectedStore = cboStores.GetItemText(cboStores.SelectedItem);           
            string selectedBook = cboBooks.GetItemText(cboBooks.SelectedItem);
           
            try
            {
                int quantity = int.Parse(textBox1.Text);
                using (var context = new StoreContext())
                {
                    int storeId = (from s in context.Stores where s.Name == selectedStore select s.Id).FirstOrDefault();
                    string isbn = (from b in context.Books where b.Title == selectedBook select b.Isbn13).FirstOrDefault();                  
                   
                    context.CreateStock(storeId, isbn, quantity);
                }
                textBox1.Clear();
            }
            catch (System.FormatException) 
            {
                MessageBox.Show("Quantity must have a number.");
            }

        }        
    }
}
