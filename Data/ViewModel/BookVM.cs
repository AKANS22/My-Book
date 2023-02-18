using System;

namespace My_Book.Data.ViewModel
{
    public class BookVM
    {
        public DateTime? DateAdded { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateRead { get; set; }
        public int Rate { get; set; }
        public string CoverUrl { get; set; }

        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }

    }
}
