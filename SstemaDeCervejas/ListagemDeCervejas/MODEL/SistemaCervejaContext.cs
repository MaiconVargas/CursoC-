using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.MODEL
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaCerveja { get; set; }

        public SistemaCervejaContext()
        {
            ListaCerveja = new List<Cerveja>();

            ListaCerveja.Add(new Cerveja() { ID = 0, Nome = "Skol      ", Alcool = 4.7, Litros = 0.355, Valor = 2.99 });
            ListaCerveja.Add(new Cerveja() { ID = 1, Nome = "BudWaisser", Alcool = 5, Litros = 0.366, Valor = 3.99 });
            ListaCerveja.Add(new Cerveja() { ID = 2, Nome = "Corona    ", Alcool = 4.6, Litros = 0.350, Valor = 4.75 });
            ListaCerveja.Add(new Cerveja() { ID = 3, Nome = "Original  ", Alcool = 5, Litros = 0.660, Valor = 6 });
            ListaCerveja.Add(new Cerveja() { ID = 4, Nome = "Skol beats", Alcool = 8, Litros = 0.366, Valor = 3.49 });

        }
        public List<Cerveja> ListaDeCervejaPublica { get { return ListaCerveja; } }

      
    }
}
