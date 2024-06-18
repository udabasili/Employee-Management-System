using System.Data;
using System.Data.SqlClient;
namespace DBProgrammingDemo9
{
    internal class DataAccess
    {

        //private static string connectionString = ConfigurationManager.ConnectionStrings["AzureSQLConnStr"].ConnectionString;

        /// <summary>
        /// Queries a SQL Server database with a provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data</param>
        /// <returns>DataTable containing results from the provided SQL statement</returns>
        /// 
        private static string server = "hrmanager.database.windows.net";
        private static string database = "HRManagement";
        private static string username = "hrmanager";
        private static string password = "&12345qwer"; // Replace with your actual password
        private static string connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        public static DataTable GetData(string sql)
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                return dt;


            }
            //handle azure sql connection exception
            catch (SqlException ex)
            {

                throw new Exception("An error occurred while connecting to the database. Please check your internet connection and try again.", ex);

            }
            //handle general exception
            catch (Exception ex)
            {
                throw new Exception("An error occurred while connecting to the database. Please check your internet connection and try again.", ex);
            }

        }
        /// <summary>
        /// Queries a SQL Server database with a provided collection of SELECT statements.
        /// </summary>
        /// <param name="sqlStatements">The SELECT SQL Statements to execute and query data</param>
        /// <returns>DataSet containing results from the proivded SQL Statements. DataTables within the returned DataSet are in the order of the provided SQL statements</returns>
        public static DataSet GetData(string[] sqlStatements)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = string.Join(";", sqlStatements);

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        for (int i = 0; i < sqlStatements.Length; i++)
                        {
                            da.TableMappings.Add(i.ToString(), $"Data{i}");
                        }

                        da.Fill(ds);
                    }
                }
            }

            return ds;
        }

        /// <summary>
        /// Queries a SQL Server database for a scalar (single) value from the provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data for a scalar (single) value</param>
        /// <returns>The scalar value of the result of the SQL Statement execution</returns>
        public static object GetValue(string sql)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    returnValue = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Method to execute a SQL statement that does not return data (INSERT, UPDATE, DELETE)
        /// 
        /// </summary>
        /// <returns>Number of rows affected by the SQL statement</returns>
        public static int SendData(string sql)
        {
            int rowsAffected = -1;

            // TODO: Implement behaviour for executing C_UD of CRUD

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        /// <summary>
        ///     This would address two issues:
        ///     It would remove unnecessary newlines (\r\n) from the SQL statement
        ///     It would remove whitespace from the beginning and end of the SQL statement
        /// </summary>
        /// 
        public static string SQLCleaner(string sql)
        {
            // Remove all double spaces
            while (sql.Contains("  "))
            {
                sql = sql.Replace("  ", " ");

            }
            return sql.Replace(Environment.NewLine, "");
        }

        //replaces single quotes with two single quotes
        public static string SQLFix(string sql)
        {
            return sql.Replace("'", "''");
        }
    }
}
