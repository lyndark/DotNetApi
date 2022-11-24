
namespace Domain.Entities
{
    public class Artiste : Entity
    {
        public string Name { get; set; }

        public string MusicGenre { get; set; }

        public Artiste()
        {
            Name= string.Empty; 
            MusicGenre= string.Empty;   
        }

        public Artiste(string name, string musicGenre)
        {
            Name=name;
            MusicGenre=musicGenre;  
        }
        public Artiste(int id, string name, string musicGenre)
        {
            Id=id;
            Name = name;
            MusicGenre = musicGenre;
        }
    }
}
