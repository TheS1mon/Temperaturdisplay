using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturdisplay_Client
{
    public partial class FormPictureBox : Form
    {

        public FormPictureBox()
        {
            InitializeComponent();
        }

        public FormPictureBox(List<Temperatur> tempList, DateTime startTime, DateTime endTime) : this()
        {
            List<PlottedPoint> plottedPoints = this.GeneratePlot(tempList, startTime, endTime, 605, 206);
            Bitmap bm = new Bitmap(605, 206);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                foreach(PlottedPoint point in plottedPoints)
                {
                    Rectangle rect = new Rectangle((int)point.X, (int)point.Y, 10, 10);
                    gr.FillEllipse(Brushes.LightGreen, rect);
                    using (Pen thick_pen = new Pen(Color.Blue, 5))
                    {
                        gr.DrawEllipse(thick_pen, rect);
                    }
                }
            }
            pictureBox1.Image = bm;
        }

        public List<PlottedPoint> GeneratePlot(List<Temperatur> series, DateTime start, DateTime end, int height, int width)
        {
            List<PlottedPoint> generatedCoordinates = new List<PlottedPoint>();

            float tempMax = (float)series.Max(e => e.temp);
            float tempMin = (float)series.Min(e => e.temp);

            long maxUnix = ((DateTimeOffset)series.Max(e => e.dateTime)).ToUnixTimeSeconds();
            long minUnix = ((DateTimeOffset)series.Min(e => e.dateTime)).ToUnixTimeSeconds();

            foreach (var item in series)
            {
                double x = Map(((DateTimeOffset)item.dateTime).ToUnixTimeSeconds(), (long)minUnix, (long)maxUnix, 0, (long)width);
                double y = MapFloatRange((double)item.temp, (double)tempMin, (double)tempMax, (double)height - 10, 10, 5);
                generatedCoordinates.Add(new PlottedPoint(item, (float)x, (float)y));
            }

            return generatedCoordinates;
        }

        public long Map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        public static double MapFloatRange(double sourceNumber, double fromA, double fromB, double toA, double toB, int decimalPrecision)
        {
            double deltaA = fromB - fromA;
            double deltaB = toB - toA;
            double scale = deltaB / deltaA;
            double negA = -1 * fromA;
            double offset = (negA * scale) + toA;
            double finalNumber = (sourceNumber * scale) + offset;
            int calcScale = (int)Math.Pow(10, decimalPrecision);
            return (double)Math.Round(finalNumber * calcScale) / calcScale;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    [Serializable]
    public struct Temperatur
    {
        public double temp;
        public DateTime dateTime;

        public Temperatur(double temp, DateTime dateTime)
        {
            this.temp = temp;
            this.dateTime = dateTime;
        }
    }

    public struct PlottedPoint
    {
        public Temperatur tempVal;
        public float X;
        public float Y;

        public PlottedPoint(Temperatur tempVal, float X, float Y)
        {
            this.tempVal = tempVal;
            this.X = X;
            this.Y = Y;
        }
    }
}
