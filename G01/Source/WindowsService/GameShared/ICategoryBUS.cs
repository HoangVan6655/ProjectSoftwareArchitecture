using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShared
{
    public interface ICategoryBUS
    {
        List<Category> GetAll();
        Category GetDetails(int CategoryID);
        List<Category> Search(string keyword);
        bool AddNew(Category newCategory);
        bool Update(Category newCategory);
        bool Delete(int CategoryID);
        DataSet getAllCategory();
    }
}
