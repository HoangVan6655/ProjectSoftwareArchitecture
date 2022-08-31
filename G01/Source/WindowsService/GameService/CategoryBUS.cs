using GameShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GameService
{
    public class CategoryBUS : MarshalByRefObject, ICategoryBUS
    {
        public List<Category> GetAll()
        {
            List<Category> categorygames = new CategoryDAO().SelectAll();
            return categorygames;
        }
        public Category GetDetails(int ID)
        {
            Category categorygame = new CategoryDAO().SelectByCode(ID);
            return categorygame;
        }
        public List<Category> Search(string keyword)
        {
            List<Category> categorygames = new CategoryDAO().SelectByKeyword(keyword);
            return categorygames;
        }
        public bool AddNew(Category newCategoryGame)
        {
            bool result = new CategoryDAO().Insert(newCategoryGame);
            return result;
        }
        public bool Update(Category newCategoryGame)
        {
            bool result = new CategoryDAO().Update(newCategoryGame);
            return result;
        }
        public bool Delete(int ID)
        {
            bool result = new CategoryDAO().Delete(ID);
            return result;
        }

        private CategoryDAO cdao = new CategoryDAO();
        public DataSet getAllCategory()
        {
            return cdao.GetAllCategory();
        }
    }
}
