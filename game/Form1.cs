using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();

        private void btnSpin_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\aman banwait\source\repos\game\New folder\Chambering A Round-SoundBible.com-854171848 (1).wav");
                splayer.Play();
            }

            if (x > 0)
            {

                pictureBox2.ImageLocation = @"C:\Users\aman banwait\source\repos\game\New folder/3.jpg";
            }
            else
            {
                MessageBox.Show("Please Click on Load Bullet First");
            }
        }
        private int value()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            return random;

        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                pictureBox1.ImageLocation = @"C:\Users\aman banwait\source\repos\game\New folder\1.jpg";
                if (y == z && cunt < 2)
                {
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\aman banwait\source\repos\game\New folder\gun-gunshot-01.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                    MessageBox.Show("Game Over Bullets Finished");
                    btnShot.Enabled = false;
                }
            }

        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnShot.Enabled = true;
            pictureBox1.ImageLocation = @"C:\Users\aman banwait\source\repos\game\gun.jpg";
            pictureBox2.ImageLocation = @"C:\Users\aman banwait\source\repos\game\chamber.jpg";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\aman banwait\source\repos\game\New folder\its-not-that-easy.wav");
            splayer.Play();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\aman banwait\source\repos\game\New folder\gun-cocking-01.wav");
            splayer.Play();
            x = x + 1;
            if (x == 1)
            {

                pictureBox1.ImageLocation = @"C:\Users\aman banwait\source\repos\game\New folder\4.jpg";

            }
        }
    }
}
