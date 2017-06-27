using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public abstract class PingPongShapes : Shapes
    {

        private Position position;
        private int size;
        private int velocity;
        private int bounds;

        public PingPongShapes(int size, int bounds, int velocity, Position pos)
        {
            this.size = size;
            this.bounds = bounds;
            this.velocity = velocity;
            this.position = pos;

        }

        public abstract void CollisionHandler();
        public abstract void update();
    }
}
