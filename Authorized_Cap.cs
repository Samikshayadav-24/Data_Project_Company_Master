/*
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
              //csv.Read();
              //csv.ReadHeader();
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

*/
























/*

                       / DateTime year = Convert.ToDateTime(record.DATE_OF_REGISTRATION);

                        int yr = year.Year;

                        if (yr == 2000)
                            count0++;
                        else if (yr == 2001)
                            count1++;
                        else if (yr == 2002)
                            count2++;
                        else if (yr == 2003)
                            count3++;
                        else if (yr == 2004)
                            count4++;
                        else if (yr == 2005)
                            count5++;
                        else if (yr == 2006)
                            count6++;
                        else if (yr == 2007)
                            count7++;
                        else if (yr == 2008)
                            count8++;
                        else if (yr == 2009)
                            count9++;
                        else if (yr == 2010)
                            count10++;
                        else if (yr == 2011)
                            count11++;
                        else if (yr == 2012)
                            count12++;
                        else if (yr == 2013)
                            count13++;
                        else if (yr == 2014)
                            count14++;
                        else if (yr == 2015)
                         
   count15++;
                        else if (yr == 2016)
                            count16++;
                        else if (yr == 2017)
                            count17++;
                        else if (yr == 2018)
                            count18++;
                        else if (yr == 2019)
                            count19++;


            var table1 = new ConsoleTable("Year", "Number of Registrations");
            table1.AddRow("2000", count0).AddRow("2001", count1).AddRow("2002", count2).AddRow("2003", count3)
                  .AddRow("2004", count4).AddRow("2005", count5).AddRow("2006", count6).AddRow("2007", count7)
                 .AddRow("2008", count8).AddRow("2009", count9).AddRow("2010", count10).AddRow("2011", count11)
                .AddRow("2012", count12).AddRow("2013", count13).AddRow("2014", count14).AddRow("2015", count15)
                .AddRow("2016", count16).AddRow("2017", count17).AddRow("2018", count18).
                 AddRow("2019", count19);
            table1.Write();
 */