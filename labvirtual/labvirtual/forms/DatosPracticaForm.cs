using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labvirtual
{
    public partial class DatosPracticaForm : Form
    {
        static DatosPracticaForm instancia;

        public static DatosPracticaForm Instancia
        {
            get { return DatosPracticaForm.instancia; }
            set { DatosPracticaForm.instancia = value; }
        }

        public DatosPracticaForm()
        {
            instancia = this;
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void DatosPracticaForm_Load(object sender, EventArgs e)
        {
            textBoxRadio.Text = Main.Instancia.Practica.Pieza.Radio.ToString();     
            textBoxNA.Text = Main.Instancia.Practica.NombreAlumno;
            textBoxTM.Text = Main.Instancia.Practica.Pieza.Material.Nombre;
            textBoxResistencia.Text = Main.Instancia.Practica.Pieza.Material.Resistencia.ToString();
        }
    }
}
