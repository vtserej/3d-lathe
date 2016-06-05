using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace labvirtual
{
    public partial class PracticaForm : Form
    {
        static PracticaForm instancia;
        NumberFormatInfo provider = new NumberFormatInfo();

        public static PracticaForm Instancia
        {
            get { return PracticaForm.instancia; }
            set { PracticaForm.instancia = value; }
        }

        public PracticaForm()
        {
            InitializeComponent();
            instancia = this;
            provider.CurrencyDecimalSeparator = ".";
        }

        private void PiezaForm_Load(object sender, EventArgs e)
        {
            comboBoxMaterial.Items.Clear();
            foreach (var item in Main.Instancia.Materiales)
            {
                comboBoxMaterial.Items.Add(item.Key);
            }
            comboBoxLab.SelectedIndex = 2;

        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material m = Main.Instancia.Materiales[(string)comboBoxMaterial.SelectedItem];
            textBoxResistencia.Text = m.Resistencia.ToString(); ;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }
            if (textBoxRPMalta.Text == "")
            {
                MessageBox.Show("Debe seleccionar las RPM a alta velocidad");
                return;
            }
            if (textBoxRPMbaja.Text == "")
            {
                MessageBox.Show("Debe seleccionar las RPM a baja velocidad");
                return;
            }
            if (textBoxNA.Text == "")
            {
                MessageBox.Show("Debe teclear el nombre del alumno");
                return;
            }
            if (textBoxRadio.Text == "")
            {
                MessageBox.Show("Debe teclear el radio de la pieza");
                return;
            }
            if (textBoxMA.Text == "")
            {
                MessageBox.Show("Debe teclear el movimiento de avance");
                return;
            }

            if (Main.Instancia.PracticaIniciada == true)
            {
                Main.Instancia.Escena.Pieza.Resetear();
                Main.Instancia.Escena.Torno.Resetear();
            }

            int rpmA, rpmB;
            if (!int.TryParse(textBoxRPMalta.Text, out rpmA))
            {
                MessageBox.Show("Debe teclear un numero valido");
                return;
            }
            if (!int.TryParse(textBoxRPMbaja.Text, out rpmB))
            {
                MessageBox.Show("Debe teclear un numero valido");
                return;
            }
            float radio;

            if (!float.TryParse(textBoxRadio.Text, NumberStyles.Any, provider, out radio))
            {
                MessageBox.Show("Debe teclear un radio valido");
                return;
            }

            if (radio < 0.2f || radio > 1.2f)
            {
                MessageBox.Show("Debe teclear un radio valido");
                return;
            }

            float ma;
            if (!float.TryParse(textBoxMA.Text, out ma))
            {
                MessageBox.Show("Debe teclear un movimiento de avance valido");
                return;
            }


            Main.Instancia.Escena.Pieza.VelocidadAlta = ((rpmA / 60) * 360) / 40;
            Main.Instancia.Escena.Pieza.VelocidadBaja = ((rpmB / 60) * 360) / 40;

            Main.Instancia.Escena.Pieza.ConstruirPieza(radio);
            Main.Instancia.Escena.Torno.MovimientoAvance(ma);

            Main.Instancia.Escena.Pieza.Material = Main.Instancia.Materiales[(string)comboBoxMaterial.SelectedItem];
            Main.Instancia.PracticaIniciada = true;
            Main.Instancia.Practica = new Practice(textBoxNA.Text, DateTime.Now, Main.Instancia.Escena.Pieza);

            MainForm.Instancia.accionesToolStripMenuItem.Enabled = true;
            MainForm.Instancia.guardarPiezaToolStripMenuItem.Enabled = true;
            MainForm.Instancia.timerData.Enabled = true;
            Close();
        }
    }
}
