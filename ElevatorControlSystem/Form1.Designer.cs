namespace ElevatorControlSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flift = new PictureBox();
            gdoorright = new PictureBox();
            gdoorleft = new PictureBox();
            fdoorleft = new PictureBox();
            fdoorright = new PictureBox();
            wall = new PictureBox();
            leftwall = new PictureBox();
            floorimagenumber = new PictureBox();
            upwall = new PictureBox();
            midwall = new PictureBox();
            gnumshow = new PictureBox();
            downwall = new PictureBox();
            panel = new PictureBox();
            panelnumview = new PictureBox();
            first_door_open = new System.Windows.Forms.Timer(components);
            first_door_close = new System.Windows.Forms.Timer(components);
            Door_open_g = new System.Windows.Forms.Timer(components);
            Lift_up = new System.Windows.Forms.Timer(components);
            Lift_down = new System.Windows.Forms.Timer(components);
            door_close_g = new System.Windows.Forms.Timer(components);
            upbtn = new Button();
            downbtn = new Button();
            firstfloorbtn = new Button();
            gfloorbtn = new Button();
            openbtn = new Button();
            closebtn = new Button();
            automatic_door_close = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)flift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdoorright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdoorleft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fdoorleft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fdoorright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftwall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorimagenumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upwall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)midwall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gnumshow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downwall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelnumview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flift
            // 
            flift.Image = Properties.Resources.elevatorinside;
            flift.Location = new Point(220, 80);
            flift.Margin = new Padding(3, 2, 3, 2);
            flift.Name = "flift";
            flift.Size = new Size(254, 254);
            flift.SizeMode = PictureBoxSizeMode.StretchImage;
            flift.TabIndex = 1;
            flift.TabStop = false;
            // 
            // gdoorright
            // 
            gdoorright.Image = Properties.Resources.right_door;
            gdoorright.Location = new Point(352, 428);
            gdoorright.Margin = new Padding(3, 2, 3, 2);
            gdoorright.Name = "gdoorright";
            gdoorright.Size = new Size(122, 254);
            gdoorright.SizeMode = PictureBoxSizeMode.StretchImage;
            gdoorright.TabIndex = 2;
            gdoorright.TabStop = false;
            // 
            // gdoorleft
            // 
            gdoorleft.Image = Properties.Resources.left_door;
            gdoorleft.Location = new Point(220, 428);
            gdoorleft.Margin = new Padding(3, 2, 3, 2);
            gdoorleft.Name = "gdoorleft";
            gdoorleft.Size = new Size(134, 254);
            gdoorleft.SizeMode = PictureBoxSizeMode.StretchImage;
            gdoorleft.TabIndex = 3;
            gdoorleft.TabStop = false;
            // 
            // fdoorleft
            // 
            fdoorleft.Image = Properties.Resources.left_door;
            fdoorleft.Location = new Point(220, 80);
            fdoorleft.Margin = new Padding(3, 2, 3, 2);
            fdoorleft.Name = "fdoorleft";
            fdoorleft.Size = new Size(127, 254);
            fdoorleft.SizeMode = PictureBoxSizeMode.StretchImage;
            fdoorleft.TabIndex = 4;
            fdoorleft.TabStop = false;
            // 
            // fdoorright
            // 
            fdoorright.Image = Properties.Resources.right_door;
            fdoorright.Location = new Point(342, 80);
            fdoorright.Margin = new Padding(3, 2, 3, 2);
            fdoorright.Name = "fdoorright";
            fdoorright.Size = new Size(131, 254);
            fdoorright.SizeMode = PictureBoxSizeMode.StretchImage;
            fdoorright.TabIndex = 5;
            fdoorright.TabStop = false;
            fdoorright.Click += fdoorright_Click;
            // 
            // wall
            // 
            wall.Image = Properties.Resources.wall_image;
            wall.Location = new Point(479, 36);
            wall.Margin = new Padding(3, 2, 3, 2);
            wall.Name = "wall";
            wall.Size = new Size(382, 672);
            wall.SizeMode = PictureBoxSizeMode.StretchImage;
            wall.TabIndex = 6;
            wall.TabStop = false;
            wall.Click += pictureBox7_Click;
            // 
            // leftwall
            // 
            leftwall.Image = Properties.Resources.wall_image;
            leftwall.Location = new Point(10, 44);
            leftwall.Margin = new Padding(3, 2, 3, 2);
            leftwall.Name = "leftwall";
            leftwall.Size = new Size(204, 672);
            leftwall.SizeMode = PictureBoxSizeMode.StretchImage;
            leftwall.TabIndex = 7;
            leftwall.TabStop = false;
            // 
            // floorimagenumber
            // 
            floorimagenumber.Image = Properties.Resources._1st_Floor;
            floorimagenumber.Location = new Point(145, 184);
            floorimagenumber.Margin = new Padding(3, 2, 3, 2);
            floorimagenumber.Name = "floorimagenumber";
            floorimagenumber.Size = new Size(69, 40);
            floorimagenumber.SizeMode = PictureBoxSizeMode.StretchImage;
            floorimagenumber.TabIndex = 8;
            floorimagenumber.TabStop = false;
            // 
            // upwall
            // 
            upwall.Image = Properties.Resources.wall_image;
            upwall.Location = new Point(10, 2);
            upwall.Margin = new Padding(3, 2, 3, 2);
            upwall.Name = "upwall";
            upwall.Size = new Size(850, 74);
            upwall.SizeMode = PictureBoxSizeMode.StretchImage;
            upwall.TabIndex = 9;
            upwall.TabStop = false;
            // 
            // midwall
            // 
            midwall.Image = Properties.Resources.wall_image;
            midwall.Location = new Point(220, 338);
            midwall.Margin = new Padding(3, 2, 3, 2);
            midwall.Name = "midwall";
            midwall.Size = new Size(254, 85);
            midwall.SizeMode = PictureBoxSizeMode.StretchImage;
            midwall.TabIndex = 10;
            midwall.TabStop = false;
            // 
            // gnumshow
            // 
            gnumshow.Image = Properties.Resources._1st_Floor;
            gnumshow.Location = new Point(145, 524);
            gnumshow.Margin = new Padding(3, 2, 3, 2);
            gnumshow.Name = "gnumshow";
            gnumshow.Size = new Size(69, 46);
            gnumshow.SizeMode = PictureBoxSizeMode.StretchImage;
            gnumshow.TabIndex = 11;
            gnumshow.TabStop = false;
            // 
            // downwall
            // 
            downwall.Image = Properties.Resources.wall_image;
            downwall.Location = new Point(10, 686);
            downwall.Margin = new Padding(3, 2, 3, 2);
            downwall.Name = "downwall";
            downwall.Size = new Size(850, 84);
            downwall.SizeMode = PictureBoxSizeMode.StretchImage;
            downwall.TabIndex = 12;
            downwall.TabStop = false;
            // 
            // panel
            // 
            panel.Image = Properties.Resources.panelwall;
            panel.Location = new Point(479, 144);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(169, 364);
            panel.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.TabIndex = 13;
            panel.TabStop = false;
            panel.Click += panel_Click;
            // 
            // panelnumview
            // 
            panelnumview.Image = Properties.Resources.black;
            panelnumview.Location = new Point(479, 144);
            panelnumview.Margin = new Padding(3, 2, 3, 2);
            panelnumview.Name = "panelnumview";
            panelnumview.Size = new Size(169, 99);
            panelnumview.SizeMode = PictureBoxSizeMode.StretchImage;
            panelnumview.TabIndex = 14;
            panelnumview.TabStop = false;
            panelnumview.Click += panelnumview_Click;
            // 
            // first_door_open
            // 
            first_door_open.Interval = 5;
            first_door_open.Tick += first_door_open_Tick;
            // 
            // first_door_close
            // 
            first_door_close.Interval = 5;
            first_door_close.Tick += first_door_close_Tick;
            // 
            // Door_open_g
            // 
            Door_open_g.Interval = 5;
            Door_open_g.Tick += Door_open_g_Tick;
            // 
            // Lift_up
            // 
            Lift_up.Interval = 5;
            Lift_up.Tick += Lift_up_Tick;
            // 
            // Lift_down
            // 
            Lift_down.Interval = 5;
            Lift_down.Tick += Lift_down_Tick;
            // 
            // door_close_g
            // 
            door_close_g.Interval = 5;
            door_close_g.Tick += door_close_g_Tick;
            // 
            // upbtn
            // 
            upbtn.BackgroundImage = Properties.Resources.up_button;
            upbtn.BackgroundImageLayout = ImageLayout.Stretch;
            upbtn.Location = new Point(145, 574);
            upbtn.Margin = new Padding(3, 2, 3, 2);
            upbtn.Name = "upbtn";
            upbtn.Size = new Size(67, 50);
            upbtn.TabIndex = 20;
            upbtn.UseVisualStyleBackColor = true;
            upbtn.Click += upbtn_Click;
            // 
            // downbtn
            // 
            downbtn.BackgroundImage = Properties.Resources.down_button;
            downbtn.BackgroundImageLayout = ImageLayout.Stretch;
            downbtn.Location = new Point(145, 228);
            downbtn.Margin = new Padding(3, 2, 3, 2);
            downbtn.Name = "downbtn";
            downbtn.Size = new Size(67, 48);
            downbtn.TabIndex = 21;
            downbtn.UseVisualStyleBackColor = true;
            downbtn.Click += downbtn_Click;
            // 
            // firstfloorbtn
            // 
            firstfloorbtn.BackgroundImage = Properties.Resources._1st_Floor_button;
            firstfloorbtn.BackgroundImageLayout = ImageLayout.Stretch;
            firstfloorbtn.Location = new Point(531, 248);
            firstfloorbtn.Margin = new Padding(3, 2, 3, 2);
            firstfloorbtn.Name = "firstfloorbtn";
            firstfloorbtn.Size = new Size(63, 49);
            firstfloorbtn.TabIndex = 22;
            firstfloorbtn.UseVisualStyleBackColor = true;
            firstfloorbtn.Click += firstfloorbtn_Click;
            // 
            // gfloorbtn
            // 
            gfloorbtn.BackgroundImage = Properties.Resources.G_Floor_Button;
            gfloorbtn.BackgroundImageLayout = ImageLayout.Stretch;
            gfloorbtn.Location = new Point(531, 301);
            gfloorbtn.Margin = new Padding(3, 2, 3, 2);
            gfloorbtn.Name = "gfloorbtn";
            gfloorbtn.Size = new Size(63, 47);
            gfloorbtn.TabIndex = 23;
            gfloorbtn.UseVisualStyleBackColor = true;
            gfloorbtn.Click += gfloorbtn_Click;
            // 
            // openbtn
            // 
            openbtn.BackgroundImage = Properties.Resources.open_button;
            openbtn.BackgroundImageLayout = ImageLayout.Stretch;
            openbtn.Location = new Point(531, 377);
            openbtn.Margin = new Padding(3, 2, 3, 2);
            openbtn.Name = "openbtn";
            openbtn.Size = new Size(63, 46);
            openbtn.TabIndex = 24;
            openbtn.UseVisualStyleBackColor = true;
            openbtn.Click += openbtn_Click;
            // 
            // closebtn
            // 
            closebtn.BackgroundImage = Properties.Resources.close_button;
            closebtn.BackgroundImageLayout = ImageLayout.Stretch;
            closebtn.Location = new Point(531, 428);
            closebtn.Margin = new Padding(3, 2, 3, 2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(63, 46);
            closebtn.TabIndex = 25;
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // automatic_door_close
            // 
            automatic_door_close.Interval = 5;
            automatic_door_close.Tick += automatic_door_close_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(866, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(683, 563);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(929, 596);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 27;
            button1.Text = "Erase all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1068, 596);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 28;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 634);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(closebtn);
            Controls.Add(openbtn);
            Controls.Add(gfloorbtn);
            Controls.Add(firstfloorbtn);
            Controls.Add(downbtn);
            Controls.Add(upbtn);
            Controls.Add(panelnumview);
            Controls.Add(panel);
            Controls.Add(downwall);
            Controls.Add(gnumshow);
            Controls.Add(midwall);
            Controls.Add(floorimagenumber);
            Controls.Add(upwall);
            Controls.Add(leftwall);
            Controls.Add(wall);
            Controls.Add(fdoorright);
            Controls.Add(fdoorleft);
            Controls.Add(gdoorleft);
            Controls.Add(gdoorright);
            Controls.Add(flift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ElevatorControl System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)flift).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdoorright).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdoorleft).EndInit();
            ((System.ComponentModel.ISupportInitialize)fdoorleft).EndInit();
            ((System.ComponentModel.ISupportInitialize)fdoorright).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftwall).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorimagenumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)upwall).EndInit();
            ((System.ComponentModel.ISupportInitialize)midwall).EndInit();
            ((System.ComponentModel.ISupportInitialize)gnumshow).EndInit();
            ((System.ComponentModel.ISupportInitialize)downwall).EndInit();
            ((System.ComponentModel.ISupportInitialize)panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelnumview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox flift;
        private PictureBox gdoorright;
        private PictureBox gdoorleft;
        private PictureBox fdoorleft;
        private PictureBox fdoorright;
        private PictureBox wall;
        private PictureBox leftwall;
        private PictureBox floorimagenumber;
        private PictureBox upwall;
        private PictureBox midwall;
        private PictureBox gnumshow;
        private PictureBox downwall;
        private PictureBox panel;
        private PictureBox panelnumview;
        private System.Windows.Forms.Timer first_door_open;
        private System.Windows.Forms.Timer first_door_close;
        private System.Windows.Forms.Timer Door_open_g;
        private System.Windows.Forms.Timer Lift_up;
        private System.Windows.Forms.Timer Lift_down;
        private System.Windows.Forms.Timer door_close_g;
        private Button upbtn;
        private Button downbtn;
        private Button firstfloorbtn;
        private Button gfloorbtn;
        private Button openbtn;
        private Button closebtn;
        private System.Windows.Forms.Timer automatic_door_close;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}