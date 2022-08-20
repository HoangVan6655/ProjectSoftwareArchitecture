using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class GameBUS
    {
        public List<Game> GetAll()
        {
            List<Game> games = new GameDAO().SelectAll();
            return games;
        }
        public Game GetDetails(int GameID)
        {
            Game game = new GameDAO().SelectByCode(GameID);
            return game;
        }
        public List<Game> Search(string keyword)
        {
            List<Game> games = new GameDAO().SelectByKeyword(keyword);
            return games;
        }
        public bool AddNew(Game newGame)
        {
            bool result = new GameDAO().Insert(newGame);
            return result;
        }
        public bool Update(Game newGame)
        {
            bool result = new GameDAO().Update(newGame);
            return result;
        }
        public bool Delete(int GameID)
        {
            bool result = new GameDAO().Delete(GameID);
            return result;
        }
    }
}
