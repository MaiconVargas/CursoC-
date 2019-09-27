using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
        public class SistemaCarrosContext
    {
        public List<Carro> ListaCarros { get; set; }

        public void CarroController()
        {
            ListaCarros = new List<Carro>();

            ListaCarros.Add(new Carro() { ID = 0, Marca = "Fiat", Modelo = "Uno", Ano = 1998, Cilindrada = 1000, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Fiat", Modelo = "Marea", Ano = 1998, Cilindrada = 2000, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Fiat", Modelo = "Marea weekend", Ano = 2000, Cilindrada = 2000, Portas = 4 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Fiat", Modelo = "Strada", Ano = 2005, Cilindrada = 1600, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Fiat", Modelo = "Mobi", Ano = 2018, Cilindrada = 1000, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "VW", Modelo = "Gol G3", Ano = 2002, Cilindrada = 1000, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "VW", Modelo = "Paratoza", Ano = 2010, Cilindrada = 1600, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Chevrolet", Modelo = "Opala", Ano = 1973, Cilindrada = 4100, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Chevrolet", Modelo = "Omega", Ano = 1998, Cilindrada = 4100, Portas = 2 });
            ListaCarros.Add(new Carro() { ID = 0, Marca = "Honda", Modelo = "Civic SI", Ano = 2010, Cilindrada = 2000, Portas = 2 });

        }


    }
}
