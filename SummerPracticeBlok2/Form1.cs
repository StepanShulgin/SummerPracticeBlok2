using System.ComponentModel;

namespace SummerPracticeBlok2
{
    public partial class Form1 : Form
    {
        int indexSys;
        int indexCic;
        int indexTrajectory;
        int indexShape;
        int BidRadius =200;
        int SmallRadius=100;
        int Speed=0;
        int ShapeSpeed = 0;
        int type = 1;
        int side = 10;
        Point[] p;
        const int PIX_IN_ONE = 15;
        //Длина стрелки
        const int ARR_LEN = 10;
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

            if (indexCic == 1)
            {
                Pen myPen = new Pen(Color.Black);
                e.Graphics.DrawEllipse(myPen, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                e.Graphics.DrawEllipse(myPen, (int)(BidRadius / 2), (int)(-SmallRadius / 2), SmallRadius, SmallRadius);
            }
            if (indexTrajectory == 1)
            {
                Print_Trajectory(e);
            }


        }
        private void Print_Trajectory(PaintEventArgs e) {
            int Hypotenuse = (int)(BidRadius / 2) + (int)(SmallRadius / 2);
            double StartAlfa = 0, LastT = 6.3; // оборот в 360 градусов (6,28 радиан)
            double Step = 0.1;
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
                Графика.DrawLines(Pens.Red, p);

                e.Graphics.DrawLines(Pens.Red, p);
                prevX = x; prevY = y;

                Alfa += Step;

                Thread.Sleep(Speed); //время приостановки прорисовки
                i++;
            }
            Print_System(e);
            indexTrajectory = 0;

        }
        private void Print_Triangle(PaintEventArgs e) {
            Point[] triangle;
            Graphics Графика = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            Графика.TranslateTransform(w, h);
            triangle = new Point[3];
            indexShape = 0;
            
                
            
                  
           
           
            for (int i = 0; i < p.Length; i ++) {
                Графика.Clear(BackColor);
                
                Графика.DrawLines(Pens.Red, p);
                Графика.DrawLine(Pens.Black, new Point(0, -w), new Point(0, w));
                Графика.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
                Графика.DrawEllipse(Pens.Black, (int)(-BidRadius / 2), (int)(-BidRadius / 2), BidRadius, BidRadius);
                Графика.DrawEllipse(Pens.Black, (int)(BidRadius / 2), (int)(p[p.Length-1].Y-(SmallRadius / 2)), SmallRadius, SmallRadius);

                triangle[0] = new Point(p[i].X, (int)(p[i].Y + (Math.Sqrt(3) * side / 3)));
                triangle[1] = new Point((int)(p[i].X - side / 2), (int)(p[i].Y - (Math.Sqrt(3) * side / 6)));
                triangle[2] = new Point((int)(p[i].X + side / 2), (int)(p[i].Y - (Math.Sqrt(3) * side / 6)));
                Графика.DrawPolygon(Pens.Green, triangle);
               
                Thread.Sleep(ShapeSpeed);
            }
           
            e.Graphics.DrawPolygon(Pens.Green, triangle);

        }



        private void Print_Running_Circle(PaintEventArgs e, int Hypotenuse, double Alfa,int i) {
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
            Графика.DrawLine(Pens.Black,new Point(0,-w), new Point(0, w));
            Графика.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
            Графика.DrawLines(Pens.Red, p);
                     
            e.Graphics.DrawLines(Pens.Green, p);
            

        }
        


        //Рисование оси X
        private void DrawXAxis(Point start, Point end, Graphics g)
        {         
           g.DrawLine(Pens.Black, start, end);                   
        }

        //Рисование оси Y
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if(SpeedBox.Text!= "") Speed = Convert.ToInt32(SpeedBox.Text);
           
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
            if (BigRadBox.Text != "") BidRadius = Convert.ToInt32(BigRadBox.Text);
            SmallRadius = BidRadius / type;
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            indexShape = 1;
            if (SpeedTrBox.Text != "") ShapeSpeed = Convert.ToInt32(SpeedTrBox.Text);
            if (SpeedBox.Text != "") Speed = Convert.ToInt32(SpeedBox.Text);
            if (SideBox.Text != "") side = Convert.ToInt32(SideBox.Text);
      
            pictureBox1.Refresh();
            
            
        }
    }
}