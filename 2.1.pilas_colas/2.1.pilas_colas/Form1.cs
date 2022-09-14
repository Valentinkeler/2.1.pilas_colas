using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1.pilas_colas
{
    public partial class Form1 : Form
    {
        
        Icollecction col;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPrimero.Text  = col.extraer().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPrimero.Text = col.primero().ToString();
        }

        private void estaVacio_Click(object sender, EventArgs e)
        {
            bool  estado  = col.estaVacia();
            if (estado)
            {
                rbtTrue.Checked=true;
                rbtFalse.Checked = false;
            }
            else
            {
                rbtFalse.Checked=true;
                rbtTrue.Checked =false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtAnadir.Text);
            bool estado= col.añadir(A);
            if (estado)
            {
                rbtTrue.Checked = true;
                rbtFalse.Checked = false;
            }
            else
            {
                rbtFalse.Checked = true;
                rbtTrue.Checked = false;
            }
        }
    }
}
