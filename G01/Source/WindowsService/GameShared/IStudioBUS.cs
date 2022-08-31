using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShared
{
    public interface IStudioBUS
    {
        List<Studio> GetAll();
        Studio GetDetails(int StudioID);
        List<Studio> Search(string keyword);
        bool AddNew(Studio newStudio);
        bool Update(Studio newStudio);
        bool Delete(int StudioID);
        DataSet getAllStudio();
    }
}
