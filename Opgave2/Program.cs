using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MuncipalityDbContext();
            Dataseed data = new Dataseed();
            data.SeedData();

            var test = context.addresses.Find(1);

            Console.WriteLine($"{test.street}");

        }
    }
}
