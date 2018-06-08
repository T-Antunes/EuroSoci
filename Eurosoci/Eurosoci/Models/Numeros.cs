using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eurosoci.Models
{
    public class Numeros
    {
        public Numeros()
        {
            ListaChaves = new HashSet<Chaves>();
        }

        [Key]
        public int ID { get; set; }

        public int Valor { get; set; }

        public bool EEstrela { get; set; }

        public virtual ICollection<Chaves> ListaChaves { get; set; }
    }
}