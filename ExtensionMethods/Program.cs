using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class Program
    {
        static DateTime Combine(this DateTime test, DateTime a)
        {
            return new DateTime
                (
                    test.Year,
                    test.Month,
                    test.Day,
                    a.Hour,
                    a.Minute,
                    a.Second
                );
        }

        static void Main(string[] args)
        {
            var ryan = DateTime.Parse("10/28/1995");
            var aaron = DateTime.Parse("12/3/1990 9:00PM");

            var combine1 = aaron.Combine(ryan);
            Console.WriteLine(combine1);
            Console.Read();
        }  
    }
}
