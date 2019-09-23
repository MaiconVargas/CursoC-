using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class UsuarioController
    {
        public UsuarioController()
        {
            Usuario = new List<Usuario>
            {
                new Usuario()
                {
                     Login ="Admin",Senha="Admin"
                },
                new Usuario()
                {
                    Login ="Teste",Senha="123"
                }
            };
        }

        public List<Usuario> Usuario { get; set; }
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha Admin
        /// </summary>
        /// <param name="login">Login do usuário dentro do sistema</param>
        /// <param name="senha">Senha do usuário dentro do sistema</param>
        /// <returns>Retorna verdadeiro se existir um usuario com login e senha</returns>
        public bool LoginSistema(Usuario usuario)
        {
            return Usuario.Exists(i => i.Login == usuario.Login && i.Senha == usuario.Senha);
            //if (usuario.Login == "Admin" && usuario.Senha == "Admin")
            //{
            //    return true;
            //}
            //{
            //    return false;
            //}
        }
        
    }
}
