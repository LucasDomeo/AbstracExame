using System;
using System.Globalization;
using aula146_ExercicioAbstratos.Entites.Contributor;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Base> list = new List<Base>(); 
            Console.Write("Enter the contributors number: ");
            int c = int.Parse(Console.ReadLine());

            for(int i = 0; i < c; i++)
            {
                Console.Write("Physical or company: ");
                string contributor = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual Income: ");
                double ai = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(contributor == "Physical" || contributor == "physical" || contributor == "PHYSICAL")
                {
                    Console.Write("Helth expenditures: ");
                    double helth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Physical(name, ai, helth));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int e = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Company(name, ai, e));
                }
            }

            Console.WriteLine();

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Taxes paid");

            double sum = 0.0;
            foreach (Base b in list)
            {
                double tx = b.Tax();
                Console.WriteLine($"Name: {b.Name} -- Tax: ${tx}");
                sum += tx;
            }
            Console.WriteLine();
            Console.WriteLine($"Total taxes: ${sum}");
        }
    }
}