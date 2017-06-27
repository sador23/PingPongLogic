using PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Game
{
    public class MainGame
    {
        private Ball ball;
        private Paddle player1;
        private Paddle player2;

        public MainGame()
        {

            this.ball = new Ball(10,10,10,new Position(10,20));
            this.player1 = new Paddle(10, 10, 10, new Position(10, 20),"w","s");
            this.player2 = new Paddle(10, 10, 10, new Position(10, 20),"a","d");
        }
    }
}
