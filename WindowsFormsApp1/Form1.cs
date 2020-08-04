using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    

    public partial class Form1 : Form
    {
        string decimales;
        string[,] coordenadas;
        double[,] depth;
        List<Datos> datosinterpolados;
        List<Datos> anormal;
        double maxDepth;
        double minDepth;
        public Point mouse_offset;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

            
            lbl_Interpolar.Enabled = false;
            lblGuardar.Enabled = false;
            txtRango.Enabled = false;
            lblGraficar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    lblPrueba.Text = openFileDialog1.SafeFileName;
                    string[] datosgrafica = File.ReadAllLines(openFileDialog1.FileName);
                    coordenadas = new string[datosgrafica.Count(), 2];
                    //depth = new double[coordenadas.GetLength(0) - 1, 2];
                    anormal = new List<Datos>();
                    for (int i = 0; i < datosgrafica.Count(); i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {

                            //string[] DataIn = datosgrafica[i].Split('\t');
                            string[] DataIn = datosgrafica[i].Split('\t');
                            coordenadas[i, j] = DataIn[j];
                        }
                    }

                    for (int i = 1; i < coordenadas.GetLength(0); i++)
                    {

                        double datosx;
                        double datosy;

                        if (double.TryParse(coordenadas[i, 0], out datosx) && double.TryParse(coordenadas[i, 1], out datosy))
                        {
                            anormal.Add(new Datos { datox = datosx, datoy = datosy });

                        }

                        //for (int j = 0; j < 2; j++)
                        //{

                        //   double.TryParse(coordenadas[i, j], out depth[i - 1, j]);
                        //}

                    }
                    lbl_Interpolar.Enabled = true;
                    lblGuardar.Enabled = true;
                    txtRango.Enabled = true;
                    lblGraficar.Enabled = true;
                }
            }
            catch
            {
                lblPrueba.Text = "error al cargar archivo";
            }
            }




        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
        {if (decimales == "coma")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',')
                {
                    e.Handled = false;
                }
                else
                {


                    e.Handled = true;

                }

            }
            else if (decimales == "punto")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {


                    e.Handled = true;

                }
            }
            }

        static double[,] normalizar(List<Datos> anormal)
        {
            double[,] normalizado = new double[anormal.Count, 2];
            // eliminamos los negativos de litologia y los reemplazamos por 0
            for (int i = 0; i < anormal.Count; i++)
            {

                if (anormal[i].datox < 0)
                {
                    normalizado[i, 0] = 0;
                }
                else
                {
                    normalizado[i, 0] = anormal[i].datox;
                }

                if (anormal[i].datoy < 0)
                {
                    normalizado[i, 1] = 0;
                }
                else
                {
                    normalizado[i, 1] = anormal[i].datoy;
                }
                //for (int j = 0; j < anormal.GetLength(1); j++)
                //{
                //    if (anormal[i, j] < 0)
                //    {
                //        normalizado[i, j] = 0;
                //    }

                //    else

                //    {
                //        normalizado[i, j] = anormal[i, j];
                //    }
                //}
            }

            // normalizamos la profundidad
            for (int i = 1; i < normalizado.GetLength(0); i++)
            {

                if (normalizado[i, 1] > normalizado[i - 1, 1])
                {

                    normalizado[i, 1] = normalizado[i, 1];

                }
                else
                {
                    
                    normalizado[i, 1] = normalizado[i, 1] + 0.00001;
                        

                }


            }

            // rectificamos la normalizacion
            for (int i = 1; i < normalizado.GetLength(0); i++)
            {

                if (normalizado[i, 1] > normalizado[i - 1, 1])
                {

                    normalizado[i, 1] = normalizado[i, 1];

                }
                else
                {

                    normalizado[i, 1] = normalizado[i, 1] + 0.00001;

                }


            }
            //Console.WriteLine(normalizado[0, 0] + " " + normalizado[0, 1]);

            return normalizado;
        }

        private void btnInterpolar_Click(object sender, EventArgs e)
        {
            try
            {
                double range;
                depth = normalizar(anormal);
                double.TryParse(txtRango.Text, out range);
                //variable a reemplazr por rango
                int indice = 0;
                double[] profundidad = new double[depth.GetLength(0)];
                double[] litolojia = new double[depth.GetLength(0)];

                for (int j = 0; j < depth.GetLength(0); j++)
                {
                    litolojia[j] = depth[j, 0];
                    profundidad[j] = depth[j, 1];
                }

                maxDepth = (int)Math.Ceiling(profundidad.Max());
                minDepth = profundidad.Min();

                //por hacer: revisar el tamaño de array posiblemente cambiarlo a list
                datosinterpolados = new List<Datos>();

                for (double x = minDepth; x <= maxDepth + range; x += range)
                {

                    if (x == minDepth || x == maxDepth)
                    {
                        datosinterpolados.Add(new Datos { datox = Math.Round(x, 5), datoy = litolojia[indice] });
                        //datosInterpolados[indice, 0] = x;
                        //datosInterpolados[indice, 1] = litolojia[indice];
                        indice++;
                    }

                    else

                    {
                        int i = Array.FindIndex(profundidad, k => x <= k);
                        datosinterpolados.Add(new Datos
                        {
                            datox = Math.Round(x, 5),
                            datoy = litolojia[i - 1] + (x - profundidad[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (profundidad[i] - profundidad[i - 1])
                        });
                        //datosInterpolados[indice, 1] = litolojia[i - 1] + (x - depth[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (depth[i] - depth[i - 1]);
                        //datosInterpolados[indice, 0] = x;

                        indice++;

                    }
                }
                //    for (double x = minDepth; x <= maxDepth + range; x += range)
                //    {

                //        if (x == minDepth || x == maxDepth)
                //        {

                //            datosInterpolados[indice, 0] = x;
                //            datosInterpolados[indice, 1] = litolojia[indice];
                //            indice++;
                //        }

                //        else

                //        {
                //            int i = Array.FindIndex(profundidad, k => x <= k);
                //            datosInterpolados[indice, 1] = litolojia[i - 1] + (x - profundidad[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (profundidad[i] - profundidad[i - 1]);
                //            datosInterpolados[indice, 0] = x;

                //            indice++;

                //        }
                //    }
                //    datosInterpolados = new double[(int)((maxDepth - minDepth) / range) + 2, 2];
                //    imprimirDatos(datosInterpolados);
                //    Console.WriteLine("done");
                //}
            } catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter outfile = new StreamWriter(saveFileDialog1.FileName))
                {

                    string content = "";
                    content += "Depth(normalizado)" + "\t";
                    content += "Litologia(normalizado)" + "\t";
                    content += "" + "\t";
                    content += "Depth(interpolado)" + "\t";
                    content += "Litologia(interpolado)" + "\t";
                    outfile.WriteLine(content);
                    for (int x = 0; x <datosinterpolados.Count; x++)
                    {
                        content = "";
                        if (x<depth.GetLength(0))
                        {
                            content += depth[x, 1] + "\t";
                            content += depth[x, 0] + "\t";
                        }
                        else
                        {
                            content += "" + "\t";
                            content += "" + "\t";
                        }
                            content += "" + "\t";
                            content += datosinterpolados[x].datox + "\t";
                            content += datosinterpolados[x].datoy + "\t";
                        //trying to write data to csv
                        outfile.WriteLine(content);
                    }


                }



            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafica graph = new Grafica(minDepth,maxDepth, depth, datosinterpolados);
            graph.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (StreamWriter outfile = new StreamWriter(saveFileDialog1.FileName))
                    {

                        string content = "";
                        content += "Depth Y (normalizado)" + "\t";
                        content += "X (normalizado)" + "\t";
                        content += "" + "\t";
                        content += "Depth Y (interpolado)" + "\t";
                        content += "X (interpolado)" + "\t";
                        outfile.WriteLine(content);
                        for (int x = 0; x < datosinterpolados.Count; x++)
                        {
                            content = "";
                            if (x < depth.GetLength(0))
                            {
                                content += depth[x, 1] + "\t";
                                content += depth[x, 0] + "\t";
                            }
                            else
                            {
                                content += "" + "\t";
                                content += "" + "\t";
                            }
                            content += "" + "\t";
                            content += datosinterpolados[x].datox + "\t";
                            content += datosinterpolados[x].datoy + "\t";
                            //trying to write data to csv
                            outfile.WriteLine(content);
                        }


                    }



                }
            }
            catch
            {
                MessageBox.Show("Error en los datos! Revisa los Parametros de entrada", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Grafica graph = new Grafica(minDepth, maxDepth, depth, datosinterpolados);
            graph.Show();
        }

        private void lbl_Interpolar_Click(object sender, EventArgs e)
        {
            try
            {
                double range;
                depth = normalizar(anormal);
                double.TryParse(txtRango.Text, out range);
                //variable a reemplazr por rango
                int indice = 0;
                double[] profundidad = new double[depth.GetLength(0)];
                double[] litolojia = new double[depth.GetLength(0)];

                for (int j = 0; j < depth.GetLength(0); j++)
                {
                    litolojia[j] = depth[j, 0];
                    profundidad[j] = depth[j, 1];
                }

                maxDepth = (int)Math.Ceiling(profundidad.Max());
                minDepth = profundidad.Min();

                //por hacer: revisar el tamaño de array posiblemente cambiarlo a list
                datosinterpolados = new List<Datos>();

                for (double x = minDepth; x <= maxDepth + range; x += range) 
                //for (double x = minDepth; x <= maxDepth ; x += range)
                {

                    if (x == minDepth || x == maxDepth)
                    {
                        datosinterpolados.Add(new Datos { datox = Math.Round(x, 5), datoy = litolojia[indice] });
                        //datosInterpolados[indice, 0] = x;
                        //datosInterpolados[indice, 1] = litolojia[indice];
                        indice++;
                    }

                    else 

                    { 
                            int i = Array.FindIndex(profundidad, k => x <= k);
                            
                            datosinterpolados.Add(new Datos
                            {
                               
                                datox = Math.Round(x, 5),
                                datoy = litolojia[i - 1] + (x - profundidad[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (profundidad[i] - profundidad[i - 1])
                            });
                            //datosInterpolados[indice, 1] = litolojia[i - 1] + (x - depth[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (depth[i] - depth[i - 1]);
                            //datosInterpolados[indice, 0] = x;


                            indice++;
                        
                    }

                }

          
                //    for (double x = minDepth; x <= maxDepth + range; x += range)
                //    {

                //        if (x == minDepth || x == maxDepth)
                //        {

                //            datosInterpolados[indice, 0] = x;
                //            datosInterpolados[indice, 1] = litolojia[indice];
                //            indice++;
                //        }

                //        else

                //        {
                //            int i = Array.FindIndex(profundidad, k => x <= k);
                //            datosInterpolados[indice, 1] = litolojia[i - 1] + (x - profundidad[i - 1]) * (litolojia[i] - litolojia[i - 1]) / (profundidad[i] - profundidad[i - 1]);
                //            datosInterpolados[indice, 0] = x;

                //            indice++;

                //        }
                //    }
                //    datosInterpolados = new double[(int)((maxDepth - minDepth) / range) + 2, 2];
                //    imprimirDatos(datosInterpolados);
                //    Console.WriteLine("done");
                //}
            }
            catch 
            {
                lbl_estado_info.ForeColor = System.Drawing.Color.Green;
                lbl_estado_info.Text = "Interpolado";
            }
        }

        private void lblCargar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                elegirDec selDecimal = new elegirDec();
                selDecimal.ShowDialog();
                decimales = selDecimal.sep_dec;
                
                if(decimales== "punto")
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-ES");
                    var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                    var ci = new CultureInfo(currentCulture)
                    {
                        NumberFormat = { NumberDecimalSeparator = "." },
                        
                    };
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
                    
                } else if (decimales == "coma")
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-ES");
                    var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                    var ci = new CultureInfo(currentCulture)
                    {
                        NumberFormat = { NumberDecimalSeparator = "," },

                    };
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

                }

                lblPrueba.Text = openFileDialog1.SafeFileName;
                    string[] datosgrafica = File.ReadAllLines(openFileDialog1.FileName);
                    coordenadas = new string[datosgrafica.Count(), 2];
                    //depth = new double[coordenadas.GetLength(0) - 1, 2];
                    anormal = new List<Datos>();
                    for (int i = 0; i < datosgrafica.Count(); i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {

                            //string[] DataIn = datosgrafica[i].Split('\t');
                            string[] DataIn = datosgrafica[i].Split('\t');
                            coordenadas[i, j] = DataIn[j];
                        }
                    }

                    for (int i = 1; i < coordenadas.GetLength(0); i++)
                    {

                        double datosx;
                        double datosy;

                        if (double.TryParse(coordenadas[i, 0], out datosx) && double.TryParse(coordenadas[i, 1], out datosy))
                        {
                            anormal.Add(new Datos { datox = datosx, datoy = datosy });

                        }

                        //for (int j = 0; j < 2; j++)
                        //{

                        //   double.TryParse(coordenadas[i, j], out depth[i - 1, j]);
                        //}

                    }
                    lbl_Interpolar.Enabled = true;
                    lblGuardar.Enabled = true;
                    txtRango.Enabled = true;
                    lblGraficar.Enabled = true;
                }
            //}
            //catch
            //{
            //    lblPrueba.Text = "error al cargar archivo";
            //}
        }

        private void lblRango_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {
            Help_form ayuda = new Help_form("principal");
            ayuda.Show();
        }
    }


    public class Datos
    {
        public double datox { get; set; }
        public double datoy { get; set; }


    }
}

