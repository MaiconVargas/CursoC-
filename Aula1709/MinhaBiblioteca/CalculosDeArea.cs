using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Metodo para retornar a area de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado"></param>
        /// <returns>area total do quadrado</returns>
        public double CalculaArea(int ladoDoQuadrado)
        {
            return ladoDoQuadrado * ladoDoQuadrado;
        }
    }
}
