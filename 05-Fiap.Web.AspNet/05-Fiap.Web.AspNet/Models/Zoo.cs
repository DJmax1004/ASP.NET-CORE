using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Zoo
    {
        public int Jaulas { get; set; }
        public DateTime DataAbertura { get; set; }
        public String Nome { get; set; }
        public Tipo EntidadeAdministradora { get; set; }
        
    }

}
