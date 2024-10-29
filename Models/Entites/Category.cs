using System.ComponentModel.DataAnnotations;

namespace Cascading.Core.Models.Entites
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
