using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoPart2
{

    public class VideoGames
    {
        private string name;
        private string category;

        public VideoGames(string aName, string aCategory)
        {
            name = aName;
            category = aCategory;
        }

        public string Name
        {
            get { return name; }
        }

        public string Category
        {
            get { return category;  }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VideoGames> myGames = new List<VideoGames>();

            myGames.AddRange(new VideoGames[]
            {
                new VideoGames("Halo", "FPS"),
                new VideoGames("Modern Warefare", "FPS"),
                new VideoGames("Supreme Commander", "RTS"),
                new VideoGames("Chivarly 2", "Action, Fighter")

            });

            foreach (var game in myGames.FindAll(g => g.Category == "FPS" ))
                Console.WriteLine($"Name: {game.Name}, Category: {game.Category}");

            Console.WriteLine("-------------------------");

            foreach (var game in myGames.ToList())
                Console.WriteLine($"Name: {game.Name}, Category: {game.Category}");

            Console.ReadLine();
        }


        
    }
}
