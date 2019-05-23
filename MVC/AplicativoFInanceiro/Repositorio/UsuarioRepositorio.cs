using System;
using System.Collections.Generic;
using System.IO;
using AplicativoFInanceiro.ViewModel;

namespace AplicativoFInanceiro.Repositorio {
    public class UsuarioRepositorio {
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar ();
            if (listaDeUsuarios != null) {
                contador = listaDeUsuarios.Count;
            }

            //insere o onjeto usuario dentro da lista
            // listaDeUsuarios.Add(usuario);
            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine ($"{usuario.Nome};{usuario.DataNascimento};{usuario.Email};{usuario.Senha};");
            sw.Close ();

            return usuario;
        }
        public List<UsuarioViewModel> Listar () {
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists ("usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines ("usuarios.csv");

            foreach (var item in usuarios) {
                if (item != null) {

                    string[] dadosDeCadaUsuario = item.Split (";");
                    usuarioViewModel = new UsuarioViewModel ();
                    usuarioViewModel.Nome = dadosDeCadaUsuario[0];
                    usuarioViewModel.DataNascimento = DateTime.Parse (dadosDeCadaUsuario[1]);
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];

                    listaDeUsuarios.Add (usuarioViewModel);

                } //fim if
            }
            return listaDeUsuarios;
        } //fim listar
        public UsuarioViewModel BuscarUsuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuarios = Listar ();

            foreach (var item in listaDeUsuarios) {
                if (item.Email.Equals (email) && item.Senha.Equals (senha)) {
                    return item;
                }

            } //fim foreach
            return null;
        }
    }
}