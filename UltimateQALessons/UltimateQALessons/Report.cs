using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateQALessons
{
    class Report
    {
        private string name;
        private string date;
        private string type;

        // Constructor
        public Report(string name, string date, string type)
        {
            Name = name;
            Date = date;
            Type = type;
        }

        // Get/Set Accessors
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value == "July")
                {
                    date = value;
                }
            }
        }

        public string Type
        {
            get;
            set;
        }

        public void ReportType()
        {
            Console.WriteLine("This is a {0} report", Type);
            Console.ReadKey();
        }

        public string CreateReport()
        {
            return string.Format("I am creating the {0}", Name);
            Console.ReadKey();
        }

        public void ReportCount(int number)
        {
            Console.WriteLine("There is {0} lines in report", number);
            Console.ReadKey();
        }
    }
}
