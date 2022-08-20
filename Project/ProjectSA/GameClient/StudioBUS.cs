using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class StudioBUS
    {
        public List<Studio> GetAll()
        {
            List<Studio> studios = new StudioDAO().SelectAll();
            return studios;
        }
        public Studio GetDetails(int StudioID)
        {
            Studio studio = new StudioDAO().SelectByCode(StudioID);
            return studio;
        }
        public List<Studio> Search(string keyword)
        {
            List<Studio> studios = new StudioDAO().SelectByKeyword(keyword);
            return studios;
        }
        public bool AddNew(Studio newStudio)
        {
            bool result = new StudioDAO().Insert(newStudio);
            return result;
        }
        public bool Update(Studio newStudio)
        {
            bool result = new StudioDAO().Update(newStudio);
            return result;
        }
        public bool Delete(int StudioID)
        {
            bool result = new StudioDAO().Delete(StudioID);
            return result;
        }

        private StudioDAO sdao = new StudioDAO();
        public DataSet getAllStudio()
        {
            return sdao.GetAllStudio();
        }
    }
}
