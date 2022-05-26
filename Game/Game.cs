using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xtreme_Tic_Tac_Toe_by_METH.Game
{
    public class Game
    {
        public State[] Tiles { get; }
        public Game()
        {
            this.Tiles = new State[9];
            for(int i = 0; i < Tiles.Length; i++)
            {
                this.Tiles[i] = State.NIL;
            }
        }
    }
}
