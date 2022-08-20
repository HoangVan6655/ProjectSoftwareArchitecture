using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameShared;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.IO;

namespace GameService
{
    public class GameDAO
    {
        string strGame = ConfigurationManager.ConnectionStrings["strGame"].ConnectionString;

        public List<Game> SelectAll()
        {
            List<Game> games = new List<Game>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM Game";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Game game = new Game()
                {
                    GameID = (int)dr["GameID"],
                    GameName = (string)dr["GameName"],
                    CategoryID = (int)dr["CategoryID"],
                    StudioID = (int)dr["StudioID"],
                    GamePrice = (int)dr["GamePrice"]
                };
                games.Add(game);
            }
            con.Close();
            return games;
        }


        public Game SelectByCode(int GameID)
        {
            Game game = null;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "SELECT * FROM Game WHERE GameID=@GameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GameID", GameID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                game = new Game()
                {
                    GameID = (int)dr["GameID"],
                    GameName = (string)dr["GameName"],
                    CategoryID = (int)dr["CategoryID"],
                    StudioID = (int)dr["StudioID"],
                    GamePrice = (int)dr["GamePrice"]
                };
            }
            con.Close();
            return game;
        }

        public List<Game> SelectByKeyword(string keyword)
        {
            List<Game> games = new List<Game>();
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "SELECT * FROM Game WHERE GameName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Game game = new Game()
                {
                    GameID = (int)dr["GameID"],
                    GameName = (string)dr["GameName"],
                    CategoryID = (int)dr["CategoryID"],
                    StudioID = (int)dr["StudioID"],
                    GamePrice = (int)dr["GamePrice"]
                };
                games.Add(game);
            }
            con.Close();
            return games;
        }

        public bool Insert(Game newGame)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "INSERT INTO Game (GameName, CategoryID, StudioID, GamePrice) VALUES (@GameName, @CategoryID, @StudioID, @GamePrice)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GameName", newGame.GameName));
            com.Parameters.Add(new SqlParameter("@CategoryID", newGame.CategoryID));
            com.Parameters.Add(new SqlParameter("@StudioID", newGame.StudioID));
            com.Parameters.Add(new SqlParameter("@GamePrice", newGame.GamePrice));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Game newGame)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            String strCom = "UPDATE Game SET GameName=@GameName, CategoryID=@CategoryID, StudioID=@StudioID, GamePrice=@GamePrice WHERE GameID=@GameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GameName", newGame.GameName));
            com.Parameters.Add(new SqlParameter("@CategoryID", newGame.CategoryID));
            com.Parameters.Add(new SqlParameter("@StudioID", newGame.StudioID));
            com.Parameters.Add(new SqlParameter("@GamePrice", newGame.GamePrice));
            com.Parameters.Add(new SqlParameter("@GameID", newGame.GameID));
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

        public bool Delete(int GameID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGame);
            con.Open();
            string strCom = "DELETE FROM Game WHERE GameID=@GameID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GameID", GameID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }
    }
}
