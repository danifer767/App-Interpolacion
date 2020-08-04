namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblGraficar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lbl_Interpolar = new System.Windows.Forms.Label();
            this.lblCargar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.lbl_help = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estado_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de texto (*.txt , *.tsv)|*.txt;*.tsv";
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.BackColor = System.Drawing.Color.Transparent;
            this.lblPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrueba.Location = new System.Drawing.Point(153, 66);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(25, 20);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "    ";
            // 
            // lblRango
            // 
            this.lblRango.BackColor = System.Drawing.Color.Transparent;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRango.Location = new System.Drawing.Point(140, 113);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(104, 41);
            this.lblRango.TabIndex = 3;
            this.lblRango.Text = "Rango de Interpolación";
            this.lblRango.Click += new System.EventHandler(this.lblRango_Click);
            // 
            // txtRango
            // 
            this.txtRango.BackColor = System.Drawing.Color.White;
            this.txtRango.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRango.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRango.Location = new System.Drawing.Point(277, 120);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(61, 28);
            this.txtRango.TabIndex = 4;
            this.txtRango.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt )|*.txt|Archivo separado por tabulaciones(*.tsv)|*.tsv";
            // 
            // lblGraficar
            // 
            this.lblGraficar.BackColor = System.Drawing.Color.Transparent;
            this.lblGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGraficar.Image = ((System.Drawing.Image)(resources.GetObject("lblGraficar.Image")));
            this.lblGraficar.Location = new System.Drawing.Point(23, 199);
            this.lblGraficar.Name = "lblGraficar";
            this.lblGraficar.Size = new System.Drawing.Size(132, 58);
            this.lblGraficar.TabIndex = 9;
            this.lblGraficar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblGuardar
            // 
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblGuardar.Image")));
            this.lblGuardar.Location = new System.Drawing.Point(229, 199);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(135, 58);
            this.lblGuardar.TabIndex = 8;
            this.lblGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuardar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Interpolar
            // 
            this.lbl_Interpolar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Interpolar.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Interpolar.Image")));
            this.lbl_Interpolar.Location = new System.Drawing.Point(31, 112);
            this.lbl_Interpolar.Name = "lbl_Interpolar";
            this.lbl_Interpolar.Size = new System.Drawing.Size(99, 43);
            this.lbl_Interpolar.TabIndex = 10;
            this.lbl_Interpolar.Click += new System.EventHandler(this.lbl_Interpolar_Click);
            // 
            // lblCargar
            // 
            this.lblCargar.BackColor = System.Drawing.Color.Transparent;
            this.lblCargar.Image = ((System.Drawing.Image)(resources.GetObject("lblCargar.Image")));
            this.lblCargar.Location = new System.Drawing.Point(31, 55);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(99, 43);
            this.lblCargar.TabIndex = 11;
            this.lblCargar.Click += new System.EventHandler(this.lblCargar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.textBox;
            this.label1.Location = new System.Drawing.Point(245, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 41);
            this.label1.TabIndex = 13;
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_close.Image = global::WindowsFormsApp1.Properties.Resources.close_black;
            this.lbl_close.Location = new System.Drawing.Point(364, 13);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(16, 16);
            this.lbl_close.TabIndex = 14;
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minimize.Image = global::WindowsFormsApp1.Properties.Resources.minimize_black;
            this.lbl_minimize.Location = new System.Drawing.Point(345, 13);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(16, 16);
            this.lbl_minimize.TabIndex = 15;
            this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
            // 
            // lbl_help
            // 
            this.lbl_help.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help.Image = global::WindowsFormsApp1.Properties.Resources.help_black;
            this.lbl_help.Location = new System.Drawing.Point(326, 13);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(16, 16);
            this.lbl_help.TabIndex = 16;
            this.lbl_help.Click += new System.EventHandler(this.lbl_help_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interpolación Lineal";
            // 
            // lbl_estado_info
            // 
            this.lbl_estado_info.AutoSize = true;
            this.lbl_estado_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado_info.ForeColor = System.Drawing.Color.White;
            this.lbl_estado_info.Location = new System.Drawing.Point(114, 169);
            this.lbl_estado_info.Name = "lbl_estado_info";
            this.lbl_estado_info.Size = new System.Drawing.Size(0, 20);
            this.lbl_estado_info.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 279);
            this.Controls.Add(this.lbl_estado_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lbl_minimize);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lblCargar);
            this.Controls.Add(this.lbl_Interpolar);
            this.Controls.Add(this.lblGraficar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Interpolacion Lineal V.1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblGraficar;
        private System.Windows.Forms.Label lbl_Interpolar;
        private System.Windows.Forms.Label lblCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_estado_info;
    }
}

