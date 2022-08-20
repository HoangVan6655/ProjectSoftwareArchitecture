using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class CategoryDAO
    {
        string strGame = ConfigurationManager.ConnectionStrings["strGame"].ConnectionString;

        public List<Category> SelectAll()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM CategoryGame";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Category category = new Category()
                {
                    CategoryID = (int)dr["CategoryGameID"],
                    CategoryName = (string)dr["CategoryGameName"]
                };
                categories.Add(category);
            }
            con.Close();
            return categories;
        }


        public Category SelectByCode(int CategoryGameID)
        {
            Category category = null;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "SELECT * FROM CategoryGame WHERE CategoryGameID=@CategoryGameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryGameID", CategoryGameID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                category = new Category()
                {
                    CategoryID = (int)dr["CategoryGameID"],
                    CategoryName = (string)dr["CategoryGameName"]
                };
            }
            con.Close();
            return category;
        }

        public List<Category> SelectByKeyword(string keyword)
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM CategoryGame WHERE CategoryGameName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Category category = new Category()
                {
                    CategoryID = (int)dr["CategoryGameID"],
                    CategoryName = (string)dr["CategoryGameName"]
                };
                categories.Add(category);
            }
            con.Close();
            return categories;
        }

        public bool Insert(Category newCategory)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "INSERT INTO CategoryGame (CategoryGameName) VALUES (@CategoryGameName)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryGameName", newCategory.CategoryName));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Category newCategory)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "UPDATE CategoryGame SET CategoryGameName=@CategoryGameName WHERE CategoryGameID=@CategoryGameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryGameName", newCategory.CategoryName));
            com.Parameters.Add(new SqlParameter("@CategoryGameID", newCategory.CategoryID));
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

        public bool Delete(int CategoryGameID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "DELETE FROM CategoryGame WHERE CategoryGameID=@CategoryGameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryGameID", CategoryGameID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public DataSet GetAllCategory()
        {
            SqlConnection con = new SqlConnection(strGame);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CategoryGame", con);

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
