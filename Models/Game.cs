namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string Developer {get; set;} = string.Empty;
    }

}