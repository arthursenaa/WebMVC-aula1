using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Repositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> Musicas = new List<Musica>(){
            new Musica("Juntos e Shallow Now","Paula Fernandes","Sertanejo"),
            new Musica("Hello","Adele","Pop"),
            new Musica("Baby Sharck","Capeta","Infantil"),
            new Musica("Me Refez","Priscila Alcântra","Gospel"),
            new Musica("Biridim","Maicon Jaqueson","Meme")
        };
    }
}