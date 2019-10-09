using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDb = new CelularesContextDB();

        public IQueryable<Celular> GetCelulares()
        {
            return contextDb.Celulares.Where(x => x.Ativo == true);
        }

        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDb.Celulares.FirstOrDefault(x => x.Id == item.Id);
            if (celular == null)
                return false;
            else
            {
                celular = item;
                celular.DataAlteracao = DateTime.Now;
            }

                       
            contextDb.SaveChanges();

            return true;
        }

        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0)
                return false;

            contextDb.Celulares.Add(item);
            contextDb.SaveChanges();
            return true;
        }

        public bool RemoverCelular(int id)
        {
            var celular = contextDb.Celulares.FirstOrDefault(x => x.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDb.SaveChanges();

            return true;
        }

    }
}
