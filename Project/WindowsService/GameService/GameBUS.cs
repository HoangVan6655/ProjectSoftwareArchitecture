using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShared;

namespace GameService
{
    public class GameBUS : MarshalByRefObject, IGameBUS
    {
        public List<Game> GetAll()
        {
            List<Game> games = new GameDAO().SelectAll();
            return games;
        }
        public Game GetDetails(int ID)
        {
            Game game = new GameDAO().SelectByCode(ID);
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
        public bool Delete(int ID)
        {
            bool result = new GameDAO().Delete(ID);
            return result;
        }

        private CategoryDAO cdao = new CategoryDAO();
        public DataSet getAllCategory()
        {
            return cdao.GetAllCategory();
        }

        private StudioDAO sdao = new StudioDAO();
        public DataSet getAllStudio()
        {
            return sdao.GetAllStudio();
        }

        
    }
}
