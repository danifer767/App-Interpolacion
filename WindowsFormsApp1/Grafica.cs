using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Grafica : Form
    {
        public Point mouse_offset;
        double[,] datosNormalizados;
        double minimaProfundidad;
        double maximaProfundidad;
        List<Datos> datosInterpolados;
        public Grafica(double profundidad, double profmax, double[,] normalizado, List<Datos> Interpolados)
        {
            InitializeComponent();
            minimaProfundidad = profundidad;
            datosNormalizados = normalizado;
            datosInterpolados = Interpolados;
            maximaProfundidad = profmax + 10;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisY.Interval = 50;
            this.chart1.ChartAreas[0].AxisX.Interval = 50;
            this.chart1.ChartAreas[0].AxisY.Minimum = minimaProfundidad;
            this.chart1.ChartAreas[0].AxisY.Maximum = maximaProfundidad;
            this.chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            this.chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.MouseWheel += Chart1_MouseWheel;

            try
            {
                for (int i = 0; i < datosNormalizados.GetLength(0); i++)
                {
                    this.chart1.Series["Normalizado"].Points.AddXY(datosNormalizados[i, 0], datosNormalizados[i, 1]);
                }
                for (int i = 0; i < datosInterpolados.Count; i++)
                {
                    this.chart1.Series["Interpolado"].Points.AddXY(datosInterpolados[i].datoy, datosInterpolados[i].datox);
                }
            }
            catch
            {
                MessageBox.Show("Error en los datos! Revisa los Parametros de entrada", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {

                    yAxis.ScaleView.ZoomReset(1);

                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    //var yMin = yAxis.ScaleView.ViewMinimum;
                    //var yMax = yAxis.ScaleView.ViewMaximum;


                    //var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    //var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;


                    //yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;


                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;


                    yAxis.ScaleView.Zoom(posYStart, posYFinish);

                }

            }
            catch { }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {


                e.Handled = true;

            }
        }

        private void btnEscala_Click(object sender, EventArgs e)
        {
            try
            {
                double escala;
                double.TryParse(txtEscala.Text, out escala);
                if (chbEscalaX.Checked)
                {
                    this.chart1.ChartAreas[0].AxisX.Interval = escala;

                }

                if (chbEscalaY.Checked)
                {
                    this.chart1.ChartAreas[0].AxisY.Interval = escala;
                }

                //chart1.Update();
                chart1.Invalidate();
            }
            catch
            {

            }
        }

        private void lbl_esccalar_Click(object sender, EventArgs e)
        {
            try
            {
                double escala;
                double.TryParse(txtEscala.Text, out escala);
                if (chbEscalaX.Checked)
                {
                    this.chart1.ChartAreas[0].AxisX.Interval = escala;

                }

                if (chbEscalaY.Checked)
                {
                    this.chart1.ChartAreas[0].AxisY.Interval = escala;
                }

                //chart1.Update();
                chart1.Invalidate();
            }
            catch
            {

            }
        }

        private void Grafica_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Grafica_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {
            Help_form ayuda = new Help_form("grafica");
            ayuda.Show();
        }
    }

   
}