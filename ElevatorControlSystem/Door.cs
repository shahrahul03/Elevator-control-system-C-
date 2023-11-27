using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorControlSystem
{
    internal class Door
    {
        public void door_open(PictureBox fdoorleft, PictureBox fdoorright,
           PictureBox gdoorleft, PictureBox gdoorright)
        {
            if (fdoorleft.Left >= 109 && fdoorright.Left <= 529)
            {
                fdoorleft.Left -= 1;
                fdoorright.Left += 1;
            }
            else if (gdoorleft.Left >= 109 && gdoorright.Left <= 529)
            {
                gdoorleft.Left -= 1;
                gdoorright.Left += 1;
            }
        }
        public void door_close(PictureBox fdoorleft, PictureBox fdoorright,
           PictureBox gdoorleft, PictureBox gdoorright)
        {
            if (fdoorleft.Left <= 250 && fdoorright.Left >= 390)
            {
                fdoorleft.Left += 1; //shifts door to right with 1 increment
                fdoorright.Left -= 1;// shifts door to left with 1 decrement

            }

            else if (gdoorleft.Left <= 250 && gdoorright.Left >= 390)
            {
                gdoorleft.Left += 1; //shifts door to right with 1 increment
                gdoorright.Left -= 1;// shifts door to left with 1 decrement
            }


        }

        


    }      

    
}
