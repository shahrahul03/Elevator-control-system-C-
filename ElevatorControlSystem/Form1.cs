using System.Collections.Generic;
using System.Data;

namespace ElevatorControlSystem
{
    public partial class Form1 : Form
    {

        bool lift_Groundfloor = false;
        bool lift_firstfloor = false;
        bool downto_G = false;
        bool goto_first = false;
        Door door = new Door();
        LiftControl la = new LiftControl();
        int increment = 0;
        DatabaseConn dbcon = new DatabaseConn();
        public Form1()
        {

            InitializeComponent();
        }
        public void DisplayData()
        {
            try
            {
                DatabaseConn datacmd = new DatabaseConn();
                DataTable datatable = datacmd.ViewData();
                dataGridView1.DataSource = datatable; //import data in datagrid view
                string snColumnName = "S.N";
                string dateColumnName = "Date";
                string timeColumnName = "Time";

                // Set the column width for specific columns by name
                dataGridView1.Columns[snColumnName].Width = 60;
                dataGridView1.Columns[dateColumnName].Width = 100;
                dataGridView1.Columns[timeColumnName].Width = 100;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Elevator Control System");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void up_Click(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {

        }

        private void left_door_open_Tick(object sender, EventArgs e)
        {
            if (fdoorleft.Left >= 84 && fdoorright.Left <= 425)
            {
                /* calls the  methods (door_open) of class Door to open the door
                 through the object (door).
                */
                door.door_open(fdoorleft, fdoorright, gdoorleft, gdoorright);

            }
            else
            {
                automatic_door_close.Enabled = true;
                first_door_open.Enabled = false;
                upbtn.Enabled = true;
                gfloorbtn.Enabled = true;
                firstfloorbtn.Enabled = true;
                automatic_door_close.Enabled = true;
                openbtn.BackColor = Color.White;
                firstfloorbtn.BackColor = Color.White;
                gfloorbtn.BackColor = Color.White;
                closebtn.BackColor = Color.White;
            }
        }

        private void fdoorright_Click(object sender, EventArgs e)
        {

        }

        private void down_Click(object sender, EventArgs e)
        {

        }

        private void opendoor_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            closebtn.BackColor = Color.Red;
            if (downto_G == true)
            {

                door_close_g.Enabled = true;
                Door_open_g.Enabled = false;

            }
            else if (goto_first == true)
            {

                first_door_close.Enabled = true;
                first_door_open.Enabled = false;

            }
        }

        private void downbtn_Click(object sender, EventArgs e)
        {
            downbtn.BackColor = Color.Red;
            lift_firstfloor = true;
            door_close_g.Enabled = true; //timer to close door of ground floor
            Door_open_g.Enabled = false; // timer to open door of ground floor
            downto_G = false;

            upbtn.Enabled = false;
            gfloorbtn.Enabled = false;

        }

        private void Lift_up_Tick(object sender, EventArgs e)
        {
            if (flift.Top >= 107)
            {
                la.lift_up(flift);// call method lift_up form liftcontrol 
                gfloorbtn.Enabled = false;
                upbtn.Enabled = false;





            }
            else
            {
                Lift_up.Enabled = false;
                dbcon.insert_record("lift is going up");
                DisplayData();
                first_door_open.Enabled = true;
                first_door_close.Enabled = false;
                goto_first = true;

                panelnumview.Image = global::ElevatorControlSystem.Properties.Resources._1st_Floor;
                floorimagenumber.Image = global::ElevatorControlSystem.Properties.Resources._1st_Floor;
                gnumshow.Image = global::ElevatorControlSystem.Properties.Resources._1st_Floor;


            }
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            openbtn.BackColor = Color.Red;

            if (downto_G == true)
            {
                Door_open_g.Enabled = true;
                door_close_g.Enabled = false;


            }
            else if (goto_first == true)
            {
                first_door_close.Enabled = false;
                first_door_open.Enabled = true;

            }
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            upbtn.BackColor = Color.Red;
            lift_Groundfloor = true;


            first_door_close.Enabled = true; // timer to close door of first floor
            first_door_open.Enabled = false; // timer to open door of first floor
            goto_first = false;

            downbtn.Enabled = false;
            firstfloorbtn.Enabled = false;

        }

        private void firstfloorbtn_Click(object sender, EventArgs e)
        {
            firstfloorbtn.BackColor = Color.Red;
            lift_firstfloor = true;
            downto_G = false;
            door_close_g.Enabled = true;
            Door_open_g.Enabled = false;
            upbtn.Enabled = false;
            gfloorbtn.Enabled = false;
        }

        private void gfloorbtn_Click(object sender, EventArgs e)
        {
            gfloorbtn.BackColor = Color.Red;
            firstfloorbtn.Enabled = false;
            goto_first = false;
            lift_Groundfloor = true;
            first_door_close.Enabled = true;
            first_door_open.Enabled = false;
            downbtn.Enabled = false;
        }

        private void first_door_close_Tick(object sender, EventArgs e)
        {
            if (fdoorleft.Left <= 250 && fdoorright.Left >= 390)
            {
                door.door_close(fdoorleft, fdoorright, gdoorleft, gdoorright);//call the method to cose the door of the first floor

            }
            else
            {
                automatic_door_close.Enabled = false; // timer to close door after 5 sec
                increment = 0;

                first_door_close.Enabled = false; //timer to close door of first floor
                if (goto_first == true)
                {
                    dbcon.insert_record("First Floor Door Closing"); //data inserted in database
                    DisplayData();
                }
                else
                {
                    dbcon.insert_record("First Floor Door Closing"); //data inserted in database
                    DisplayData();
                }



                closebtn.BackColor = Color.White;


                if (lift_Groundfloor == true)
                {
                    automatic_door_close.Enabled = false;
                    increment = 0;

                    panelnumview.Image = global::ElevatorControlSystem.Properties.Resources.down;
                    floorimagenumber.Image = global::ElevatorControlSystem.Properties.Resources.down;
                    gnumshow.Image = global::ElevatorControlSystem.Properties.Resources.down;
                    Lift_down.Enabled = true; //timer to move the elavator to ground floor
                    lift_Groundfloor = false;
                    closebtn.BackColor = Color.White;

                }

            }
        }

        private void first_door_open_Tick(object sender, EventArgs e)
        {
            if (fdoorleft.Left >= 109 && fdoorright.Left <= 529)
            {
                /* calls the  methods (door_open) of class Door to open the door
                 through the object (door).
                */
                door.door_open(fdoorleft, fdoorright, gdoorleft, gdoorright);

            }
            else
            {
                automatic_door_close.Enabled = true;
                first_door_open.Enabled = false;

                if (goto_first == true)
                {
                    dbcon.insert_record("First Floor Door opening"); //data inserted in database
                    DisplayData();
                }

                upbtn.Enabled = true;
                gfloorbtn.Enabled = true;
                firstfloorbtn.Enabled = true;
                automatic_door_close.Enabled = true;
                openbtn.BackColor = Color.White;
                firstfloorbtn.BackColor = Color.White;
                downbtn.BackColor = Color.White;
                closebtn.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Door_open_g_Tick(object sender, EventArgs e)
        {
            increment = 0;
            if (gdoorleft.Left >= 109 && gdoorright.Left <= 529)
            {
                door.door_open(gdoorleft, gdoorright, fdoorright, fdoorleft);
                firstfloorbtn.Enabled = true;
                downbtn.Enabled = true;
            }
            else
            {
                automatic_door_close.Enabled = true;
                Door_open_g.Enabled = false;
                if (downto_G == true)
                {
                    dbcon.insert_record("Ground Floor Door Opening");// data inserted in database
                    DisplayData();// shows database record in GUI
                }
                downbtn.Enabled = true;
                upbtn.Enabled = true;
                gfloorbtn.Enabled = true;
                upbtn.BackColor = Color.White;
                gfloorbtn.BackColor = Color.White;
                openbtn.BackColor = Color.White;
                closebtn.BackColor = Color.White;
                automatic_door_close.Enabled = true;
            }
        }

        private void door_close_g_Tick(object sender, EventArgs e)
        {
            if (gdoorleft.Left <= 250 && gdoorright.Left >= 390)
            {
                door.door_close(fdoorleft, fdoorright, gdoorleft, gdoorright);
                /* calls the  methods (door_close) of class Door to close the door
                through the object (da).
               */
            }

            else
            {
                increment = 0;
                automatic_door_close.Enabled = false;
                door_close_g.Enabled = false;
                if (downto_G == true)
                {
                    dbcon.insert_record("Ground Floor Door Closing"); //database record
                    DisplayData();// show the record in GUI
                }
                else
                {
                    dbcon.insert_record("Ground Floor Door Closing"); //database record
                    DisplayData();// show the record in GUI
                }

                closebtn.BackColor = Color.White;

                if (lift_firstfloor == true)
                {
                    panelnumview.Image = global::ElevatorControlSystem.Properties.Resources.up;
                    floorimagenumber.Image = global::ElevatorControlSystem.Properties.Resources.up;
                    gnumshow.Image = global::ElevatorControlSystem.Properties.Resources.up;
                    Lift_up.Enabled = true;// timer set to move the evelator to the  first floor
                    lift_firstfloor = false;

                }

            }
        }


        private void Lift_down_Tick(object sender, EventArgs e)
        {

            if (flift.Top <= 570)
            {
                la.lift_down(flift); // calls the method to move the elevator
                firstfloorbtn.Enabled = false;



            }
            else
            {
                dbcon.insert_record("lift is going down");
                DisplayData();



                Lift_down.Enabled = false;
                firstfloorbtn.Enabled = false;
                gfloorbtn.Enabled = true;
                downbtn.Enabled = false;



                Door_open_g.Enabled = true; //timer to open door of ground floor

                door_close_g.Enabled = false;// timer to close door of ground floor
                downto_G = true; //arrival of elevator in ground floor



                panelnumview.Image = global::ElevatorControlSystem.Properties.Resources.G_Floor;

                floorimagenumber.Image = global::ElevatorControlSystem.Properties.Resources.G_Floor;
                gnumshow.Image = global::ElevatorControlSystem.Properties.Resources.G_Floor;



            }
        }

        private void automatic_door_close_Tick(object sender, EventArgs e)
        {
            increment++;
            if (increment >= 240 && downto_G == true)
            {

                door_close_g.Enabled = true;


            }
            else if (increment >= 240 && goto_first == true)
            {

                first_door_close.Enabled = true;


            }
        }

        private void flift_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dbcon.erase();
        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void panelnumview_Click(object sender, EventArgs e)
        {

        }
    }

}