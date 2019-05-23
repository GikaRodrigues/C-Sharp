using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Respositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> musicas = new List<Musica>(){
            new Musica("No Cume","Brega","Falcão"),
            new Musica("Juntos e Shallow Now","Paula Fernandes e Luan Santana"),
            new Musica("Baba Baby", "???", "Kelly Key"),
            new Musica("Me Libera", "Ben 10", ""),
        };
    }
}