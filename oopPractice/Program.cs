using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopPractice
{
    internal class Program
    {
        // 1-st task
        static bool CheckFrmt(string str)
        {
            Regex reg = new Regex(@"^\+\d\d\s\d\d\d-\d\d\d-\d\d\d$");
            return reg.IsMatch(str);
        }


        // 2-nd
        static string DecimalDigitInfo(string str)
        {
            Regex reg = new Regex(@"\d+");
            Match match = reg.Match(str);
            if (match.Success)
            {
                return $"Digit {match.Value} at position {match.Index}";
            }else { return "No digit found"; }
        }

        // litres
        static string HowManyLitres(double hours)
        {
            double litres = Math.Floor(hours * 0.5f);

            return $"time = {hours} h ----> {litres} litres";
        }

        // Светофор
        static string TrafficLights(string lightColor)
        {
            lightColor = lightColor.ToUpper().Replace(" ", "");

            switch (lightColor)
            {
                case "RED":
                    return $"Now it`s {lightColor}. Next state is YELLOW";
                case "YELLOW":
                    return $"Now it`s {lightColor}. Next state is GREEN";
                case "GREEN":
                    return $"Now it`s {lightColor}. Next state is RED";
                default:
                    return $"{lightColor} is invalid TrafficLights state!";
            }
        }

        static void Main(string[] args)
        {
            string user_str = Console.ReadLine();
            string test_str = "+35 232-032-322";
            //поменять строку в параментрах на пользовательскую!
            Console.WriteLine(CheckFrmt(test_str));

            Console.WriteLine(DecimalDigitInfo("asd43"));

            // велосипед и литры
            Console.WriteLine(HowManyLitres(11.8));

            // светофор
            Console.WriteLine("Enter current traffic light: ");
            string user_light = Console.ReadLine();
            Console.WriteLine(TrafficLights(user_light));
        }

        
    }
}
