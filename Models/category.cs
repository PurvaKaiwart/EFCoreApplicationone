using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class category
    {
        internal static int categoryId;

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        //Navigation property
        public ICollection <product> products { get; set; }
    }


}
