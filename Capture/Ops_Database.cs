using Dapper;
using System.Collections.Generic;
using System;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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
            string sql = string.Format("INSERT INTO [dbo].[{0}]([name]) VALUES (@name)",recordTable);

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
    }
}
