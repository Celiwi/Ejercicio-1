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
        int[] vector2 = new int[50];

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
            ListaMaxYMin.Items.Clear();
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
            ListaPosicion.Items.Clear();
            ListaPosicion.Items.Add("La posición 20 es " + vector[20]);
            ListaPosicion.Items.Add("La posición 30 es " + vector[30]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaAritmetica.Items.Clear();
            int acc = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                acc += vector[i];
            }
            ListaAritmetica.Items.Add("La media aritmetica es " + acc / vector.Length);
        }

        private void BotónOrdenar_Click(object sender, EventArgs e)
        {
            ListaOrden.Items.Clear();
            for (int i = 0; i < vector.Length - 1; i++)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotónBuscar_Click(object sender, EventArgs e)
        {
            ListaBuscar.Items.Clear();
            int num = Convert.ToInt16(TextoEscribir.Text);
            int acc = 0;

            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] == num)
                {
                    acc++;
                }
            }

            ListaBuscar.Items.Add(acc);
        }

        private void BotonInvertir_Click(object sender, EventArgs e)
        {
            ListaInvertir.Items.Clear();
            Array.Reverse(vector);

            for(int i = 0; i < vector.Length; i++)
            {
                ListaInvertir.Items.Add(vector[i]);
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            ListaReemplazar.Items.Clear();
            Array.Sort(vector);
            int num = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] == num)
                {
                    vector[i] = -1;
                }
                else
                {
                    num = vector[i];
                }
                ListaReemplazar.Items.Add(vector[i]);
            }
            
        }

        private void btnAleatorioRepeticiones_Click(object sender, EventArgs e)
        {
            ListaNoRepeticiones.Items.Clear();
            
            for(int i = 0; i < vector2.Length; i++)
            {
                Boolean continuar = true;
                
                while (continuar)
                {
                    int num = aleatorio.Next(100);
                    Boolean esta = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (vector2[j] == num)
                        {
                            esta = true;
                            
                        }
                    }
                    if(esta == false)
                        continuar = false;
                    vector2[i] = num;
                }
                
                ListaNoRepeticiones.Items.Add(vector2[i]);
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            ListaContar.Items.Clear();
            int mayores = 0, menores = 0;

            for(int i = 0; i < vector2.Length; i++)
            {
                if(vector2[i] > 25)
                {
                    mayores++;
                }
                if (vector2[i] < 25)
                {
                    menores++;
                }
            }

            ListaContar.Items.Add("Hay " + mayores + " números mayores de 25");
            ListaContar.Items.Add("Hay " + menores + " números menores de 25");
        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            ListaOrden2.Items.Clear();
            for (int i = 0; i < vector2.Length - 1; i++)
            {
                for (int j = 0; j < vector2.Length - 1 - i; j++)
                    if (vector2[j] > vector2[j + 1])
                    {
                        int aux;
                        aux = vector2[j];
                        vector2[j] = vector2[j + 1];
                        vector2[j + 1] = aux;
                    }

            }
            for (int i = 0; i < vector2.Length; i++)
            {
                ListaOrden2.Items.Add(vector2[i]);
            }
        }

        private void btnBuscarReemplazar_Click(object sender, EventArgs e)
        {
            ListaBuscarReemplazar.Items.Clear();
            int num = Convert.ToInt32(TextoEscribir2.Text);

            for (int i = 0; i < vector2.Length; i++)
            {
                //Compruebo si está
                if (vector2[i] == num)
                {
                    //Lo cambio por otro
                    for (int j = 0; j < vector2.Length; j++)
                    {
                        Boolean continuar = true;

                        while (continuar)
                        {
                            int num2 = aleatorio.Next(100);
                            Boolean esta = false;
                            for (int k = 0; k < j; k++)
                            {
                                if (vector2[k] == num2)
                                {
                                    esta = true;

                                }
                            }
                            if (esta == false)
                                continuar = false;
                            vector2[i] = num2;
                        }
                    }
                }
                ListaBuscarReemplazar.Items.Add(vector2[i]);
            }
        }

        private void btnBuscarContar_Click(object sender, EventArgs e)
        {
            ListaBuscarContar.Items.Clear();
            int num = Convert.ToInt32(TextoEscribir3.Text);
            int mayores = 0, menores = 0;

            for (int i = 0; i < vector2.Length; i++)
            {
                if (vector2[i] > num)
                {
                    mayores++;
                }
                if (vector2[i] < num)
                {
                    menores++;
                }
            }

            ListaBuscarContar.Items.Add("Hay " + mayores + " números mayores de " + num);
            ListaBuscarContar.Items.Add("Hay " + menores + " números menores de " + num);


        }
    }
}
