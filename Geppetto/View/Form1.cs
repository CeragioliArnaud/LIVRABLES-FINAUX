using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpriteLibrary;


namespace Project
{
    public partial class Form1 : Form
    {
        public static int speed=10;
        public bool verif = true;
        public Model model;
        public SpriteController spriteController;
        public Form1(Model model)
        {
            this.model = model;

            InitializeComponent();

            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            spriteController = new SpriteController(MainDrawingArea);
        }

        private void MainDrawingArea_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PauseMode(object sender, EventArgs e)
        {
            if (verif == true)
            {
                speed = 0;
                verif = false;
            }
            else
            {
                speed = 10;
                verif = true;
            }
        }
    }
}
