using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSService.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string name { get; set; }
        public int parentId { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
