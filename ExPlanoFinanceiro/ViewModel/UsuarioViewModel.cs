using System;

namespace Ex2.ViewModel
{
    public class UsuarioViewModel
    {

        public string Nome { get; internal set; }

        public string Email {get;set;}

        public string Senha {get;set;}

        public DateTime DataCriacao { get; internal set; }
    }
}