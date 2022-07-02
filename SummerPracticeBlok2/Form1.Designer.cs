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
            this.BigRadius = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // BigRadius
            // 
            this.BigRadius.AutoSize = true;
            this.BigRadius.Location = new System.Drawing.Point(1061, 20);
            this.BigRadius.Name = "BigRadius";
            this.BigRadius.Size = new System.Drawing.Size(137, 15);
            this.BigRadius.TabIndex = 1;
            this.BigRadius.Text = "Radius of the main circle";
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
            this.SpeedBox.Size = new System.Drawing.Size(122, 23);
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
            this.comboBox1.Location = new System.Drawing.Point(1441, 40);
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
            this.TrajectoryЕype.Location = new System.Drawing.Point(1461, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            this.Controls.Add(this.BigRadius);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label BigRadius;
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
    }
}