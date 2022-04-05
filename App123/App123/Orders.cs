using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App123
{
 public   class Orders
    {
        public void Run()
        {
            using var sr = new StreamWriter("output.txt", true);
            string[] input = File.ReadAllLines("Data.txt");

            for (int i = 0; i < input.Length; i++)
            {
                var split = input[i].Split(";");
                var ordersNumber = split[1];
                var data = split[8];
                var Trimmed = data.Replace("data=", "").Trim('{').Trim('}').Split(";");
                var BanikPico = "";

                var count = 0;

                for (int j = 0; j < Trimmed.Length; j++)
                {
                    var SplittedTrimmed = Trimmed[j].Split(",");


                    foreach (var text in SplittedTrimmed)
                    {
                        var xspl = text.Split("x");
                        count += Convert.ToInt32(xspl[0]);
                        

                    }


                }

                Console.WriteLine(ordersNumber.Trim('x') + " "  + count.ToString().Trim('x'));
                BanikPico = ordersNumber.Trim('x') + " " + count.ToString().Trim('x');
                sr.WriteLine(BanikPico);
            }
        }
    }
}
