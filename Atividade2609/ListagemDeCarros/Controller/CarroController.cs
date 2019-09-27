using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext SistemaCarrosContext = new SistemaCarrosContext();
        /// <summary>
        /// Metodo que retorna a lista compeltamente completa com informações suficientes para dizer que está completa.
        /// </summary>
        /// <returns></returns>
        public List<Carro> GetCarros()
        {
            return SistemaCarrosContext.ListaCarros;
        }

    }
}
