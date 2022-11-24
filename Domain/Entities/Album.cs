
namespace Domain.Entities
{
    public class Album : Entity
    {
        public string Name { get; set; }

        public int ReleaseYear { get; set; } 

        public Album()
        {
            Name = string.Empty;
            ReleaseYear = 0;  
        }

        public Album(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }

        public Album(int id, string name, int releaseYear)
        {
            Id = id;    
            Name = name;
            ReleaseYear = releaseYear;
        }
    }
}
