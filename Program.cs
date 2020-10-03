
            using System;
            using System.Collections.Generic;
            using System.IO;
            using System.Text.RegularExpressions;


namespace countin__charecter
    {
        class Program
        {
            static void Main(string[] args)
            {

                //string loremIpsum = "my name ";
                //Console.Write("Enter a line here : ");
                string path = @"C:\Users\pmaity\Desktop\lc101\c#\practice\TextFile1.txt";
                string readText = File.ReadAllText(path);
                //string input = Console.ReadLine();
                //string loremIpsum = input;
                string loremIpsum = readText.ToUpper();
                readText = Regex.Replace(readText, "[^A-Za-z0-9]", "");
            Console.WriteLine(readText);
            loremIpsum = readText;
                char[] loremIpsumArray = loremIpsum.ToCharArray();
                Dictionary<char, int> counts = new Dictionary<char, int>();
                foreach (char c in loremIpsumArray)
                {
                    if (counts.ContainsKey(c))
                    {
                        int i = counts.GetValueOrDefault(c);
                        counts[c] = i + 1;

                    }
                    else
                    {
                        counts[c] = 1;
                    }
                }
                foreach (KeyValuePair<char, int> count in counts)
                {
                    Console.WriteLine(count.Key + " = " + count.Value);
                }
                // string readText = File.ReadAllText(path);
                // Console.WriteLine(readText);
                Console.ReadLine();
            }
        }
    }

