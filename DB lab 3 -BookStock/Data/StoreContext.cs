using System;
using System.Collections.Generic;
using System.Text;
using DB_lab_3__BookStock.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace DB_lab_3__BookStock
{

    public class StoreContext : DbContext
    {
        private string connectionString;
        public StoreContext() : base()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
                        .HasKey(s => new { s.StoreId, s.Isbn });
        }

        public DbSet<Stock> Stock { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Book> Books { get; set; }
        
        public static List<StockView> stockView = new List<StockView>();

        public static List<Book> bookView = new List<Book>();

        public static List<StockView> FetchStores(int storeName)
        {
            stockView.Clear();

            using (var context = new StoreContext())
            {

                var stockData = from s in context.Stores
                                join sq in context.Stock on s.Id equals sq.StoreId
                                join b in context.Books on sq.Isbn equals b.Isbn13
                                where s.Id == storeName
                                orderby s.Name descending
                                select new
                                {
                                    Store = s.Name,
                                    Book = b.Title,
                                    Quantity = sq.Quantity
                                };
                foreach (var s in stockData.ToList())
                {
                    stockView.Add(
                        new StockView
                        {
                            Store = s.Store,s
                            Book = s.Book,
                            Quantity = s.Quantity
                        });

                }

            }
            stockView.Sort((x, y) => y.Quantity.CompareTo(x.Quantity));
            return stockView;
        }
        public static List<Book> LoadStoreBooks(int storeName)
        {
            bookView.Clear();
            using (var context = new StoreContext()) 
            {
                var storeBooks = from b in context.Books
                                 join sq in context.Stock on b.Isbn13 equals sq.Isbn
                                 join s in context.Stores on sq.StoreId equals s.Id
                                 where s.Id == storeName                                 
                                 select new
                                 {
                                    
                                     Book = b.Title,
                                     Isbn13 = b.Isbn13
                                    
                                 };
                foreach (var b in storeBooks.ToList())
                {
                    bookView.Add(
                        new Book
                        {                            
                            Title = b.Book,
                            Isbn13 = b.Isbn13
                        });

                }
                bookView.Sort((x,y) => x.Title.CompareTo(y.Title));
                return bookView; 
            }
        }
        public void DeleteBook(int storeId, string isbn) 
        {
            try
            {
                using (var context = new StoreContext())
                {
                    var delete = (from book in context.Stock
                                  where book.Isbn == isbn && book.StoreId == storeId
                                  select book).FirstOrDefault();
                    if (delete != null)
                    {
                        context.Stock.Remove(delete);
                        context.SaveChanges();
                        MessageBox.Show("Update successful.");
                    }

                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                MessageBox.Show("Store doesn't have the book in stock.");
            }
        }
        public void CreateStock(int storeId, string isbn, int quantity)
        {
            try
            {
                using (var context = new StoreContext())
                {
                    var create = new Stock { Isbn = isbn, StoreId = storeId, Quantity = quantity };
                    if (create != null)
                    {
                        context.Stock.Add(create);
                        context.SaveChanges();
                        MessageBox.Show("Update successful.");
                    }

                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException) 
                {
                    MessageBox.Show("Store already has book in stock.");
                }    
       }
   }    
}




