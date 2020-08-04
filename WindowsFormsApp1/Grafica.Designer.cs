namespace WindowsFormsApp1
{
    partial class Grafica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtEscala = new System.Windows.Forms.TextBox();
            this.chbEscalaX = new System.Windows.Forms.CheckBox();
            this.chbEscalaY = new System.Windows.Forms.CheckBox();
            this.lbl_esccalar = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_mini = new System.Windows.Forms.Label();
            this.lbl_help = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.IsReversed = true;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.CursorY.IsUserSelectionEnabled = true;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(63, 39);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Aqua};
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Normalizado";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Transparent;
            series8.Name = "Interpolado";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(666, 571);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // txtEscala
            // 
            this.txtEscala.Location = new System.Drawing.Point(612, 174);
            this.txtEscala.Name = "txtEscala";
            this.txtEscala.Size = new System.Drawing.Size(100, 20);
            this.txtEscala.TabIndex = 2;
            this.txtEscala.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEscala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // chbEscalaX
            // 
            this.chbEscalaX.AutoSize = true;
            this.chbEscalaX.BackColor = System.Drawing.Color.Transparent;
            this.chbEscalaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEscalaX.ForeColor = System.Drawing.Color.White;
            this.chbEscalaX.Location = new System.Drawing.Point(612, 128);
            this.chbEscalaX.Name = "chbEscalaX";
            this.chbEscalaX.Size = new System.Drawing.Size(84, 20);
            this.chbEscalaX.TabIndex = 3;
            this.chbEscalaX.Text = "Escalar X";
            this.chbEscalaX.UseVisualStyleBackColor = false;
            // 
            // chbEscalaY
            // 
            this.chbEscalaY.AutoSize = true;
            this.chbEscalaY.BackColor = System.Drawing.Color.Transparent;
            this.chbEscalaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEscalaY.ForeColor = System.Drawing.Color.White;
            this.chbEscalaY.Location = new System.Drawing.Point(612, 151);
            this.chbEscalaY.Name = "chbEscalaY";
            this.chbEscalaY.Size = new System.Drawing.Size(85, 20);
            this.chbEscalaY.TabIndex = 4;
            this.chbEscalaY.Text = "Escalar Y";
            this.chbEscalaY.UseVisualStyleBackColor = false;
            // 
            // lbl_esccalar
            // 
            this.lbl_esccalar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_esccalar.Image = global::WindowsFormsApp1.Properties.Resources.btnEscalar;
            this.lbl_esccalar.Location = new System.Drawing.Point(603, 197);
            this.lbl_esccalar.Name = "lbl_esccalar";
            this.lbl_esccalar.Size = new System.Drawing.Size(117, 46);
            this.lbl_esccalar.TabIndex = 5;
            this.lbl_esccalar.Click += new System.EventHandler(this.lbl_esccalar_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_close.Image = global::WindowsFormsApp1.Properties.Resources.close_black;
            this.lbl_close.Location = new System.Drawing.Point(727, 8);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 23);
            this.lbl_close.TabIndex = 6;
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_mini
            // 
            this.lbl_mini.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mini.Image = global::WindowsFormsApp1.Properties.Resources.minimize_black;
            this.lbl_mini.Location = new System.Drawing.Point(707, 8);
            this.lbl_mini.Name = "lbl_mini";
            this.lbl_mini.Size = new System.Drawing.Size(21, 23);
            this.lbl_mini.TabIndex = 7;
            this.lbl_mini.Click += new System.EventHandler(this.lbl_mini_Click);
            // 
            // lbl_help
            // 
            this.lbl_help.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help.Image = global::WindowsFormsApp1.Properties.Resources.help_black;
            this.lbl_help.Location = new System.Drawing.Point(686, 8);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(23, 23);
            this.lbl_help.TabIndex = 8;
            this.lbl_help.Click += new System.EventHandler(this.lbl_help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gráfica IL";
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.formGraph;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lbl_mini);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_esccalar);
            this.Controls.Add(this.chbEscalaY);
            this.Controls.Add(this.chbEscalaX);
            this.Controls.Add(this.txtEscala);
            this.Controls.Add(this.chart1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparacion Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grafica_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grafica_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtEscala;
        private System.Windows.Forms.CheckBox chbEscalaX;
        private System.Windows.Forms.CheckBox chbEscalaY;
        private System.Windows.Forms.Label lbl_esccalar;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_mini;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label label1;
    }
}