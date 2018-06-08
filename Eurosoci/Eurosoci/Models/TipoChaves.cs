using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eurosoci.Models
{
    public class TipoChaves
    {
        [Key]
        public int ID { get; set; }  //pk

        //Descrição do Tipo de Chave
        public string Tipo { get; set; }
    }
}