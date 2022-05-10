using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using netDxf.Entities;

namespace ProfilerWPF.Services
{
    public class RSQdbo : IRSQdbo
    {
        private IFilePathGenerator _filePathGenerator;
        private IDRMHandler _drmHandler;
        private string _filepath;
        public RSQdbo(IFilePathGenerator filePathGenerator, IDRMHandler drmHandler)
        {
            _filePathGenerator = filePathGenerator;
            _drmHandler = drmHandler;
            //replace with rsq from lukes side. 
            _filepath = _filePathGenerator.GetFilePath("DXFTEMP.rsq");
        }
        public void saveDXF(string dxfdata)
        {
            //openning dblite connection
            _drmHandler.removeDRM(_filepath);
            SQLiteConnection connection = CreateConnection(_filepath);
            insertDxf(connection, Encoding.ASCII.GetBytes(dxfdata));
            connection.Close();
            _drmHandler.addDRM(_filepath);

        }

        public string loadDXF()
        {
            _drmHandler.removeDRM(_filepath);
            SQLiteConnection connection = CreateConnection(_filepath);
            Byte[] output = loadDxf(connection);
            connection.Close();
            _drmHandler.addDRM(_filepath);
            return Encoding.ASCII.GetString(output);
        }
        private static SQLiteConnection CreateConnection(String filepath)
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source="+filepath+";Version=3;New=False;Compress=False;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        private void insertDxf(SQLiteConnection connection,Byte[] input)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "Update job set jobData=(@input) where number=0";
            sqlite_cmd.Parameters.Add("@input", DbType.Binary, 20).Value = input;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.Dispose();

        }
        private Byte[] loadDxf(SQLiteConnection connection)
        {
            SQLiteCommand sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT jobData FROM job WHERE number = 0";
            List<Byte> bytelist = new List<byte>();
            
            using (var reader = sqlite_cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    byte[] buffer = GetBytes(reader);
                    bytelist.AddRange(buffer.ToList());
                }
                
            }
            sqlite_cmd.Dispose();
            return bytelist.ToArray();
        }
        
        private static byte[] GetBytes(SQLiteDataReader reader)
        {
            const int CHUNK_SIZE = 2 * 1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }
    }
}