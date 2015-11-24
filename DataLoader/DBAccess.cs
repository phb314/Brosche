using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLoader
{
    public class DBAccess
    {
        public string constructConnectionString()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
              new System.Data.SqlClient.SqlConnectionStringBuilder();

            builder["Data Source"] = "(local)";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "CONTACT";

            Console.WriteLine(builder.ConnectionString);

            return builder.ConnectionString;
        }

        public List<IDBContact> FetchAllContacts()
        {
            List<IDBContact> dbContacts = new List<IDBContact>();

            try
            {
                using (SqlConnection connection = new SqlConnection(constructConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Select Contact.ID,Contact.NameFirst,Contact.NameLast,Contact.NameMiddle From Contact", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DBAccessSQLDataReader dbReader = new DBAccessSQLDataReader(reader);

                            while (dbReader.Read())
                            {
                                DBContact contact = new DBContact();

                                contact.ID = dbReader.GetInt32(0);
                                contact.NameFirst = dbReader.GetString(1);
                                contact.NameLast = dbReader.GetString(2);
                                contact.NameMiddle = dbReader.GetStringNullable(3);

                                dbContacts.Add(contact);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                string errorMsg = string.Format("DBAccess::FetchAllContacts - {0}", e.Message);
                throw new InvalidOperationException(errorMsg, e);
            }

            return dbContacts;
        }
    }
}
