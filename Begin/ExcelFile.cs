using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin
{
    internal class ExcelFile : File
    {
        // public string FileName { get; set; }
        // public int Size { get; set; }
        // public DateTime CreatedOn { get; set; }

        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report..");
        }
    }
}
