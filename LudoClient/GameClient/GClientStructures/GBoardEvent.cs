using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class GBoardEvent
    {
        public GBoardData data;

        public GBoardEvent(object source, GBoardData data)
        {
            this.data = data;
        }
    }
}
