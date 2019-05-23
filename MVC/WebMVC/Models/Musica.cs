namespace WebMVC.Models
{
    public class Musica
    {
        public Musica(string titulo, string estilo, string compositor) 
        {
            this.Titulo = titulo;
                this.Estilo = estilo;
                this.Compositor = compositor;
               
        }
                public string Titulo {get;set;}
        public string Estilo {get;set;}
        public string Compositor {get;set;}

        public Musica(){

        }

        public Musica (string titulo, string estilo, string Compositor){
            this.Titulo = titulo;
            this.Estilo = estilo;
            this.Compositor = compositor;
        }
    }
}