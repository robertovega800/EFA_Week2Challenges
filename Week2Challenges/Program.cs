using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Greeter
    {
        static void Main(string[] args)


        {
            TimeOfDay2();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Hello();
            Console.ReadLine();
            //TimeOfDay1();
            GoodBye();
            Console.ReadLine();


            void Hello()
            {
            Console.WriteLine("Well hello there, " + (name) +"!");
                
            }



            void GoodBye()
            {
                Console.WriteLine("Thank you for playing " + name + "! Hit the ENTER key to close the console. Good bye!");

            }

            //void TimeOfDay1()
            //{
              //  Console.WriteLine("Hey " + name + ", do you happen to know if it's morning, afternoon, evening or night time?");
                //string time = Console.ReadLine();
                //if (time is "morning")
                //{
                   // Console.WriteLine("I hope you are having a fantastic morning!");
                //}
                //else if(time is "afternoon")
                //{
                  //  Console.WriteLine("I hope you are having a fantastic afternoon!");
                //}
                //else if(time is "evening")
                //{
                  //  Console.WriteLine("I hope you are having a fantastic evening!");
                //}
                //else if(time is "night")
                //{
                  //  Console.WriteLine("I hope you are having a fantastic night!");
                //}
                //else
                //{
                  //  Console.WriteLine("I'm not exactly sure what you mean, goodbye!");
                    //Console.Clear();
                //}
               
            //}
                
              void TimeOfDay2()
            {
                DateTime now = DateTime.Now;
                DateTime today = DateTime.Today;
                TimeSpan time = now - today;
                Console.WriteLine(time);
                Console.ReadLine();
            }  


        }


    }
}
