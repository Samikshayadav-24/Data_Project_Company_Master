
using System;
using System.IO;
using CsvHelper;
using ConsoleTables;
using System.Collections.Generic;
using System.Globalization;

namespace Project1_Data_Project
{
    public class Principal_Business_Activity
    {
        static void Main(string[] args)
        {
           string ss_year = "";
           int yr = 0;
           string path = @"C:/Users/Samiksha/source/repos/Project1_Data_Project/Project1_Data_Project/WestBengal.csv";
           var reader = new StreamReader(path);
           var row = new CsvReader(reader, CultureInfo.InvariantCulture);

           Dictionary<string, int> dict = new Dictionary<string, int>();
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
                   

                 if (yr == 2015)
                   {
                      string principal_activity = v.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN;

                      if(dict.ContainsKey(principal_activity) && dict[principal_activity] != 0)
                        dict[principal_activity]++;

                      else                        
                        dict.Add(principal_activity, 1);                       
                   }
              }
         }           
          var table = new ConsoleTable("PRINCIPAL_BUSINESS_ACTIVITY", "Count in year 2015");
          foreach (var v in dict)
             table.AddRow(v.Key, v.Value);
          table.Write();
          Console.WriteLine();
          Console.ReadLine();
        }
    }
}





/*
//This is for the years 2000 to 2019
  for(int i = 2000; i <= 2019; i++)
                    {
                         string company_string = v.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN;
                         if(dict.ContainsKey(company_string) && dict[company_string] != 0)
                           dict[company_string]++;
                         else                        
                            dict.Add(company_string, 1);

                    }
 */
