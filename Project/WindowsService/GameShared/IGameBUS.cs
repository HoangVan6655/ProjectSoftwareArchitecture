using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShared
{
    public interface IGameBUS
    {
        List<Game> GetAll();
        Game GetDetails(int GameID);
        List<Game> Search(string keyword);
        bool AddNew(Game newGame);
        bool Update(Game newGame);
        bool Delete(int GameID);
        DataSet getAllCategory();
        DataSet getAllStudio();
    }
}
