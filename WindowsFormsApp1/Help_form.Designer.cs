namespace WindowsFormsApp1
{
    partial class Help_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_form));
            this.lbl_help1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_help2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_help1
            // 
            this.lbl_help1.AutoSize = true;
            this.lbl_help1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help1.ForeColor = System.Drawing.Color.White;
            this.lbl_help1.Location = new System.Drawing.Point(12, 36);
            this.lbl_help1.Name = "lbl_help1";
            this.lbl_help1.Size = new System.Drawing.Size(575, 208);
            this.lbl_help1.TabIndex = 0;
            this.lbl_help1.Text = resources.GetString("lbl_help1.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.close_black;
            this.label2.Location = new System.Drawing.Point(574, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_help2
            // 
            this.lbl_help2.AutoSize = true;
            this.lbl_help2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help2.ForeColor = System.Drawing.Color.White;
            this.lbl_help2.Location = new System.Drawing.Point(12, 36);
            this.lbl_help2.Name = "lbl_help2";
            this.lbl_help2.Size = new System.Drawing.Size(416, 80);
            this.lbl_help2.TabIndex = 2;
            this.lbl_help2.Text = resources.GetString("lbl_help2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ayuda";
            // 
            // Help_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.form1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_help2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_help1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help_form";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Help_form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_help1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_help2;
        private System.Windows.Forms.Label label1;
    }
}