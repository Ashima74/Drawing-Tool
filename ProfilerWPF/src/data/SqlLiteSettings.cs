using System;
using System.Configuration;

namespace ProfilerWPF.data
{
    class SqlLiteSettings : ISqlLiteSettings
    {
        public string GetConnectionString()
        {
            var databaseFilePath = AppDomain.CurrentDomain.BaseDirectory + "../../../../RobotSystems XS2515 - SQLite format 3.cfg";
            string fixedConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString.Replace("{DbPath}", databaseFilePath);
            return fixedConnectionString;
        }
    }

    public interface ISqlLiteSettings
    {
        string GetConnectionString( );
    }
}
