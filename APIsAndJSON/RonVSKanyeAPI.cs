using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public static class RonVSKanyeAPI
    {
        public static void RonKanyeConvo(string weatherDesc, double currTemp)
        {

            Console.WriteLine($"It was a late, {currTemp}° night in Pawnee, Indiana with {weatherDesc}.\n");
            Thread.Sleep(3000);
            Console.WriteLine("Kanye West was in town for a meeting with Ron Swanson about how his experience in Wyoming could benefit the legislature of parks eveywhere.\n");
            Thread.Sleep(3500);
            Console.WriteLine("Their talk had concluded a couple hours ago and they went out to get some drinks on the town.\n");
            Thread.Sleep(3500);
            Console.WriteLine("In a tragic turn of events, Kanye and Ron were hit by a passing car and were rushed to the hospital.\n");
            Thread.Sleep(3500);
            Console.Write("In their anasthesia-laden state, their conversation to follow could only be something wild ");
            Thread.Sleep(3000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". \n\n");

            for (int i = 0; i < 5; i++)
            {
                var client = new HttpClient();

                var kanyeURL = "https://api.kanye.rest/";
                var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();
                var ronSwansonQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


                Console.WriteLine("Kanye: ");
                Thread.Sleep(1000);
                Console.WriteLine($"\"{kanyeQuote}\"\n");
                Thread.Sleep(2000);


                Console.WriteLine("Ron: ");
                Thread.Sleep(1000);
                Console.WriteLine($"{ronSwansonQuote}\n");
                Thread.Sleep(2000);
            }

            Console.Write("It was at this point that they both passed out . ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". \n\n");
            Console.WriteLine("They were released from the hospital the next day with some scuffs, minor injuries, and no recollection of their very crazy conversation.\n\n");
            Console.ReadKey();
        }
    }
}
