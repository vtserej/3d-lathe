using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShadowEngine;
using ShadowEngine.OpenGL;
using Tao.OpenGl;
using System.Runtime.InteropServices;
using ShadowEngine.Sound;

namespace labvirtual
{
    public partial class Ventana : Form
    {
        //handle del viewport
        uint hdc;
        Controladora controladora = new Controladora();
        int moviendo;
        static Vector2 formPos;

        public static Vector2 FormPos
        {
            get { return Ventana.formPos; }
            set { Ventana.formPos = value; }
        }

        public Ventana()
        {
            InitializeComponent();
            //identificador del lugar en donde voy a dibujar
            hdc = (uint)this.Handle;
            //toma el error que sucedio
            string error = "";
            //Comando de inicializacion de la ventana grafica
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);

            if (error != "")
            {
                MessageBox.Show("Ocurrio un error al inicializar OpenGl");
            }

            //inicia la posicion de la camara asi como define en angulo de perspectiva,etc etc
            //controladora.Camara.EstablecerPerspectiva();   
            controladora.Camara.InitCamara();

            //Habilita las luces
            Lighting.SetupLighting();
            ContentManager.SetTextureList("texturas\\"); //especifico la ubicacion de las texturas
            ContentManager.LoadTextures(); //las cargo
            ContentManager.SetModelList("modelo\\"); // especifico la ubicacion de la oficina
            ContentManager.LoadModels(); // la cargo 
            AudioPlayback.SoundDir = "sonidos\\";
            AudioPlayback.LoadSounds();

            //Color de fondo
            Gl.glClearColor(0.3f, 0.6f, 1, 1);//red green blue alpha 

            controladora.CrearObjetos();
        }

        private void tmrPaint_Tick(object sender, EventArgs e)
        {
            // limpia opengl para pintar
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //dibuja toda la escena
            controladora.Camara.Update(moviendo);
            controladora.DibujarEscena();
            //cambia los buffer
            SwapBuffers(hdc);
            //termina de pintar
            Gl.glFlush();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formPos = new Vector2(this.Left, this.Top);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                controladora.Torno.Cuchilla.Move(Movement.Left);
            }
            if (e.KeyCode == Keys.D)
            {
                controladora.Torno.Cuchilla.Move(Movement.Right);
            }
            if (e.KeyCode == Keys.W)
            {
                controladora.Torno.Cuchilla.Move(Movement.Forward);
            }
            if (e.KeyCode == Keys.S)
            {
                controladora.Torno.Cuchilla.Move(Movement.Backward);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            controladora.Solido.RebajarPieza(controladora.Torno.Cuchilla.Position);
        }

        private void pnlViewPort_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnlViewPort_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = 0;
        }

        [DllImport("GDI32.dll")]
        public static extern void SwapBuffers(uint hdc);

        private void bLeft_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(1, true);
        }

        private void bRight_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(0, true);
        }

        private void bLeft_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(-1, false);
        }

        private void bRight_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(-1, false);
        }

        private void bFow_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = 1;
        }

        private void bBack_MouseDown(object sender, MouseEventArgs e)
        {

            moviendo = -1;
        }

        private void bFow_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = 0;
        }

        private void Ventana_SizeChanged(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, this.Width, this.Height);
            //selecciono la matrix de proyección
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //la reseteo
            Gl.glLoadIdentity();
            //45 = angulo de vision
            //1  = proporcion de alto por ancho
            //0.1f = distancia minima en la que se pinta
            //1000 = distancia maxima
            Glu.gluPerspective(45, this.Width / (float)this.Height, 0.1f, 1000);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controladora.Solido.ShowcaseRotation = true;
        }

        private void encenderTornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encenderTornoToolStripMenuItem.Enabled = false;
            apagarTornoToolStripMenuItem.Enabled = true;
            controladora.Solido.Rotating = true;
            AudioPlayback.PlayOne("arranque.mp3");
            AudioPlayback.PlayLoop("trabajando.mp3");
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pieza.DrawMode = DrawMode.Poligonos;
        }

        private void mallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pieza.DrawMode = DrawMode.Mallas;
        }

        private void puntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pieza.DrawMode = DrawMode.Puntos;
        }

        private void apagarTornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encenderTornoToolStripMenuItem.Enabled = true;
            apagarTornoToolStripMenuItem.Enabled = false;
            controladora.Solido.Rotating = false;

            AudioPlayback.PlayOne("apagado.mp3");
            AudioPlayback.StopLoop("trabajando.mp3");
        }

        private void bUp_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(2, true);
        }

        private void bDown_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(3, true);
        }

        private void bDown_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(-1, false);
        }

        private void bUp_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Camara.RotarCamara(-1, false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controladora.Torno.MoverBase(0, -0.2f);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            controladora.Torno.MoverBase(0, 0.2f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controladora.Torno.MoverBase(0.2f, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladora.Torno.MoverBase(-0.2f, 0);
        }
    }
}
