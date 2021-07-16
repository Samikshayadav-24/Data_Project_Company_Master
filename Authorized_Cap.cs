using System;
using System.IO;
using CsvHelper;
using ConsoleTables;
using System.Collections.Generic;
using System.Globalization;

namespace Project1_Data_Project
{    
    public class Authorized_Cap
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;            

            var reader = new StreamReader(@"C:/Users/Samiksha/source/repos/Project1_Data_Project/Project1_Data_Project/WestBengal.csv");
            //we will not create a csv parser , we will use an existing parser available in the market.  Here in this blog, I will use csvHelper for C#.
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            { 
                    while (csv.Read())
                    {
                    //CSVReader will now read the whole file into variable
                         var record = csv.GetRecord<WestBengal>();
                        
                         double Auth_d = Convert.ToDouble(record.AUTHORIZED_CAP);

                         if (Auth_d <= 100000)
                               count1++;
                         else if (Auth_d > 100000 && Auth_d <= 1000000)
                               count2++;
                         else if (Auth_d > 1000000 && Auth_d <= 10000000)
                               count3++;
                         else if (Auth_d > 10000000 && Auth_d <= 100000000)
                               count4++;
                         else if (Auth_d > 100000000)
                              count5++;                        
                    }
            }            
            var table = new ConsoleTable("Bin", "Counts");
            table.AddRow("<=1L", count1).AddRow("1L to 10L", count2).AddRow("10L to 1Cr", count3)
                .AddRow("1Cr to 10Cr ", count4).AddRow("> 10Cr", count5);
            table.Write();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
