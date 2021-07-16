/*
using System;
using System.IO;
using CsvHelper;
using ConsoleTables;
using System.Collections.Generic;
using System.Globalization;

namespace Project1_Data_Project
{
    public class Grouped_aggregation
    {
        static void Main(string[] args)
        {

            for (int i = 2000; i <= 2019; i++)
            {
                string path = @"C:/Users/Samiksha/source/repos/Project1_Data_Project/Project1_Data_Project/WestBengal.csv";
                var reader = new StreamReader(path);
                var row = new CsvReader(reader, CultureInfo.InvariantCulture);

                Dictionary<string, int> dict = new Dictionary<string, int>();

                string ss_year = "";
                int yr = 0;
                foreach (var v in row.GetRecords<WestBengal>())
                {
                    string Date_String = v.DATE_OF_REGISTRATION;
                    if (Date_String != "NA")
                    {
                        ss_year = Date_String.Substring(6);

                        if (ss_year.Length == 2)
                        {
                            int ii_year = Convert.ToInt32(ss_year);
                            if (ii_year >= 00 && ii_year <= 19)
                                ss_year = "20" + ss_year;       // appending year

                            yr = Convert.ToInt32(ss_year);
                        }
                        else
                        {
                            DateTime dt = Convert.ToDateTime(Date_String);
                            yr = dt.Year;
                        }
                        if (yr == i)
                        {
                            string company_string = v.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN;
                            if (dict.ContainsKey(company_string) && dict[company_string] != 0)
                               dict[company_string]++;
                            
                            else                            
                              dict.Add(company_string, 1);                            
                        }
                    }
                }
                var table = new ConsoleTable("PRINCIPAL_BUSINESS_ACTIVITY", "COUNT");
                table.AddRow(i, null);
                foreach (var v in dict)
                  table.AddRow(v.Key, v.Value);                

                table.Write();
                dict.Clear();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
*/