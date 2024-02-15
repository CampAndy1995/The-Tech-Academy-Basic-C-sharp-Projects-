using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class twentyOneGame : Game
    {
        public override void play()
        {
            throw new notimplementedexception();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");
            base.ListPlayers();
        }
    }

}
