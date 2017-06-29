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

namespace Snip_GUI
{
    public partial class ChartView : Form
    {
        Tuple<String, float>[] args;
        public ChartView(Tuple<String, float>[] args)
        {
            this.args = args;
            InitializeComponent();
        }


        // Draw a pie chart.
        private void DrawPieChart(Graphics gr,
            Rectangle rect, Brush[] brushes, Pen[] pens,
            float[] values)
        {
            // Get the total of all angles.
            float total = values.Sum();

            // Draw the slices.
            float start_angle = 0;
            int i2 = 0;

            foreach (Tuple<String, float> ti in args)
            {


                float i = ti.Item2;
                float sweep_angle = i * 360f / total;
                gr.FillPie(brushes[i2 % brushes.Length],
                    rect, start_angle, sweep_angle);
                gr.DrawPie(pens[i2 % pens.Length],
                    rect, start_angle, sweep_angle);
                start_angle += sweep_angle;


                if (!listView1.Items.ContainsKey(ti.Item1))
                {


                    listView1.Items.Add(ti.Item1
                        );

                    listView1.Items[i2].BackColor = new Pen(brushes[i2]).Color;
                }

                i2++;


            }



        }

        // Brushes used to fill pie slices.
        private Brush[] SliceBrushes =
        {
    Brushes.Red,
    Brushes.LightGreen,
    Brushes.Blue,
    Brushes.LightBlue,
    Brushes.Green,
    Brushes.Lime,
    Brushes.Orange,
    Brushes.Fuchsia,
    Brushes.Yellow,
    Brushes.Cyan,
};

        // Pens used to outline pie slices.
        private Pen[] SlicePens = { Pens.Black };

        // The data values to chart.
        private float[] Values;



        private void ChartView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if ((ClientSize.Width < 20) || (ClientSize.Height < 20)) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
                10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            DrawPieChart(e.Graphics, rect, SliceBrushes, SlicePens, Values);

        }

        private void ChartView_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = 0;
            Values = new float[args.Length];
            foreach (Tuple<String, float> t in args)
            {
                Values[i] = t.Item2;
                i++;
            }
        }
    }
}
