using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSService.Model
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        public string name { get; set; }
        public string authorName { get; set; }
        public int categoryId { get; set; }

        [ForeignKey("categoryId")]
        public virtual Category Category { get; set; }
    }
}
