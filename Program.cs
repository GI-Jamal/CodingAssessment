using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine the number of people aged 50 or older

            /*********** Start Of Provided Code ***********/
            WebClient client = new WebClient();

            string s = client.DownloadString("https://coderbyte.com/api/challenges/json/age-counting");
            /*********** End Of Provdided Code ***********/

            string t = s.Replace("data", "").Replace(@"""", "").Replace(@":", "").Replace(@"{", "").Replace(@"}", "").Replace(@" ", "");

            string[] strings = t.Split(',');

            int count = 0;

            for (int i = 1; i < strings.Length; i += 2)
            {
                int age = int.Parse(strings[i].Replace("age=", ""));

                if (age >= 50)
                {
                    count++;
                }

            }

            Console.WriteLine("The number of people aged 50 or older is: {0}", count);
            Console.ReadLine();
        }
    }
}
