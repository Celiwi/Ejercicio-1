using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int[] vector = new int[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            ListaAleatorio.Items.Clear();
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(100);
                ListaAleatorio.Items.Add(vector[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            int mayor = -1, menor = 101;
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                    menor = vector[i];
                else if (vector[i] > mayor)
                    mayor = vector[i];
            }
            ListaMaxYMin.Items.Add("El mayor es " + mayor);
            ListaMaxYMin.Items.Add("El menor es " + menor);
        }

        private void BtnPosiciones_Click(object sender, EventArgs e)
        {
            ListaPosicion.Items.Add("La posición 20 es " + vector[20]);
            ListaPosicion.Items.Add("La posición 30 es " + vector[30]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acc = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                acc += vector[i];
            }
            ListaAritmetica.Items.Add("La media aritmetica es " + acc / vector.Length);
        }

        private void BotónOrdenar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length -1 - i; j++)
                    if (vector[j] > vector[j + 1])
                    {
                        int aux;
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                    
            }
            for(int i = 0; i < vector.Length; i++)
            {
                ListaOrden.Items.Add(vector[i]);
            }
        }
    }
}
