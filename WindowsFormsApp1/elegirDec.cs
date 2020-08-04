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
    public partial class elegirDec : Form
    {
       public string sep_dec { get; set; }
        public elegirDec()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioPunto.Checked)
            {
               sep_dec  = "punto";
            } else if (radioComa.Checked)
            {
                sep_dec = "coma";
            }
            this.Close();
            }
        }
    }

