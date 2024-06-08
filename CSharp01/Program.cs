
namespace Fundamentals
{
    public enum ShipMethods
    {
        SalesMail =1,
        RegisteredUsers =2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {

            var method = ShipMethods.SalesMail;
            Console.WriteLine((Int32) method);
            string firstName = "Miles";
            string lastName = "Isaac";
            var name = string.Format("My full name is {0} {1}", firstName, lastName);

            String[] names = new string[3] { "Miles", "David", "omo" };
            Console.WriteLine(names);

            var text = @"Hi Doe
Look into the following path to see the file
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }

    }
}