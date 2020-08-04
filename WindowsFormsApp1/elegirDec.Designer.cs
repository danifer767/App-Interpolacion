namespace WindowsFormsApp1
{
    partial class elegirDec
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPunto = new System.Windows.Forms.RadioButton();
            this.radioComa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioComa);
            this.groupBox1.Controls.Add(this.radioPunto);
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separador Decimal";
            // 
            // radioPunto
            // 
            this.radioPunto.AutoSize = true;
            this.radioPunto.Location = new System.Drawing.Point(21, 29);
            this.radioPunto.Name = "radioPunto";
            this.radioPunto.Size = new System.Drawing.Size(83, 17);
            this.radioPunto.TabIndex = 0;
            this.radioPunto.TabStop = true;
            this.radioPunto.Text = "Punto (0.01)";
            this.radioPunto.UseVisualStyleBackColor = true;
            // 
            // radioComa
            // 
            this.radioComa.AutoSize = true;
            this.radioComa.Location = new System.Drawing.Point(21, 57);
            this.radioComa.Name = "radioComa";
            this.radioComa.Size = new System.Drawing.Size(82, 17);
            this.radioComa.TabIndex = 1;
            this.radioComa.TabStop = true;
            this.radioComa.Text = "Coma (0,01)";
            this.radioComa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(99, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elegirDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 174);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "elegirDec";
            this.Text = "Seleecionar Separador Decimal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioComa;
        private System.Windows.Forms.RadioButton radioPunto;
        private System.Windows.Forms.Button button1;
    }
}