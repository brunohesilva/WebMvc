using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Repositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> musicas = new List<Musica>() {
            new Musica("No Cume", "Brega", "Falcão"),
            new Musica("Juntos e Shallow Now", "Meme", "Paula Fernandes e Luan Santana"),
            new Musica("Baba Baby", "???", "Kelly Key"),
            new Musica("Me libera", "Forró", "Banda DjaVu")
        };
    }
}