using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_lab_3__BookStock.Models
{
    public class Book
    {
        [Key]
        public string Isbn13 { get; set; }
        public string Title { get; set; }
    }
}
