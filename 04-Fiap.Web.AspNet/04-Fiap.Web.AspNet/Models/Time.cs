using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Models
{
    public class Time
    {
        [Display(Name ="Nome do time")]
        public String Nome { get; set; }
        public bool Classificado { get; set; }
        [Display(Name = "Vitórias")]
        public int Vitorias { get; set; }
        [Display(Name = "Data de fundação")]
        [DataType(DataType.Date)]
        public DateTime DataFundacao { get; set; }
        [Display(Name = "Folha de pagamento")]
        public decimal FolhaPagamento { get; set; }
    }
}
