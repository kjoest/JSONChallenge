using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Kyle";
            person.LastName = "Joest";
            person.DOB = new DateTime(1992, 12, 17);
            person.FavoriteIceCreamFlavors = new List<string>
            { "Chocolate", "Cookie Dough" };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
