using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xtreme_Tic_Tac_Toe_by_METH.Game
{
    /// <summary>
    /// An abstract representation of a tic tac toe game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The tiles of the game, reperesenting if a certain box is X, O or empty(NIL)
        /// </summary>
        /// Structure is supposed to represent(by index):
        /// 0 1 2
        /// 3 4 5
        /// 6 7 8
        public State[] Tiles { get; }
        public Game()
        {
            //Set all tiles as empty(NIL)
            this.Tiles = new State[9];
            for(int i = 0; i < Tiles.Length; i++)
            {
                this.Tiles[i] = State.NIL;
            }
        }
    }
}
