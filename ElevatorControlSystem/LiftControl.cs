using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorControlSystem
{
    internal class LiftControl
    {
        public void lift_down(PictureBox flift)
        {
            if (flift.Top <= 570)
            {
                flift.Top += 1; // elevator goes down
            }
        }

        public void lift_up(PictureBox flift)
        {
            if (flift.Top >= 107)
            {
                flift.Top -= 1; //elevator goes up
            }
        }
    }
}
