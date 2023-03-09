using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Licenta.Models
{
    public class TipCombustibil
    {
        public int ID { get; set; }
        [Display(Name = "Tipul de combustibil")]
        [RegularExpression(@"(benzina|motorina|hibrid|electric)$", ErrorMessage = "Tipul de combustibil poate fi benzina, motorina, hibrid sau electric")]

        public string TipulCombustibil { get; set; }
        public ICollection<Vehicul>? Vehicule { get; set; }
    }
}
