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
            return SistemaCervejaContext.ListaCerveja;
        }
    }
}
