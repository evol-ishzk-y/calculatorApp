using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace calculatorApp
{
    internal class DatabaseHelper
    {
        private string connString = "Host=localhost; Port=5432; Username=postgres; Password=password123; Database=my_calculator_db";
    }
}
