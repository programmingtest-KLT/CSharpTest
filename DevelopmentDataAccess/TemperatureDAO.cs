using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DevelopmentDataAccess
{
    public class TemperatureDAO
    {
        string connectionString;
        public TemperatureDAO(){
            connectionString = DatabaseSettings.Default.ConnectionString;
        }

    }
}
