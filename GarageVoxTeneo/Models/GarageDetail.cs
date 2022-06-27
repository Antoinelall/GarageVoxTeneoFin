using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GarageVoxTeneo.Models
{
    public class GarageDetail
    {
        public int IdGarage { get; set; }
        [DisplayName("Nom du Garage")]
        public string Name { get; set; }
        [DisplayName("Adresse")]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int MaxCarsStock { get; set; }
        public IEnumerable<Cars> Cars { get; set; }
    }
}
