using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class BooksVM
    {
        public int Id { get; set; }
        //[Required]
        public string Title { get; set; }
        //[Required]

        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        //[Required]

        public string Genre { get; set; }
        //[Required]

        public string Author { get; set; }
        //[Required]

        public string CoverUrl { get; set; }
    }
}
