using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holaaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*Examen parcial    Laboratorio II     Valor : 30%
             Nombre: James Daniel Garcia 
             
            Tipo Practico : Elabore una aplicacion que cumpla con las especificaciones indicadas
            -cree un repositorio en Github.com y envie el enlace a messenger privado
            -tiempo: 2 horas

            Proyecto : Reloj (Simulacion)
            -Escrito en c#
            -El reloj debe mostrar
            *horas,minutos,segundos
            *cronometro
            *calendario */
            
       
            label1.Text = DateTime.Now.ToString("h:mm:ss");
            label2.Text = DateTime.Now.ToShortDateString();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
