using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FSWebAppSimple.Models;
using System.Data.Entity;


namespace FSWebAppSimple
{
    public class FsDBContext : DbContext
    {
        public FsDBContext() : base("FsDBContext")
        {

        }
        public DbSet<FinancialStatement> FinancialStatements { get; set; }
    }
}