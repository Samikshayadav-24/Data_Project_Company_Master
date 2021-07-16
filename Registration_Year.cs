/*
using System;
using System.IO;
using CsvHelper;
using ConsoleTables;
using System.Collections.Generic;
using System.Globalization;

namespace Project1_Data_Project
{
    public class Registration_Year
    {
      static void Main(string[] args)
        {
            int year = 0;
            string s_year = "";

            string path = @"C:/Users/Samiksha/source/repos/Project1_Data_Project/Project1_Data_Project/WestBengal.csv";
            var reader = new StreamReader(path);
            var row = new CsvReader(reader, CultureInfo.InvariantCulture);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 2000; i <= 2019; i++)
            {
                dict[Convert.ToString(i)] = 0;       // initialize dict with 0   "2000" 0
            }                                       //                           "2001" 0
            //int year;
            foreach (var r in row.GetRecords<WestBengal>())
            {
                string Date_String = r.DATE_OF_REGISTRATION;
                if (Date_String != "NA")                //check whether date is in the form of NA
                {                                        //                01234567 <-indexes
                    s_year = Date_String.Substring(6);   //as date in form 02-04-15   60-09-06
                    
                    if (s_year.Length == 2)
                    {
                        int i_year = Convert.ToInt32(s_year);
                        if (i_year >= 00 && i_year <= 19)
                            s_year = "20" + s_year;       // appending year

                        year = Convert.ToInt32(s_year);
                    }
                    else
                    {
                        DateTime dt = Convert.ToDateTime(Date_String);
                        year = dt.Year;  //yy-mm-dd     dd-mm-yy          //getting year value
                    }

                    if (year >= 2000 && year <= 2019)                     
                        dict[Convert.ToString(year)]++;                    //incrementing its count
                }
            }
            var table = new ConsoleTable("Year", "No Of Registrations");
            for (int i = 2000; i <= 2019; i++)
            {
                table.AddRow(i, dict[Convert.ToString(i)]);
            }
            table.Write();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

           
 */       


