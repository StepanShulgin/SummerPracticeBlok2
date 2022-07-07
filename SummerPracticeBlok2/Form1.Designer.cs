namespace SummerPracticeBlok2
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BigRad = new System.Windows.Forms.Label();
            this.BigRadBox = new System.Windows.Forms.TextBox();
            this.CoordinateSystem = new System.Windows.Forms.Button();
            this.Trajectory = new System.Windows.Forms.Button();
            this.SpeedOdDraw = new System.Windows.Forms.Label();
            this.SpeedBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Shape = new System.Windows.Forms.Button();
            this.Sideofthetriangle = new System.Windows.Forms.Label();
            this.SideBox = new System.Windows.Forms.TextBox();
            this.TrajectoryЕype = new System.Windows.Forms.Label();
            this.SpeedTriangle = new System.Windows.Forms.Label();
            this.SpeedTrBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Direction = new System.Windows.Forms.Label();
            this.Numberofturns = new System.Windows.Forms.Label();
            this.TurnBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.TrajectoryLinetype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FigurerotationstepBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RippleRateBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.acur = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ZalupaBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 1016);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BigRad
            // 
            this.BigRad.AutoSize = true;
            this.BigRad.Location = new System.Drawing.Point(1061, 20);
            this.BigRad.Name = "BigRad";
            this.BigRad.Size = new System.Drawing.Size(137, 15);
            this.BigRad.TabIndex = 1;
            this.BigRad.Text = "Radius of the main circle";
            // 
            // BigRadBox
            // 
            this.BigRadBox.Location = new System.Drawing.Point(1061, 40);
            this.BigRadBox.Name = "BigRadBox";
            this.BigRadBox.Size = new System.Drawing.Size(137, 23);
            this.BigRadBox.TabIndex = 2;
            // 
            // CoordinateSystem
            // 
            this.CoordinateSystem.Location = new System.Drawing.Point(1044, 922);
            this.CoordinateSystem.Name = "CoordinateSystem";
            this.CoordinateSystem.Size = new System.Drawing.Size(154, 36);
            this.CoordinateSystem.TabIndex = 5;
            this.CoordinateSystem.Text = "Coordinate system";
            this.CoordinateSystem.UseVisualStyleBackColor = true;
            this.CoordinateSystem.Click += new System.EventHandler(this.CoordinateSystem_Click);
            // 
            // Trajectory
            // 
            this.Trajectory.Location = new System.Drawing.Point(1204, 922);
            this.Trajectory.Name = "Trajectory";
            this.Trajectory.Size = new System.Drawing.Size(154, 36);
            this.Trajectory.TabIndex = 7;
            this.Trajectory.Text = "Trajectory";
            this.Trajectory.UseVisualStyleBackColor = true;
            this.Trajectory.Click += new System.EventHandler(this.Trajectory_Click);
            // 
            // SpeedOdDraw
            // 
            this.SpeedOdDraw.AutoSize = true;
            this.SpeedOdDraw.Location = new System.Drawing.Point(1246, 22);
            this.SpeedOdDraw.Name = "SpeedOdDraw";
            this.SpeedOdDraw.Size = new System.Drawing.Size(138, 15);
            this.SpeedOdDraw.TabIndex = 8;
            this.SpeedOdDraw.Text = "Trajectory drawing speed";
            // 
            // SpeedBox
            // 
            this.SpeedBox.Location = new System.Drawing.Point(1262, 40);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(137, 23);
            this.SpeedBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Картроида",
            "Нефроида",
            "Цветочек"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Кардиоида",
            "Нефроида",
            "Цветочек"});
            this.comboBox1.Location = new System.Drawing.Point(1461, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Shape
            // 
            this.Shape.Location = new System.Drawing.Point(1364, 922);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(154, 36);
            this.Shape.TabIndex = 11;
            this.Shape.Text = "Run Shape";
            this.Shape.UseVisualStyleBackColor = true;
            this.Shape.Click += new System.EventHandler(this.Shape_Click);
            // 
            // Sideofthetriangle
            // 
            this.Sideofthetriangle.AutoSize = true;
            this.Sideofthetriangle.Location = new System.Drawing.Point(1075, 76);
            this.Sideofthetriangle.Name = "Sideofthetriangle";
            this.Sideofthetriangle.Size = new System.Drawing.Size(106, 15);
            this.Sideofthetriangle.TabIndex = 12;
            this.Sideofthetriangle.Text = "Side of the triangle";
            // 
            // SideBox
            // 
            this.SideBox.Location = new System.Drawing.Point(1061, 94);
            this.SideBox.Name = "SideBox";
            this.SideBox.Size = new System.Drawing.Size(137, 23);
            this.SideBox.TabIndex = 13;
            // 
            // TrajectoryЕype
            // 
            this.TrajectoryЕype.AutoSize = true;
            this.TrajectoryЕype.Location = new System.Drawing.Point(1474, 22);
            this.TrajectoryЕype.Name = "TrajectoryЕype";
            this.TrajectoryЕype.Size = new System.Drawing.Size(84, 15);
            this.TrajectoryЕype.TabIndex = 14;
            this.TrajectoryЕype.Text = "Trajectory type";
            // 
            // SpeedTriangle
            // 
            this.SpeedTriangle.AutoSize = true;
            this.SpeedTriangle.Location = new System.Drawing.Point(1222, 76);
            this.SpeedTriangle.Name = "SpeedTriangle";
            this.SpeedTriangle.Size = new System.Drawing.Size(212, 15);
            this.SpeedTriangle.TabIndex = 15;
            this.SpeedTriangle.Text = "The speed of movement of the triangle";
            // 
            // SpeedTrBox
            // 
            this.SpeedTrBox.Location = new System.Drawing.Point(1262, 94);
            this.SpeedTrBox.Name = "SpeedTrBox";
            this.SpeedTrBox.Size = new System.Drawing.Size(137, 23);
            this.SpeedTrBox.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Clockwise",
            "Counterclockwise"});
            this.comboBox2.Location = new System.Drawing.Point(1461, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Direction
            // 
            this.Direction.AutoSize = true;
            this.Direction.Location = new System.Drawing.Point(1452, 76);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(130, 15);
            this.Direction.TabIndex = 18;
            this.Direction.Text = "Direction of movement";
            // 
            // Numberofturns
            // 
            this.Numberofturns.AutoSize = true;
            this.Numberofturns.Location = new System.Drawing.Point(1086, 132);
            this.Numberofturns.Name = "Numberofturns";
            this.Numberofturns.Size = new System.Drawing.Size(82, 15);
            this.Numberofturns.TabIndex = 19;
            this.Numberofturns.Text = "Turning speed";
            // 
            // TurnBox
            // 
            this.TurnBox.Location = new System.Drawing.Point(1061, 150);
            this.TurnBox.Name = "TurnBox";
            this.TurnBox.Size = new System.Drawing.Size(137, 23);
            this.TurnBox.TabIndex = 20;
            this.TurnBox.TextChanged += new System.EventHandler(this.TurnBox_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Red",
            "RosyBrown",
            "Purple",
            "Pink",
            "Green"});
            this.comboBox3.Location = new System.Drawing.Point(1061, 254);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(137, 23);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Red",
            "Coral",
            "Purple",
            "Pink",
            "Green"});
            this.comboBox4.Location = new System.Drawing.Point(1262, 254);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(137, 23);
            this.comboBox4.TabIndex = 22;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.comboBox5.Location = new System.Drawing.Point(1461, 254);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 23);
            this.comboBox5.TabIndex = 23;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.comboBox6.Location = new System.Drawing.Point(1061, 199);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(137, 23);
            this.comboBox6.TabIndex = 24;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Red",
            "RosyBrown",
            "Purple",
            "Pink",
            "Green"});
            this.comboBox7.Location = new System.Drawing.Point(1262, 199);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(137, 23);
            this.comboBox7.TabIndex = 25;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // TrajectoryLinetype
            // 
            this.TrajectoryLinetype.AutoSize = true;
            this.TrajectoryLinetype.Location = new System.Drawing.Point(1075, 181);
            this.TrajectoryLinetype.Name = "TrajectoryLinetype";
            this.TrajectoryLinetype.Size = new System.Drawing.Size(109, 15);
            this.TrajectoryLinetype.TabIndex = 26;
            this.TrajectoryLinetype.Text = "Trajectory Line type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1262, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Color of the trajectory line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Shape outline color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1287, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Shape fill color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1415, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "The thickness of the contour of the figure";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.comboBox8.Location = new System.Drawing.Point(1461, 199);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 23);
            this.comboBox8.TabIndex = 31;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1452, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Trajectory Line thickness";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.comboBox9.Location = new System.Drawing.Point(1061, 309);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(137, 23);
            this.comboBox9.TabIndex = 33;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1086, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Shape Line type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1274, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Figure rotation step";
            // 
            // FigurerotationstepBox
            // 
            this.FigurerotationstepBox.Location = new System.Drawing.Point(1262, 151);
            this.FigurerotationstepBox.Name = "FigurerotationstepBox";
            this.FigurerotationstepBox.Size = new System.Drawing.Size(137, 23);
            this.FigurerotationstepBox.TabIndex = 38;
            this.FigurerotationstepBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\stepa\\OneDrive\\Изображения\\Tra.png";
            this.pictureBox2.Location = new System.Drawing.Point(1702, 751);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 207);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1099, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Pulsation";
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(1075, 393);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(55, 23);
            this.FromBox.TabIndex = 41;
            // 
            // ToBox
            // 
            this.ToBox.Location = new System.Drawing.Point(1161, 393);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(55, 23);
            this.ToBox.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1034, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "From";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1136, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "To";
            // 
            // RippleRateBox
            // 
            this.RippleRateBox.Location = new System.Drawing.Point(1270, 393);
            this.RippleRateBox.Name = "RippleRateBox";
            this.RippleRateBox.Size = new System.Drawing.Size(100, 23);
            this.RippleRateBox.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1287, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Ripple rate";
            // 
            // acur
            // 
            this.acur.FormattingEnabled = true;
            this.acur.Items.AddRange(new object[] {
            "100%",
            "50%",
            "25%",
            "10%"});
            this.acur.Location = new System.Drawing.Point(1262, 309);
            this.acur.Name = "acur";
            this.acur.Size = new System.Drawing.Size(137, 23);
            this.acur.TabIndex = 47;
            this.acur.SelectedIndexChanged += new System.EventHandler(this.acur_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1270, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "The step of the figure";
            // 
            // ZalupaBox
            // 
            this.ZalupaBox.Location = new System.Drawing.Point(1461, 309);
            this.ZalupaBox.Name = "ZalupaBox";
            this.ZalupaBox.Size = new System.Drawing.Size(121, 23);
            this.ZalupaBox.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ZalupaBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.acur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RippleRateBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FigurerotationstepBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrajectoryLinetype);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.TurnBox);
            this.Controls.Add(this.Numberofturns);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.SpeedTrBox);
            this.Controls.Add(this.SpeedTriangle);
            this.Controls.Add(this.TrajectoryЕype);
            this.Controls.Add(this.SideBox);
            this.Controls.Add(this.Sideofthetriangle);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SpeedBox);
            this.Controls.Add(this.SpeedOdDraw);
            this.Controls.Add(this.Trajectory);
            this.Controls.Add(this.CoordinateSystem);
            this.Controls.Add(this.BigRadBox);
            this.Controls.Add(this.BigRad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label BigRad;
        private TextBox BigRadBox;
        private Button CoordinateSystem;
        private Button Trajectory;
        private Label SpeedOdDraw;
        private TextBox SpeedBox;
        private ComboBox comboBox1;
        private Button Shape;
        private Label Sideofthetriangle;
        private TextBox SideBox;
        private Label TrajectoryЕype;
        private Label SpeedTriangle;
        private TextBox SpeedTrBox;
        private ComboBox comboBox2;
        private Label Direction;
        private Label Numberofturns;
        private TextBox TurnBox;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label TrajectoryLinetype;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox8;
        private Label label1;
        private ComboBox comboBox9;
        private Label label6;
        private Label label8;
        private TextBox FigurerotationstepBox;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox FromBox;
        private TextBox ToBox;
        private Label label9;
        private Label label10;
        private TextBox RippleRateBox;
        private Label label11;
        private ComboBox acur;
        private Label label12;
        private TextBox ZalupaBox;
    }
}