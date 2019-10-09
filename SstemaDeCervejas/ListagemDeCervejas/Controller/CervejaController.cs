using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.MODEL;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext SistemaCervejaContext = new SistemaCervejaContext();

        public List<Cerveja> GetCervejas()
        {
            return SistemaCervejaContext.ListaDeCervejaPublica;
        }

        public void AdicionarCerveja(string nomeCerveja, double teorCerveja, double litroCerveja, double valorCerveja)
        {
            SistemaCervejaContext.ListaCerveja.Add(new Cerveja() { ID = 10, Nome = nomeCerveja, Alcool = teorCerveja, Litros = litroCerveja, Valor = valorCerveja });
        }

    }
}
