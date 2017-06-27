using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Paddle : PingPongShapes
    {
        private Dictionary<String, int> keys;
        private int score;

        public Paddle(int size, int bounds, int velocity, Position pos, String up, String down) : base(size, bounds, velocity, pos)
        {
            this.keys = new Dictionary<string, int>();
            keys.Add(up, 1);
            keys.Add(down, -1);
            score = 0;
            
        }

        public override void CollisionHandler()
        {
            throw new NotImplementedException();
        }

        public override void update()
        {
            throw new NotImplementedException();
        }
    }
}
