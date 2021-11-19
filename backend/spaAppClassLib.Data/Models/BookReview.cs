using System;

namespace spaAppClassLib.Data.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }

        public Book Book { get; set; }
    }
}
