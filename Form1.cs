using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar a mi clase hija sumar
            Sumar suma = new Sumar();//instancie, o hice un nuevo objeto suma llamar al metodo de clase suma operar
            textBox3.Text = suma.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar a mi clase hija restar
            Restar resta = new Restar();//instancie, o hice un nuevo objeto suma llamar al metodo de clase resta operar
            textBox3.Text = resta.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void Mulriplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar a mi clase hija sumar
            Multiplicar multiplicar = new Multiplicar();//instancie, o hice un nuevo objeto suma llamar al metodo de clase suma operar
            textBox3.Text = multiplicar.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar a mi clase hija sumar
            Division dividir = new Division();//instancie, o hice un nuevo objeto suma llamar al metodo de clase suma operar
            textBox3.Text = dividir.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
