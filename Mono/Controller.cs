using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    class Controller
    {
        int turn = 0;
        public int Turn
        {
            get
            {
                turn++;
                if (turn == 1 || turn == 3)
                    return 0;
                return turn - 1;
            }
        }

        
    }
}
