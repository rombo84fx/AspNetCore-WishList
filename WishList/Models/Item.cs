using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
