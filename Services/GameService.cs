using System.Linq;
using System.Security.Cryptography.X509Certificates;
using GameStore.Models;
namespace GameStore.Services;

public class GameService
{
    private readonly List<Game> games = new List<Game>
    {
        new Game
        {
            Id = 1,
            Name = "Fifa 23",
            Genre = "Sports",
            Price = 49.98m,
            ReleaseDate = new DateOnly(2022, 9, 30),
            Developer = "EA Sports"
        },
        new Game
        {
            Id = 2,
            Name = "God Of War Ragnarok",
            Genre = "ACtion RPG(Role Playing Game)",
            Price = 70.00m,
            ReleaseDate = new DateOnly(2022, 11, 9),
            Developer = "Santa Monica Studio"
        },
        new Game
        {
            Id = 3,
            Name = "Battlefield 2042",
            Genre = "First Person Shooter",
            Price = 59.99m,
            ReleaseDate = new DateOnly(2021, 11, 19),
            Developer = "DICE"
        },
        new Game
        {
            Id = 4,
            Name = "TitanFall 2",
            Genre = "First Person Shooter",
            Price = 19.99m,
            ReleaseDate = new DateOnly(2016, 10, 28),
            Developer = "Respawn Entertainment"
        },
        new Game
        {
            Id = 5,
            Name = "Tomy Clancy's Ghost Recon Wildlands",
            Genre = "Third Person Shooter",
            Price = 29.99m,
            ReleaseDate = new DateOnly(2017, 3, 7),
            Developer = "Ubisoft Paris"
        },
        new Game
        {
            Id = 6,
            Name = "Forzan Horizon 5",
            Genre = "Racing",
            Price = 59.99m,
            ReleaseDate = new DateOnly(2021, 11, 9),
            Developer = "Playground Games"
        },
        new Game
        {
            Id = 7,
            Name = "The Witcher 3: Wild Hunt",
            Genre = "Action RPG(Role Playing Game)",
            Price = 39.99m,
            ReleaseDate = new DateOnly(2015, 5, 19),
            Developer = "CD Projekt Red"
        },
        new Game
        {
            Id = 8,
            Name = "Grand Theft Auto V",
            Genre = "Action Adventure",
            Price = 29.99m,
            ReleaseDate = new DateOnly(2013, 9, 17),
            Developer = "Rockstar North"
        },
        new Game
        {
            Id = 9,
             Name = "Call of Duty: Modern Warfare II",
             Genre = "First Person Shooter",
             Price = 69.99m,
             ReleaseDate = new DateOnly(2022, 10, 28),
             Developer = "Infinity Ward"
        },
        new Game
        {
            Id = 10,
            Name = "Need for Speed: The Run",
            Genre = "Racing",
            Price = 19.99m,
            ReleaseDate = new DateOnly(2011, 11, 15),
            Developer = "Electronic Arts"
        }
    };

    public List<Game> GetGames(){
            return games;
        }
    
    public Game? GetGameById(int id)
    {
        return games.FirstOrDefault(g => g.Id == id);
    }
}
