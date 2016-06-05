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
    public partial class MainForm : Form
    {
        //handle del viewport
        uint hdc;
        Main controladora = new Main();
        int moviendo;
        static Vector2 formPos;
        bool pressed;
        Point p;
        static MainForm instancia;

        public static MainForm Instancia
        {
            get { return MainForm.instancia; }
        }

        public static Vector2 FormPos
        {
            get { return MainForm.formPos; }
            set { MainForm.formPos = value; }
        }

        public MainForm()
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

            //Habilita las luces
            Lighting.SetupLighting();
            ContentManager.SetTextureList("texturas_low\\"); //especifico la ubicacion de las texturas
            ContentManager.LoadTextures(); //las cargo
            ContentManager.SetModelList("modelo\\"); // especifico la ubicacion de la oficina
            ContentManager.LoadModels(); // la cargo 
            AudioPlayback.SoundDir = "sonidos\\";
            AudioPlayback.LoadSounds();

            //Color de fondo
            Gl.glClearColor(0.3f, 0.6f, 1, 1);//red green blue alpha 

            controladora.Create();
            //controladora.Camara.EstablecerPerspectiva();   
            controladora.Camara.SetCamara(1);

            //formularios
            PracticaForm.Instancia = new PracticaForm();
            AcercaDeForm.Instancia = new AcercaDeForm();
            DatosPracticaForm.Instancia = new DatosPracticaForm();  

            Ayuda.Instancia = new Ayuda();

            instancia = this;

            this.MouseWheel += new MouseEventHandler(MainForm_MouseWheel);
            this.MouseMove += new MouseEventHandler(MainForm_MouseWheel);
        }

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            controladora.Camara.Mover(e.Delta);  
        }

        private void tmrPaint_Tick(object sender, EventArgs e)
        {
            // limpia opengl para pintar
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //dibuja toda la escena
            controladora.Camara.Update(moviendo);
            controladora.DibujarEscena();
            //cambia los buffer
            WinApi.SwapBuffers(hdc);
            //termina de pintar
            Gl.glFlush();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formPos = new Vector2(this.Left, this.Top);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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

            Globals.ScreenProportion = this.Width / (float)this.Height;

            //45 = angulo de vision
            //1  = proporcion de alto por ancho
            //0.1f = distancia minima en la que se pinta
            //1000 = distancia maxima
            Glu.gluPerspective(45, Globals.ScreenProportion, 0.1f, 1000);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            panelButtons.Width = this.Width;
        }

        private void encenderTornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encenderTornoToolStripMenuItem.Enabled = false;
            apagarTornoToolStripMenuItem.Enabled = true;
            controladora.Escena.Torno.Encender();
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piece.DrawMode = DrawMode.Poligonos;
        }

        private void mallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piece.DrawMode = DrawMode.Mallas;
        }

        private void puntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piece.DrawMode = DrawMode.Puntos;
        }

        private void apagarTornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encenderTornoToolStripMenuItem.Enabled = true;
            apagarTornoToolStripMenuItem.Enabled = false;
            controladora.Escena.Torno.Encender();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controladora.Escena.Torno.MoverBase(Movement.Left);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            controladora.Escena.Torno.MoverBase(Movement.Right);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controladora.Escena.Torno.MoverBase(Movement.Forward);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladora.Escena.Torno.MoverBase(Movement.Backward);
        }

        private void camara1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controladora.Camara.SetCamara(1);
        }

        private void camara2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controladora.Camara.SetCamara(2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tmrPaint.Enabled = false;
            AudioPlayback.PauseAllSounds(); 
            PracticaForm.Instancia.ShowDialog();
            tmrPaint.Enabled = true;
            AudioPlayback.ResumeAllSounds();  
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = true;
            controladora.Escena.Torno.Movimiento = Movement.Left;
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = false;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = true;
            controladora.Escena.Torno.Movimiento = Movement.Right;
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = false;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = true;
            controladora.Escena.Torno.Movimiento = Movement.Forward;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = true;
            controladora.Escena.Torno.Movimiento = Movement.Backward;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            controladora.Escena.Torno.Moviendo = false;
        }

        private void camara3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controladora.Camara.SetCamara(3);
        }

        private void Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //moviendo = 1;
                //aki va el codigo de la ayuda
                ///return;
            }

            pressed = true;
            p = e.Location;

            //tmrPaint.Enabled = false;  
            string name = controladora.Escena.Torno.PieceSelection(e.X, e.Y + 32);
            //tmrPaint.Enabled = true;  

            if (name == String.Empty)
            {
                labelSelectedPiece.Text = "Ninguna";
            }
            else
                labelSelectedPiece.Text = name;

            controladora.Escena.Torno.AccionesTorno(name);
            this.Encender();
        }

        private void Ventana_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            moviendo = 0;
            controladora.Camara.RotarCamara(-1, -1, false);
        }

        private void Ventana_MouseMove(object sender, MouseEventArgs e)
        {
            int tolerance = 17;
            Point np = e.Location;
            int sentidoYaw = 0;
            int sentidoPitch = 0;
            if (pressed)
            {
                if (np.X - p.X > tolerance)
                {
                    sentidoYaw = 1;
                }
                else
                    if (np.X - p.X < -tolerance)
                    {
                        sentidoYaw = 2;
                    }
                if (np.Y - p.Y > tolerance)
                {
                    sentidoPitch = 2;
                }
                else
                    if (np.Y - p.Y < -tolerance)
                    {
                        sentidoPitch = 1;
                    }
                controladora.Camara.RotarCamara(sentidoYaw, sentidoPitch, true);
            }
        }

        private void altaRevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controladora.Escena.Torno.TipoRevolucion = RevolutionType.High;
        }

        private void bajaRevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controladora.Escena.Torno.TipoRevolucion = RevolutionType.Low;
        }

        private void Encender()
        {
            if (controladora.Escena.Torno.Encendido)
            {
                encenderTornoToolStripMenuItem.Enabled = false;
                apagarTornoToolStripMenuItem.Enabled = true;
            }
            else
            {
                encenderTornoToolStripMenuItem.Enabled = true;
                apagarTornoToolStripMenuItem.Enabled = false;
            }
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ayuda.Instancia.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeForm.Instancia.ShowDialog();
        }

        private void cargarPiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrPaint.Enabled = false;
            //AudioPlayback.PauseAllSounds();

            openFileDialog1.DefaultExt = ".xml";
            openFileDialog1.Filter = "Documentos XML (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                controladora.Practica.LoadPractica(openFileDialog1.FileName);
                Main.Instancia.PracticaIniciada = true;

                accionesToolStripMenuItem.Enabled = true;
                guardarPiezaToolStripMenuItem.Enabled = true;
                timerData.Enabled = true;
            }

            tmrPaint.Enabled = true;
            //AudioPlayback.ResumeAllSounds();
        }

        private void guardarPiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrPaint.Enabled = false;
            //AudioPlayback.PauseAllSounds();
            
            saveFileDialog1.DefaultExt = ".xml";
            saveFileDialog1.Filter = "Documentos XML (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                controladora.Practica.SavePractica(saveFileDialog1.FileName);
            }

            tmrPaint.Enabled = true;
            //AudioPlayback.ResumeAllSounds(); 
        }

        private void desactivarAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioPlayback.CanPlay = false;  
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            labelRV.Text = controladora.Escena.Pieza.RadioCercano.ToString();
            labelPC.Text = controladora.Escena.Torno.BaseTornoPos.X.ToString();  
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verPracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!controladora.PracticaIniciada)
            {
                MessageBox.Show("La practica no ha sido iniciada, todavia");
                return;
            }

            tmrPaint.Enabled = false;
            //AudioPlayback.PauseAllSounds();

            DatosPracticaForm.Instancia.ShowDialog();

            tmrPaint.Enabled = true;
            //AudioPlayback.ResumeAllSounds(); 
        }
    }
}
