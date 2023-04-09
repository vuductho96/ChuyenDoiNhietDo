using System;
namespace ChuyenDoiNhietDo
{
    class Program

    {
        public static double ChuyenDoiFtoC(double f)// f là tham số tượng trưng
        {
            return (5.0 / 9.0) * (f - 32.0);
        }
        public static double ChuyenDoiCtoF(double c)// c là tham số tượng trưng để xử lý công thức
        {
            return (9.0 / 5.0) * c + 32.0;
        }

        static void Main()
    {
        int choice;
            do
            {
                Console.WriteLine("=======MENU===========");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Fahrenheit: ");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());
                        double celsius = ChuyenDoiFtoC(fahrenheit);
                        Console.WriteLine("{0} F = {1} C", fahrenheit, celsius);
                        break;

                    case 2:
                        Console.Write("Enter Celsius: ");
                        double celsius2 = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit2 = ChuyenDoiCtoF(celsius2);
                        Console.WriteLine("{0} C = {1} F", celsius2, fahrenheit2);
                        break;
                    case 0:
                        Console.WriteLine("Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);

            
        }
    }

       

    }
