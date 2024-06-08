using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Program_Assignment
{
    public struct Profile
    {

        public string firstName;
        public string lastName;
        public string interest;

    }
    internal class Program
    {
        static void start()
        {
            Console.WriteLine(@"







                                                            ___                     _       _      _  _              ___                      _   
                                                           | __|  __ _    _ __     (_)     | |    | || |    o O O   | __|   ___    _  _    __| |  
                                                           | _|  / _` |  | '  \    | |     | |     \_, |   o        | _|   / -_)  | +| |  / _` |  
                                                          _|_|_  \__,_|  |_|_|_|  _|_|_   _|_|_   _|__/   TS__[O]  _|_|_   \___|   \_,_|  \__,_|  
                                                        _| """""" |_|""""""""""|_|""""""""""|_|""""""""""|_|""""""""""|_| """"""""| {======|_| """""" |_|""""""""""|_|""""""""""|_|""""""""""| 
                                                        ""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'./o--000'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-' 


                                  ".PadLeft(50).PadRight(50));
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            Console.Write("".PadLeft(50).PadRight(50));
            Console.WriteLine(@" 
                                                                                                           .----------------. 
                                                                                                          | .--------------. |
                                                                                                          | |    ______    | |
                                                                                                          | |   / ____ `.  | |
                                                                                                          | |   `'  __) |  | |
                                                                                                          | |   _  |__ '.  | |
                                                                                                          | |  | \____) |  | |
                                                                                                          | |   \______.'  | |
                                                                                                          | |              | |
                                                                                                          | '--------------' |
                                                                                                          '----------------' ".PadLeft(6050));
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("".PadLeft(50).PadRight(50));
            Console.WriteLine(@" 
                                                                                                           .----------------. 
                                                                                                          | .--------------. |
                                                                                                          | |    _____     | |
                                                                                                          | |   / ___ `.   | |
                                                                                                          | |  |_/___) |   | |
                                                                                                          | |   .'____.'   | |
                                                                                                          | |  / /____     | |
                                                                                                          | |  |_______|   | | 
                                                                                                          | |              | |
                                                                                                          | '--------------' |
                                                                                                           '----------------' ".PadLeft(6050));
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("".PadLeft(50).PadRight(50));
            Console.WriteLine(@" 
                                                                                                           .----------------. 
                                                                                                          | .--------------. |
                                                                                                          | |     __       | |
                                                                                                          | |    /  |      | |
                                                                                                          | |    `| |      | |
                                                                                                          | |     | |      | |
                                                                                                          | |    _| |_     | |
                                                                                                          | |   |_____|    | |
                                                                                                          | |              | |
                                                                                                          | '--------------' |
                                                                                                           '----------------' ".PadLeft(6050));
            Thread.Sleep(1000);
            return;

        }
        static void Main(string[] args)
        {
            //Makes the Animation of the Game...
            start();
            Console.Clear();
            //Method to Show the users Information
            Users();
            Console.ReadLine();
        }
        static void Menu()
        {


            int Task;

            bool endTask = false;

            Console.WriteLine("Satrt Enter to Start the Game");

            do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Select the option from below:\nThe menu options are:\n1  Players List\n2  Edit Players List\n3  Start the game\n4  Task 4\n0  Exit menu\n");
                Task = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (Task)

                {

                    case 0:
                        endTask = true;
                        break;

                    case 1:
                        players();
                        break;

                    case 2:
                        editPlayer();
                        break;

                    case 3:
                        gameStart();
                        break;

                    case 4:
                        finalist();
                        break;
                }
                if (endTask == true)

                {
                    Console.WriteLine("Thank's For Playing\nSee you next Time.");
                }

            }

            while (endTask != true);

            Console.ReadLine();
            
        }
        public static void players()

        {

            Console.WriteLine("it is the Task1");

        }

        public static void editPlayer()

        {

            Console.WriteLine("it is the Task2");

        }

        public static void gameStart()

        {

            Console.WriteLine("it is the Task3");

        }

        public static void finalist()

        {

            Console.WriteLine("it is the Task4");

        }

        //Method for User Details
        static void Users()
        {
            Profile[] details = new Profile[27];
            Console.ReadLine();
        }
    }
}
   
