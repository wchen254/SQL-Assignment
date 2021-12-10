using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class Manage
    {
        BallRepo balls = new BallRepo();
        private void AddBall()
        {
            
            Console.Write("Enter Ball Color Red=>");
            int red = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Ball Color Green=>");
            int green = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Ball Color Blue=>");
            int blue = Convert.ToInt32(Console.ReadLine());
            Color color = new Color(red,green,blue);

            Ball ball = new Ball();
            Console.Write("Enter Id =>");
            ball.Id = Convert.ToInt32(Console.ReadLine());
            
            ball.Color = color;

            Console.Write("Enter Size =>");
            ball.Size = Convert.ToInt32(Console.ReadLine());

            if (balls.Insert(ball) > 0)
            {
                Console.WriteLine("ball has been added successfully!");
            }
            else
            {
                Console.WriteLine("Some error has occurred");
            }
        }

        private void Throw()
        {
            Console.WriteLine("Enter Id =>");
            int id = Convert.ToInt32(Console.ReadLine());
            if (balls.Throw(id) > 0)
            {
                Console.WriteLine($"ball {id} throwed successfully");
            }
            else
            {
                Console.WriteLine("Some error has occurred");
            }
        }

        private void Pop()
        {
            Console.WriteLine("Enter Id =>");
            int id = Convert.ToInt32(Console.ReadLine());
            if (balls.Pop(id) > 0)
            {
                Console.WriteLine($"ball {id} popped successfully");
            }
            else
            {
                Console.WriteLine("Some error has occurred");
            }
        }

        private void Print()
        {
            List<Ball> allBalls = balls.GetAll();
            foreach (Ball ball in allBalls)
            {
                if (ball.Size != 0)
                {
                    Console.WriteLine($"Ball {ball.Id} have been thrown {ball.timesThrown} times.");
                }
            }
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add ball");
            Console.WriteLine("Press 2 to throw a ball");
            Console.WriteLine("Press 3 to pop a ball");
            Console.WriteLine("Press 4 to print out the number of times that the balls have been thrown.");
            Console.WriteLine("Press 9 to exit");
            Console.Write("Enter choice => ");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        AddBall();
                        break;
                    case 2:
                        Throw();
                        break;
                    case 3:
                        Pop();
                        break;
                    case 4:
                        Print();
                        break;
                    case 9:
                        Console.WriteLine("Thanks for visit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option!!!");
                        break;

                }
                Console.WriteLine("Press number to continue");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
