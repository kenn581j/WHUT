using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WHUT.Business
{
    public class DBController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WhutDB"].ConnectionString;
        public void InsertTournament(string tournamentName, string tournamentOrganizer, int numberOfRounds, string location, DateTime date, string ruleset)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTournament", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", tournamentName));
                    cmd.Parameters.Add(new SqlParameter("@TournamentOrganizer", tournamentOrganizer));
                    cmd.Parameters.Add(new SqlParameter("@NumberOfRounds", numberOfRounds));
                    cmd.Parameters.Add(new SqlParameter("@Location", location));
                    cmd.Parameters.Add(new SqlParameter("@Date", date));
                    cmd.Parameters.Add(new SqlParameter("@Ruleset", ruleset));

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw e;
                }
            }
        }

        public string GetTournament(string tournamentName)
        {
            string name = null;
            string tournamentOrganizer = null;
            string numberOfRounds = null;
            string location = null;
            string date = null;
            string ruleset = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spGetTournament", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", tournamentName));

                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            tournamentOrganizer = reader["TournamentOrganizer"].ToString();
                            numberOfRounds = reader["NumberOfRounds"].ToString();
                            location = reader["Location"].ToString();
                            date = reader["Date"].ToString();
                            ruleset = reader["Ruleset"].ToString();
                        }
                    }
                }
                catch (SqlException e)
                {
                    throw e;
                }
            }

            return (name, tournamentOrganizer, numberOfRounds, location, date, ruleset).ToString();
        }
    }
}
