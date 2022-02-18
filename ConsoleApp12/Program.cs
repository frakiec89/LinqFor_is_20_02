using System;
using System.Linq;
namespace ConsoleApp12
{
    internal class Program 
    {
        static void Main(string[] args)
        {
         UserController controller = new UserController();

            Console.WriteLine("Пользователи старше 18 лет:");

            controller.Users.Where (x=> x.Age >= 18).
                OrderBy(x=>x.Name).
                ToList().
                ForEach (x => Console.WriteLine (x));

        }
    }


    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Имя -  {Name}, Возраст - {Age}";
        }

    }
}
