using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eurosoci.Models
{
    public class Chaves
    {
        public Chaves()
        {   
            ListaNumeros = new List<Numeros>();
        }

        [Key]
        public int ID { get; set; }

        public decimal? Preco { get; set; }

        // *******************************************
        // especificação da chave forasteira
        // *******************************************

        // FK para o Tipo de Chave
        [Required]
        [ForeignKey("TipoChave")]
        public int TipoChaveFK { get; set; }
        public virtual TipoChaves TipoChave { get; set; }

        public virtual List<Numeros> ListaNumeros { get; set; }
    }
}