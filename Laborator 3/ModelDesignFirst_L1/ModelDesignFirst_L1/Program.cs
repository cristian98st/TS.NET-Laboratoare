using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TesTOneToMany();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Console.WriteLine("Introduceti numele de familie:");
                string fName = Console.ReadLine();
                Console.WriteLine("Introduceti numele mijlociu:");
                string mName = Console.ReadLine();
                Console.WriteLine("Introduceti prenumele:");
                string lName = Console.ReadLine();
                Console.WriteLine("Introduceti nuamrul de telefon:");
                string tNumber = Console.ReadLine();


                Person p = new Person()
                {
                    FirstName =fName,
                    LastName = lName,
                    MiddleName = mName,
                    TelephoneNumber = tNumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneToManyContainer1 context =
           new ModelOneToManyContainer1())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

    }
}
