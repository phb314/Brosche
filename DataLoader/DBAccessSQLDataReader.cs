using System.Data.SqlClient;

namespace DataLoader
{
    public class DBAccessSQLDataReader
    {
        private SqlDataReader m_reader;

        public DBAccessSQLDataReader(SqlDataReader reader)
        {
            m_reader = reader;
        }

        public bool Read()
        {
            if (m_reader != null && !m_reader.IsClosed)
                return m_reader.Read();

            return false;
        }

        public int GetInt32(int i)
        {
            return m_reader.GetInt32(i);
        }

        public int? GetInt32Nullable(int i)
        {
            if (!m_reader.IsDBNull(i))
                return m_reader.GetInt32(i);

            return null;
        }

        public string GetString(int i)
        {
            return m_reader.GetString(i);
        }

        public string GetStringNullable(int i)
        {
            if (!m_reader.IsDBNull(i))
                return m_reader.GetString(i);

            return null;
        }
    }
}
