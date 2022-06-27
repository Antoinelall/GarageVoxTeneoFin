using System.ComponentModel.DataAnnotations;

namespace GarageVoxTeneo.Models
{
    public class GaragesForm
    {
        public int IdGarage { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int MaxCarsStock { get; set; }
    }
}
