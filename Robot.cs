using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5sem_Lab1UDP
{
    internal class Robot
    {
        public PointF position { get; set; } = new PointF(30f,370f);

        public float orientation { get; set; } = -1.5708f;

        public int Size { get; set; } = 20;

        public Bitmap bitmap { get; set; } = new Bitmap(640, 400);

        public Graphics e { get; set; }

        public int LastLenc { get; set; } = 0;

        public int LastRenc { get; set; } = 0;

        private List<float> lasersRadians { get; set; } = new List<float>() { -0f, -0.785398f,-1.570796f,-2.356194f,-3.141593f,-3.926991f,-4.712389f,-5.497787f };

        private List<PointF> lasersEndPoints { get; set; } = new List<PointF>();

        public List<PointF> Path { get; set; } = new List<PointF>();

        public List<Rectangle> rectangles { get; set; } = new List<Rectangle>();

        public Robot() 
        {
            e = Graphics.FromImage(bitmap);
        }

        public void UpdatePos(int lenc,int renc)
        {
            float leftDelta = ((lenc - LastLenc) * 0.02805f)/0.5f; //0.0316
            float rightDelta = ((renc - LastRenc) * 0.02805f)/0.5f;

            LastLenc = lenc;
            LastRenc = renc;

            // leftDelta and rightDelta = distance that the left and right wheel have moved along
            //  the ground

            if (Math.Abs(leftDelta - rightDelta) <= 0.0168f)
            { // basically going straight
                float newX = position.X - leftDelta * (float)Math.Cos(orientation);
                float newY = position.Y + rightDelta * (float)Math.Sin(orientation);
                float newOrientation = orientation;
                position = new PointF(newX, newY);
                orientation = newOrientation;
            }
            else if (leftDelta == -rightDelta)
            {
                float R = Math.Abs((40f) * (leftDelta + rightDelta) / (2 * (rightDelta - leftDelta)));

                float wd = -((rightDelta - leftDelta) / (40f)) / 1.59f;

                float newX = position.X + R * (float)Math.Sin(wd * 0.5f + orientation) - R * (float)Math.Sin(orientation);
                float newY = position.Y - R * (float)Math.Cos(wd * 0.5f + orientation) + R * (float)Math.Cos(orientation);
                float newOrientation = orientation + wd;

                position = new PointF(newX, newY);
                orientation = newOrientation;
            }
            else
            {
                float R = Math.Abs((40f) * (leftDelta + rightDelta) / (2 * (rightDelta - leftDelta)))/1.42f; 

                float wd = ((rightDelta - leftDelta) / (40f))*2.8f;
                float newX;
                float newY;
                if(leftDelta > rightDelta)
                {
                    newX = position.X + R * (float)Math.Sin(wd * 0.5f + orientation) - R * (float)Math.Sin(orientation);
                    newY = position.Y + R * (float)Math.Cos(wd * 0.5f + orientation) - R * (float)Math.Cos(orientation);
                }
                else
                {
                    newX = position.X - R * (float)Math.Sin(wd * 0.5f + orientation) + R * (float)Math.Sin(orientation);
                    newY = position.Y - R * (float)Math.Cos(wd * 0.5f + orientation) + R * (float)Math.Cos(orientation);
                }

                float newOrientation = orientation + wd;

                position = new PointF(newX, newY);
                orientation = newOrientation;
            }
        }
    


        


        

        public void Draw(List<float> lasers)
        {
            e.Clear(Color.White);
            e.DrawEllipse(Pens.Black, position.X - Size/2, position.Y - Size/2, Size, Size);
            DrawLasers(e, lasers, position, lasersRadians, -orientation, lasersEndPoints, Size);
            e.DrawLine(Pens.Red, position,RotateDot(new PointF(position.X - Size/2,position.Y),-orientation,position));
            if(Path.Count > 1) e?.DrawLines(Pens.Blue, Path.ToArray());
            if(rectangles.Count > 0) e?.DrawRectangles(Pens.Black, rectangles.ToArray());
        }

        public void SavePositionAndRects()
        {
            Path.Add(position);
            foreach(PointF point in lasersEndPoints)
            {
                rectangles.AddIfNoIntersects(new Rectangle((int)point.X - 3 / 2, (int)point.Y - 3 / 2, 3, 3));
            }
        }

        private void DrawLasers(Graphics e, List<float> lasersLength, PointF position, List<float> lasersRadians,float orientation, List<PointF> lasersEndPoints, int size)
        {
            lasersEndPoints.Clear();
            for(int i = 0;i< lasersLength.Count; i++)
            {
                var rotatedPoint = RotateDot(new PointF(position.X - lasersLength[i]-size/2, position.Y), -lasersRadians[i]+orientation, position);
                lasersEndPoints.Add(rotatedPoint);
                e.DrawLine(Pens.Gray, position, rotatedPoint);
                e.DrawRectangle(Pens.Red, new Rectangle((int)rotatedPoint.X - 3 / 2, (int)rotatedPoint.Y - 3 / 2, 3, 3));
            }
        }

        private PointF RotateDot(PointF point, float radians,PointF startPoint)
        {
            float x = startPoint.X + (point.X - startPoint.X) * (float)Math.Cos(radians) - (point.Y - startPoint.Y) * (float)Math.Sin(radians);
            float y = startPoint.Y + (point.X - startPoint.X) * (float)Math.Sin(radians) + (point.Y - startPoint.Y) * (float)Math.Cos(radians);
            return new PointF(x, y);

        }
    }
}
