using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models

{
    public class product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int categoryId { get; set; }
        //navigation property
        [ForeignKey("categoryId")]

        public category category { get; set; }
    }
}
