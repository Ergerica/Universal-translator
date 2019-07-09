using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Universal_translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Path");
            string dir = Console.ReadLine();
            List<string> toConvert = ReadFile(dir);
            List<string> converted = new List<string>();
            foreach (string conversion in toConvert)
            {
                int stepCount = 1;
                double numberToConvert = 0;
                string from = "", to = "";
                string temp = "";
                for (int place = 0; place < conversion.Length; place++)
                {

                    if (conversion[place] == ' ' && stepCount == 1)
                    {
                        numberToConvert = double.Parse(temp);
                        temp = "";
                        stepCount++;

                    }
                    if (conversion[place] == ' ' && stepCount == 2)
                    {
                        from = temp;
                        temp = "";
                    }
                    if((place + 1) == conversion.Length)
                    {
                        temp+=conversion[place];
                       
                        to = temp;
                    }
                    else if(conversion[place]!=' ')
                        temp += conversion[place];   

                }
        
                converted.Add(Convert(numberToConvert, from, to));
               // Console.WriteLine(Convert(numberToConvert, from, to));
            }

             Console.WriteLine("Write path where you want the files with the answers to be written on");
             string writeDir = Console.ReadLine();
             File.WriteAllLines(writeDir,converted);


        }
       
        public static string Convert(double numberToConvert, string from, string to)
        {
            double convertedNum = numberToConvert; // this is done in case of the conversion being equal
            if (from == "KM")
            {
                if (to == "M")
                {
                    convertedNum = (double)numberToConvert * 1000;
                }
                if (to == "CM")
                {
                    convertedNum =  (double)(numberToConvert * 100000);
                }
            }
            if (from == "M")
            {
                if (to == "KM")
                {
                    convertedNum = (double) (numberToConvert / 1000);
                }
                if (to == "CM")
                {
                    convertedNum = (double) (numberToConvert * 100);
                }
            }
            if (from == "CM")
            {
                if (to == "KM")
                {
                    convertedNum =  (double)(numberToConvert / 100000);
                }
                if (to == "M")
                {
                    convertedNum = (double) (numberToConvert / 100);
                }
            }
            
            string answer = numberToConvert.ToString() + " " + from + " " + to + " " + convertedNum.ToString();
            return answer;
        }
        public static List<string> ReadFile(string dir)
        {
            List<string> Conversions;
            Conversions = new List<string>(File.ReadAllLines(dir));
            return Conversions;

        }
    }
}
