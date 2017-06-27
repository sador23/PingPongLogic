using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;

namespace UI
{
    public partial class Form1 : Form
    {
        private MainGame game;

        public Form1(MainGame game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
