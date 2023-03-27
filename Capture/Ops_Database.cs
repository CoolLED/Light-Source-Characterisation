using Dapper;
using System.Data;

namespace Capture
{
    internal class Ops_Database
    {
        public List<Model_Generic_Record> readMicroscopeManufacturer()
        {
            List<Model_Generic_Record> manufacturers = new();
            manufacturers = readGenericRecord("microscope_manufacturers");
            return (manufacturers);
        }
        public void writeMicroscopeManufacturer(String manufacturer)
        {
            writeGenericRecord("microscope_manufacturers", manufacturer);
        }
        public void writeLightSourceManufacturer(String manufacturer)
        {
            writeGenericRecord("light_source_manufacturers", manufacturer);
        }

        public List<Model_Generic_Record> readLightSourceManufacturer()
        {
            List<Model_Generic_Record> manufacturers = new();
            manufacturers = readGenericRecord("light_source_manufacturers");
            return (manufacturers);
        }

        public List<Model_Generic_Record> readMicroscope()
        {
            List<Model_Generic_Record> manufacturers = new();
            manufacturers = readGenericRecord("microscopes");
            return (manufacturers);
        }
        public void writeMicroscope(String manufacturer)
        {
            writeGenericRecord("microscopes", manufacturer);
        }

        private void writeGenericRecord(String recordTable, String recordName)
        {
            string sql = string.Format("INSERT INTO [dbo].[{0}]([name]) VALUES (@name)", recordTable);

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                var result = connection.Execute(sql, new
                {
                    name = recordName
                });
            }
        }
        private List<Model_Generic_Record> readGenericRecord(String recordTable)
        {
            List<Model_Generic_Record> record = new();

            string sql = String.Format("SELECT * FROM [characterisation].[dbo].[{0}] ORDER BY [name] ASC", recordTable);

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                record = (List<Model_Generic_Record>)connection.Query<Model_Generic_Record>(sql);
            }

            return record;
        }

        public void creatTable(String tableName)
        {
            String sql = String.Format("CREATE TABLE [characterisation].[dbo].[{0}]([uniqueID] [int] IDENTITY(1,1) NOT NULL," +
                "[recordDate] [datetime] NOT NULL," +
                "[recordPath] [varchar](250) NOT NULL," +
                "[backupPath] [varchar](250) NOT NULL)", tableName);

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                var r = connection.Execute(sql);
            }
        }

        public List<Model_Table_Name> readTableNames()
        {
            List<Model_Table_Name> tables = new();

            String sql = String.Format("SELECT TABLE_NAME FROM[characterisation].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                tables = (List<Model_Table_Name>)connection.Query<Model_Table_Name>(sql);
            }

            return tables;
        }

        public List<DB_Hardware> readHardwareTable(string tableName)
        {
            List<DB_Hardware> records = new();

            string sql = String.Format("SELECT * FROM [characterisation].[dbo].[" + tableName + "]");

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                records = (List<DB_Hardware>)connection.Query<DB_Hardware>(sql);
            }

            return (records);
        }

        public void addToCatalogue(Model_Table_Name tableName, DB_Hardware hardware)
        {
            string sql = "INSERT INTO [dbo].[" + tableName.TABLE_NAME + "](" +
                            "[name]" +
                            ")" +

                         "VALUES(" +
                            "@name" +
                            ");";

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    name = hardware.name
                });
            }
        }

        public void writeCharacterisationData(string tableName, DateTime timestamp, string filePath, string backupFilePath)
        {
            string sql = "INSERT INTO [dbo].[" + tableName + "](" +
                "[created_at]" +
                ",[data_Path]" +
                ",[backup_Data_Path]" +
                ")" +

             "VALUES(" +
                "@created_at," +
                "@data_Path," +
                "@backup_Data_Path" +
                ");";

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(Ops_DB_Connect.CnnVal("characterisation")))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    recordDate = timestamp,
                    recordPath = filePath,
                    backupPath = backupFilePath
                });
            }

        }
    }
}
