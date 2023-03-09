using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Remoting.Messaging;

namespace DataBaseLayer
{
    public class DBLayer
    {
        public string[] GetAllText()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCMS"].ConnectionString;
            DataTable dt = new DataTable();
            //må defineres her for å kunne bruke et for senere array
            string content = "";
            string content2 = "";
            string content3 = "";
            string[] contentArray = new string[3];
            //string content4 = "";
            //string content5 = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Content", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //lar deg hente flere forskjellige tekster i en modul ved å putte dem i en array
                    content = (string)reader["Text1"];
                    content2 = (string)reader["Text2"];
                    content3 = (string)reader["Text3"];
                    //content4 = (string)reader["Text4"];
                    //content5 = (string)reader["Text5"];
                }
                dt.Load(reader);

                reader.Close();
                conn.Close();

                contentArray[0] = content;
                contentArray[1] = content2;
                contentArray[2] = content3;

                return contentArray;
            }
        }

        public void UpdateText(string text, string slot)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCMS"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Content SET [" + slot + "]=@param where id=1", conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@param", SqlDbType.NVarChar);
                param.Value = text;
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
        }

        public void ResetPassword(string userName, string passWord)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCMS"].ConnectionString;
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LogIn SET Password = @pw WHERE (Email = @un)");

                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = userName;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@pw", SqlDbType.NVarChar);
                param.Value = passWord;
                cmd.Parameters.Add(param);

                conn.Close();
            }
        }
            public int GetAllFromLogIn(string userName, string passWord)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCMS"].ConnectionString;
            SqlParameter param;
            int count = 0;//either 0 or 1. 1 if user exists
            string sqlCmd = "";

            sqlCmd = "select count(id)as num from LogIn where Email=@un and Password=@pw";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = userName;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@pw", SqlDbType.NVarChar);
                param.Value = passWord;
                cmd.Parameters.Add(param);

                count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count;
            }
        }
    }
}
