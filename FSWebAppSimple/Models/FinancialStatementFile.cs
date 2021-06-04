using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSWebAppSimple.Models
{
    public class FinancialStatementFile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Income { get; set; }
        public int Age { get; set; }
        public HttpPostedFileBase Photo { get; set; }
    }
}