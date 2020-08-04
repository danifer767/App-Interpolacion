using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Help_form : Form
    {
        public Point mouse_offset;
        public Help_form(string ventana)
        {
            InitializeComponent();
            if (ventana == "principal")
            {
                lbl_help2.Visible = false;
                lbl_help1.Visible = true;

            }else if ( ventana == "grafica")
            {
                lbl_help1.Visible = false;
                lbl_help2.Visible = true;
            }
            else
            {
                lbl_help2.Visible = false;
                lbl_help1.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void Help_form_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Help_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }
    }
}
