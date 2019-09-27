using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.MODEL
{
    public class Cerveja
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Alcool { get; set; }
        public double Litros { get; set; }
        public double Valor { get; set; }
    }
}
