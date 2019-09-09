using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Corrida
    {
        public int CorridaId { get; set; }
        public String Nome { get; set; }
        public float Distancia { get; set; }
        public bool Premiacao { get; set; }
        public Categoria Categoria { get; set; }
    }
}
