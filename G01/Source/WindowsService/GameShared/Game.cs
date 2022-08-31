using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShared
{
    [Serializable]
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public int CategoryID { get; set; }
        public int StudioID { get; set; }
        public int GamePrice { get; set; }
    }
}
