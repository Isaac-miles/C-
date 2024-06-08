
namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Miles";
            string lastName = "Isaac";
            var name = string.Format("My full name is {0} {1}", firstName, lastName);

            String[] names = new string[3] { "Miles", "David", "omo" };
            Console.WriteLine(names);

            var text = @"Hi Doe
Look into the following path to see
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }

    }
}