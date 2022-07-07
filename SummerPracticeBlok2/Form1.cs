using System.ComponentModel;

namespace SummerPracticeBlok2
{
    public partial class Form1 : Form
    {
        int indexSys;       
        int indexTrajectory;
        int indexShape;
        int BidRadius = 200;
        int SmallRadius = 100;
        int Speed = 0;
        int ShapeSpeed = 0;
        int type = 1;
        double side = 10;
        int direct = 0;
        int turn = 0;
        double Step = 0.1;
        double angleTurn = 0;
        double angleStat = 0;
        double cheack = 0;
        int firstCheak = 1;
        int secondCheak = 0;
        double difference = 0;
        int acu = 1;
        int counter = 0;
        int SpeedOfPulse = 20;
        int zalupa = 1;
       
        Point[] p;
              
        Brush fill= new SolidBrush(Color.Coral);
        Pen TrajectoryPen = new Pen(Color.Red, 2);
        Pen ShapePen = new Pen(Color.Green, 2);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += PictureBox1_Paint;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Print_System(PaintEventArgs e)
        {
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            DrawXAxis(new Point(-w, 0), new Point(w, 0), e.Graphics);
            DrawYAxis(new Point(0, h), new Point(0, -h), e.Graphics);

        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            e.Graphics.TranslateTransform(w, h);
            if (indexShape == 1)
            {
                Print_Trajectory(e);
                Print_Triangle(e);
            }

            if (indexSys == 1)
            {


                Print_System(e);


            }
                        
            if (indexTrajectory == 1)
            {
                Print_Trajectory(e);
            }


        }
        private void Print_Trajectory(PaintEventArgs e)
        {
            int Hypotenuse = (int)(BidRadius / 2) + (int)(SmallRadius / 2);
            double StartAlfa = 0, LastT = 6.3; // оборот в 360 градусов (6,28 радиан)
            
            double x, y;
            double prevX = BidRadius / 2, prevY = 0;

            int cX = 0, cY = 0; // центр большой окружности
            int R2 = BidRadius / 2; // радиус большой окружности
            int R1 = SmallRadius / 2; // радиус меньшей (движущейся) окружности
            int k = (int)(R2 / R1);
            double Alfa = StartAlfa;
            int i = 0; // количество точек прорисовки

            p = new Point[64]; // точки для прорисовки (LastT/Step)
            while (Alfa <= LastT)
            {

                x = R1 * (k + 1) * (Math.Cos(Alfa) - (Math.Cos((k + 1) * Alfa) / (k + 1)));
                y = R1 * (k + 1) * (Math.Sin(Alfa) - (Math.Sin((k + 1) * Alfa) / (k + 1)));
                p[i] = new Point(cX + (int)(x), cY + (int)(y)); // расчет очередной точки траектории

                Graphics Графика = pictureBox1.CreateGraphics();
                int w = pictureBox1.ClientSize.Width / 2;
                int h = pictureBox1.ClientSize.Height / 2;
                Point[] triangle;
                triangle = new Point[3];
                Графика.TranslateTransform(w, h);
                Графика.Clear(BackColor);
                e.Graphics.Clear(BackColor);
                double smallCenterX, smallCenterY;

                Графика.DrawEllipse(Pens.Black, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                e.Graphics.DrawEllipse(Pens.Black, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                smallCenterX = Hypotenuse * Math.Cos(Alfa) - (SmallRadius / 2);
                smallCenterY = Hypotenuse * Math.Sin(Alfa) + (SmallRadius / 2);
                Графика.DrawEllipse(Pens.Black, (int)smallCenterX, (int)smallCenterY + (int)(-SmallRadius), SmallRadius, SmallRadius);
                e.Graphics.DrawEllipse(Pens.Black, (int)smallCenterX, (int)smallCenterY + (int)(-SmallRadius), SmallRadius, SmallRadius);
                Графика.DrawLine(Pens.Black, new Point(0, -w), new Point(0, w));
                Графика.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
                Графика.DrawLines(TrajectoryPen, p);

                e.Graphics.DrawLines(TrajectoryPen, p);
                prevX = x; prevY = y;

                Alfa += Step;

                Thread.Sleep(Speed); //время приостановки прорисовки
                i++;
            }
            Print_System(e);
            indexTrajectory = 0;

        }
        private void Print_Triangle(PaintEventArgs e)
        {
            Point[] triangle;
            Graphics Графика = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            Графика.TranslateTransform(w, h);
            triangle = new Point[3];
            indexShape = 0;
            double rad = (Math.Sqrt(3) * side / 3);

            int j;

            if (direct == 0)
            {

                for (int i = 0; i < zalupa*p.Length; i++)
                {
                    j = i;
                    if (i == zalupa * p.Length) {
                        j = 0;

                    }
                    if (j % acu == 0)
                    {
                        rad = (Math.Sqrt(3) * side / 3);


                        Графика.Clear(BackColor);

                        Графика.DrawLines(TrajectoryPen, p);
                        Графика.DrawLine(Pens.Black, new Point(0, -w), new Point(0, w));
                        Графика.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
                        Графика.DrawEllipse(Pens.Black, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                        Графика.DrawEllipse(Pens.Black, (int)(BidRadius / 2), (int)(p[p.Length - 1].Y - (SmallRadius / 2)), SmallRadius, SmallRadius);

                        triangle[0] = new Point((int)(p[j].X + rad * Math.Cos(angleTurn)), (int)(p[j].Y + rad * Math.Sin(angleTurn)));
                        triangle[1] = new Point((int)(p[j].X + rad * Math.Cos((2 * Math.PI) / 3 + angleTurn)), (int)(p[j].Y + rad * Math.Sin((2 * Math.PI) / 3 + angleTurn)));
                        triangle[2] = new Point((int)(p[j].X + rad * Math.Cos((4 * Math.PI) / 3 + angleTurn)), (int)(p[j].Y + rad * Math.Sin((4 * Math.PI) / 3 + angleTurn)));
                        Графика.DrawPolygon(ShapePen, triangle);
                        Графика.FillPolygon(fill, triangle);
                        angleTurn += angleStat;
                        if (cheack == 1)
                        {
                            if (counter < (int)(SpeedOfPulse / 2))
                            {

                                side += difference;
                                counter++;
                            }
                            else if (counter >= (int)(SpeedOfPulse / 2) && counter < SpeedOfPulse)
                            {
                                side -= difference;
                                counter++;
                            }



                        }
                        if (counter == SpeedOfPulse) counter = 0;
                        Thread.Sleep(ShapeSpeed);
                    }
                    
                }
            }
            if (direct == 1)
            {

                for (int i = p.Length - 1; i >= 0; i--)
                {
                    if (i % acu == 0)
                    {
                        rad = (Math.Sqrt(3) * side / 3);
                        Графика.Clear(BackColor);

                        Графика.DrawLines(TrajectoryPen, p);
                        Графика.DrawLine(Pens.Black, new Point(0, -w), new Point(0, w));
                        Графика.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
                        Графика.DrawEllipse(Pens.Black, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                        Графика.DrawEllipse(Pens.Black, (int)(BidRadius / 2), (int)(p[p.Length - 1].Y - (SmallRadius / 2)), SmallRadius, SmallRadius);

                        triangle[0] = new Point((int)(p[i].X + rad * Math.Cos(angleTurn)), (int)(p[i].Y + rad * Math.Sin(angleTurn)));
                        triangle[1] = new Point((int)(p[i].X + rad * Math.Cos((2 * Math.PI) / 3 + angleTurn)), (int)(p[i].Y + rad * Math.Sin((2 * Math.PI) / 3 + angleTurn)));
                        triangle[2] = new Point((int)(p[i].X + rad * Math.Cos((4 * Math.PI) / 3 + angleTurn)), (int)(p[i].Y + rad * Math.Sin((4 * Math.PI) / 3 + angleTurn)));
                        Графика.DrawPolygon(ShapePen, triangle);
                        Графика.FillPolygon(fill, triangle);
                        angleTurn += angleStat;
                        if (cheack == 1)
                        {
                            if (counter < (int)(SpeedOfPulse / 2))
                            {

                                side += difference;
                                counter++;
                            }
                            else if (counter >= (int)(SpeedOfPulse / 2) && counter < SpeedOfPulse)
                            {
                                side -= difference;
                                counter++;
                            }



                        }
                        if (counter == SpeedOfPulse) counter = 0;
                        Thread.Sleep(ShapeSpeed);

                    }
                   
                }
            }

            counter = 0;
            cheack = 0;
            angleTurn = 0;
            e.Graphics.DrawPolygon(ShapePen, triangle);
            e.Graphics.FillPolygon(fill, triangle);

        }
        private void DrawXAxis(Point start, Point end, Graphics g)
        {
            g.DrawLine(Pens.Black, start, end);
        }        
        private void DrawYAxis(Point start, Point end, Graphics g)
        {
            g.DrawLine(Pens.Black, start, end);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        private void SecondRаdius_Click(object sender, EventArgs e)
        {
            BigRadBox.Text = BigRad.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BigRadBox.Text = BidRadius.ToString();
            SideBox.Text = side.ToString();
            SpeedBox.Text = Speed.ToString ();
            comboBox1.Text = "Кардиоида";
            SpeedTrBox.Text = ShapeSpeed.ToString ();
            comboBox2.Text = "Clockwise";
            TurnBox.Text = turn.ToString();
            FigurerotationstepBox.Text = angleStat.ToString();
            
            comboBox6.Text = "Solid";
            comboBox7.Text = "Red";
            comboBox8.Text = "2";
            comboBox3.Text = "Green";
            comboBox4.Text = "Coral";
            comboBox5.Text = "2";
            comboBox9.Text = "Soli";
            firstCheak = 0;


        }
        private void CoordinateSystem_Click(object sender, EventArgs e)
        {
            indexSys = 1;
            pictureBox1.Refresh();
        }
        private void Trajectory_Click(object sender, EventArgs e)
        {
            
            indexTrajectory = 1;
            if (BigRadBox.Text != "") BidRadius = Convert.ToInt32(BigRadBox.Text);
            SmallRadius = BidRadius / type;
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);

            pictureBox1.Refresh();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    type = 1; break;
                case 1:
                    type = 2; break;
                case 2:
                    type = 3; break;

            }

        }
        private void Shape_Click(object sender, EventArgs e)
        {
            if (ZalupaBox.Text != "") zalupa = Convert.ToInt32(ZalupaBox.Text);
            if (BigRadBox.Text != "") BidRadius = Convert.ToInt32(BigRadBox.Text);
            SmallRadius = BidRadius / type;
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            indexShape = 1;
            if (SpeedTrBox.Text != "") ShapeSpeed = Convert.ToInt32(SpeedTrBox.Text);
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            if (SideBox.Text != "") side = Convert.ToInt32(SideBox.Text);
            if(TurnBox.Text != ""&& TurnBox.Text != "Custom") turn = Convert.ToInt32(TurnBox.Text);
            if (FromBox.Text != "" && FromBox.Text != "0" && ToBox.Text != "" && ToBox.Text != "")
            {
                cheack = 1;
                side = Convert.ToInt32(FromBox.Text);
               
                if (RippleRateBox.Text != "") SpeedOfPulse = Convert.ToInt32(RippleRateBox.Text); 
                difference =Math.Abs(Convert.ToInt32(FromBox.Text)- Convert.ToInt32(ToBox.Text))/ SpeedOfPulse;
            }
            
            pictureBox1.Refresh();


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    direct = 0; break;
                case 1:
                    direct = 1; break;
            }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    TrajectoryPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;  break;
                case 1:
                    TrajectoryPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; break;
                case 2:
                    TrajectoryPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; break;
                case 3:
                    TrajectoryPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break;
                case 4:
                    TrajectoryPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break;
            }

        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedIndex)
            {
                case 0:
                    ShapePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; break;
                case 1:
                    ShapePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; break;
                case 2:
                    ShapePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; break;
                case 3:
                    ShapePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break;
                case 4:
                    ShapePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break;
            }

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    ShapePen.Width = 2; break;
                case 1:
                    ShapePen.Width = 4; break;
                case 2:
                    ShapePen.Width = 6; break;
                case 3:
                    ShapePen.Width = 8; break;
                case 4:
                    ShapePen.Width = 10; break;
            }

        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    TrajectoryPen.Width = 2; break;
                case 1:
                    TrajectoryPen.Width = 4; break;
                case 2:
                    TrajectoryPen.Width = 6; break;
                case 3:
                    TrajectoryPen.Width = 8; break;
                case 4:
                    TrajectoryPen.Width = 10; break;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (firstCheak == 0&&secondCheak!=1)
            {
                angleStat = Convert.ToDouble(FigurerotationstepBox.Text);
                TurnBox.Text = "Custom";
                secondCheak = 1;
            }
            secondCheak = 0;

        }            
        private void TurnBox_TextChanged(object sender, EventArgs e)
        {
            if (firstCheak == 0)
            {
                secondCheak = 1;
                if (TurnBox.Text != "")
                {
                    if (TurnBox.Text != "Custom")
                    {
                        turn = Convert.ToInt32(TurnBox.Text);
                    }
                    else turn = 0;
                }
                if (p != null)
                {
                    
                    angleStat = (2 * Math.PI * turn) / (p.Length - 1);
                    
                }

                FigurerotationstepBox.Text = angleStat.ToString();
                
            }
           

        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    TrajectoryPen.Color = Color.Red; break;
                case 1:
                    TrajectoryPen.Color = Color.RosyBrown; break;
                case 2:
                    TrajectoryPen.Color = Color.Purple; break;
                case 3:
                    TrajectoryPen.Color = Color.Pink; break;
                case 4:
                    TrajectoryPen.Color = Color.Green; break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    ShapePen.Color = Color.Red; break;
                case 1:
                    ShapePen.Color = Color.RosyBrown; break;
                case 2:
                    ShapePen.Color = Color.Purple; break;
                case 3:
                    ShapePen.Color = Color.Pink; break;
                case 4:
                    ShapePen.Color = Color.Green; break;
            }

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    fill= new SolidBrush(Color.Red); break;
                case 1:
                    fill = new SolidBrush(Color.Coral); break;
                case 2:
                    fill = new SolidBrush(Color.Purple); break;
                case 3:
                    fill = new SolidBrush(Color.Pink); break;
                case 4:
                    fill = new SolidBrush(Color.Green); break;
            }
        }
        private void acur_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (acur.SelectedIndex)
            {
                case 0:
                    acu = 1; break;
                case 1:
                    acu = 2; break;
                case 2:
                    acu = 4; break;
                case 3:
                    acu = 10; break;                
            }

        }
    }
}