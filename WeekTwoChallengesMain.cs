using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting
            Greeter person1 = new Greeter();
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            string greeting = person1.HelloName(name);
            Console.WriteLine(greeting);
            Console.WriteLine(person1.GreetTime());

            //Farewell
            Greeter person2 = new Greeter();
            Console.WriteLine("Are you leaving? yes or no");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "yes":
                    string farewell = person2.FarewellName(name);
                    Console.WriteLine(farewell);
                    break;

                case "no":
                    Console.WriteLine("Oh, hang around then");
                    break;

                default:
                    Console.WriteLine("I did not understand that");
                    break;
            }
            Console.ReadLine();
        }
    }

    public class Greeter
    {

        public string HelloName(string name)
        {
            string hello = "Hello" + " " + name;
            return hello;
        }
        
        public string GreetTime()
        {
           DateTime greeting = DateTime.Now;
            
            
            if(greeting.Hour >= 3 && greeting.Hour < 12)
            {
                string greet = "Good Morning";
                return greet;
            }
            else if (greeting.Hour >= 12 && greeting.Hour < 16)
            {
                string greet = "Good Afternoon";
                return greet;
            }
            else if (greeting.Hour >= 16 && greeting.Hour < 20)
            {
                string greet = "Good Evening!";
                return greet;
            }
            else 
            {
               string greet = "Good Night.";
               return greet;
            }
            
        }
        public string FarewellName(string name)
        {
            string goodBye = "Fare thee well " + name;
            return goodBye;
        }
    }
}
