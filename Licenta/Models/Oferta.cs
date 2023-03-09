using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Licenta.Models
{
    public class Oferta
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data inceput valabilitate")]
        public string DataInceputValabilitate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data sfarsit valabilitate")]

        public string DataSfarsitValabilitate { get; set; }

        public int? VehiculID { get; set; }
        public Vehicul? Vehicul { get; set; }

        public int? ClientID { get; set; }
        public Client? Client { get; set; }

    }
}
