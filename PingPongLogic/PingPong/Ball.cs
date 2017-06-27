using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Ball : PingPongShapes
    {
        public Ball(int size, int bounds, int velocity, Position pos) : base(size, bounds, velocity, pos)
        {
        }

        public override void CollisionHandler()
        {
            Console.WriteLine("Oh no, collision detected!");
        }

        public override void update()
        {
            Console.WriteLine("I am updating this ball's position");
        }
    }
}
