using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GameClient
{
    public class StudioDAO
    {
        string strGame = ConfigurationManager.ConnectionStrings["strGame"].ConnectionString;

        public List<Studio> SelectAll()
        {
            List<Studio> studios = new List<Studio>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM StudioGame";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Studio studio = new Studio()
                {
                    StudioID = (int)dr["StudioID"],
                    StudioName = (string)dr["StudioName"]
                };
                studios.Add(studio);
            }
            con.Close();
            return studios;
        }


        public Studio SelectByCode(int StudioID)
        {
            Studio studio = null;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "SELECT * FROM StudioGame WHERE StudioID=@StudioID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@StudioID", StudioID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                studio = new Studio()
                {
                    StudioID = (int)dr["StudioID"],
                    StudioName = (string)dr["StudioName"]
                };
            }
            con.Close();
            return studio;
        }

        public List<Studio> SelectByKeyword(string keyword)
        {
            List<Studio> studios = new List<Studio>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM StudioGame WHERE StudioName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Studio studio = new Studio()
                {
                    StudioID = (int)dr["StudioID"],
                    StudioName = (string)dr["StudioName"]
                };
                studios.Add(studio);
            }
            con.Close();
            return studios;
        }

        public bool Insert(Studio newStudio)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "INSERT INTO StudioGame (StudioName) VALUES (@StudioName)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@StudioName", newStudio.StudioName));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Studio newStudio)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "UPDATE StudioGame SET StudioName=@StudioName WHERE StudioID=@StudioID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@StudioName", newStudio.StudioName));
            com.Parameters.Add(new SqlParameter("@StudioID", newStudio.StudioID));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }

        public bool Delete(int StudioID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "DELETE FROM StudioGame WHERE StudioID=@StudioID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@StudioID", StudioID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public DataSet GetAllStudio()
        {
            SqlConnection con = new SqlConnection(strGame);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM StudioGame", con);

            try
            {
                con.Open();
                adapter.Fill(dataSet);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return dataSet;
        }
    }
}
