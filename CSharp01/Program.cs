
namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Seasons seasons = Seasons.Rainy;

            switch (seasons)
            {
                case Seasons.Rainy:
                    Console.WriteLine("Its Raining Season already");
                    break;
                case Seasons.Hamattan:
                    Console.WriteLine("Na Hamatan Jare");
                    break;
                default:
                    Console.WriteLine("No Match found try again");
                    break;
            }
        }
    }
}