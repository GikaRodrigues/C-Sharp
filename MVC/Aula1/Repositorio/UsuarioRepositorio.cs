using System;
using System.Collections.Generic;
using System.IO;
using Aula1.ViewModel;

namespace Aula1.Repositorio
{
    public class UsuarioRepositorio
    {
        //List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        /// <sumary>Método responsavel por armazenar um usuario</sumary>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            if (listaDeUsuarios != null)
            {
                contador = listaDeUsuarios.Count;
            }

            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;
            //insere o objeto usuario dentro da lista
            //listaDeUsuarios.Add(usuario);
            StreamWriter sw = new StreamWriter("Usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");
            sw.Close();
            
            return usuario;
        }
        /// <summary>Retorna lista de usuários</summary>
        public List<UsuarioViewModel> Listar(){//quando chamar o listar ele trará uma lista UsuarioViewModel
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists("usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");
            
            foreach (var item in usuarios)
            {
                if (item != null)
                {
                string[] dadosDeCadaUsuario = item.Split(";");
                usuarioViewModel = new UsuarioViewModel();
                usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                usuarioViewModel.Email = dadosDeCadaUsuario[2];
                usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[4]);
                listaDeUsuarios.Add(usuarioViewModel);
                }//fim if
            }
                return listaDeUsuarios;
            
        }//fim listar

        ///<sumary>Verifica se o usuário é válido</sumary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna o usuário caso ele saja encontrado ou null caso não exista</returns>

        public UsuarioViewModel BuscarUsuario(string email, string senha){

            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }
            return null;
        }
    }
}