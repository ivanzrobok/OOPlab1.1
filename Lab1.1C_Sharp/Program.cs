using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1C_Sharp
{
    public class Time
    {
        private int first;
        private int second;
        public void InIt(int hour, int minutes)
        {
            if (hour <= 24 && hour >= 0 && minutes <= 60)
            {
                this.first = hour;
                this.second = minutes;
            }
            else throw new Exception();              
        }
        public void Read()
        {
            Console.WriteLine("Input miutes ");
            int firstHour = Console.Read();

            Console.WriteLine("Input miutes ");
            int secondMinutes = Console.Read();

            InIt(firstHour, secondMinutes);
        }
        public void Display()
        {
            Console.Write("In: " + first.ToString() + " hour, " + second.ToString() +" minutes -- ");
            Console.WriteLine(Minutes().ToString() + " minutes ");  
        }
        public int Minutes()
        {
            return first * 60 + second;
        }
    }

    class Program
    {
        static void Main()
        {
            var time = new Time();
            time.InIt(12, 46);
            time.Display();
            Console.WriteLine(time.Minutes());
            
        }
    }
}
