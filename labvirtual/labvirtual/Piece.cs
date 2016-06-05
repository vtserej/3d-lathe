/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using System.Drawing;
using ShadowEngine;
using ShadowEngine.Sound;

namespace labvirtual
{
    public class Piece
    {
        #region private attributes

        const int arrSize = 128;
        float distPoints;
        Color color;
        Vector3[,] points = new Vector3[36, arrSize];
        static DrawMode drawMode;
        Material material;
        float radioCercano;
        float radio;

        //la cuchilla y la pieza deben compartir las mismas transformaciones para que los calculos de rebajados sean corrrectos
        static Vector3 scale;
        static Vector3 rotation;

        static Vector3 globalPos;

        bool rotating = false;
        bool showcaseRotation = false;
        int velocidadAlta = 40;
        int velocidadBaja = 20;
        bool apagando;
        float inercia;

        #endregion

        #region properties

        public int ArrSize
        {
            get { return arrSize; }
        }

        public Vector3[,] Points
        {
            get { return points; }
            set { points = value; }
        }

        public int VelocidadAlta
        {
            get { return velocidadAlta; }
            set { velocidadAlta = value; }
        }

        public int VelocidadBaja
        {
            get { return velocidadBaja; }
            set { velocidadBaja = value; }
        }

        public bool ShowcaseRotation
        {
            get { return showcaseRotation; }
            set { showcaseRotation = value; }
        }

        public bool Rotating
        {
            get { return rotating; }
            set { rotating = value; }
        }

        public static DrawMode DrawMode
        {
            get { return Piece.drawMode; }
            set { Piece.drawMode = value; }
        }

        public Color ColorSolido
        {
            get { return color; }
            set { color = value; }
        }

        public static Vector3 Scale
        {
            get { return Piece.scale; }
            set { Piece.scale = value; }
        }

        public static Vector3 Rotation
        {
            get { return Piece.rotation; }
            set { Piece.rotation = value; }
        }

        public static Vector3 GlobalPos
        {
            get { return Piece.globalPos; }
            set { Piece.globalPos = value; }
        }

        public Material Material
        {
            get { return material; }
            set { material = value; }
        }

        public float RadioCercano
        {
            get { return radioCercano; }
        }

        public float Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        #endregion

        public Piece()
        {
            color = Color.Gray;
            distPoints = 0.08f;
            drawMode = DrawMode.Poligonos;
            scale = new Vector3(0.2f, 0.2f, 0.2f);

            globalPos = new Vector3(-1.25f, 2.753f, -0.82f);
            globalPos.Scale(5);

            rotation = new Vector3(0, 0, 0);
        }

        public void Create()
        {
            material = new Material("ninguno", -1, "pieza_acero.jpg");
        }

        public float Resistencia()
        {
            if (Main.Instancia.Escena.Torno.TipoRevolucion == RevolutionType.High)
            {
                return material.Resistencia * 2;
            }
            return
                material.Resistencia * 1;
        }

        public void ConstruirPieza(float radio)
        {
            this.radio = radio;
            for (int i = 0; i < arrSize; i++)
            {
                Vector3 point = new Vector3();
                point.X = distPoints * i;
                point.Y = radio;

                points[0, i] = point;
            }
            RotarFuncion();
        }

        /// <summary>
        /// Esta funcion construye la pieza desde la segunda dimension
        /// es la que genera el solido de revolucion
        /// </summary>
        public void RotarFuncion()
        {
            Vector3 point;
            float angle = 90 - 360 / 36;
            for (int i = 1; i < 36; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    point = new Vector3();
                    point.X = points[0, j].X;
                    point.Y = points[0, j].Y * (float)Math.Sin(angle * Math.PI / 180);
                    point.Z = points[0, j].Y * (float)Math.Cos(angle * Math.PI / 180);
                    points[i, j] = point;
                }
                angle -= 10;
            }
        }

        /// <summary>
        /// Esta funcion rebaja la pieza en el indice deseado 
        /// </summary>
        private void RebajarRadio(int index, float radio)
        {
            Vector3 point;
            float angle = 90 - 360 / 36;
            for (int i = 0; i < 36; i++)
            {
                point = new Vector3();
                point.X = points[0, index].X;
                point.Y = radio * (float)Math.Sin(angle * Math.PI / 180);
                point.Z = radio * (float)Math.Cos(angle * Math.PI / 180);
                points[i, index] = point;
                angle -= 10;
            }
        }
        /// <summary>
        /// Esta funcion devuelve verdadero si la cuchilla colisiono con la pieza
        /// se usa para disminuir la velocidad y para activar el sonido de rebajado 
        /// </summary>
        public bool ChequearCollision(Vector3 point) // arreglarrrrrrrr
        {
            point.TranslateNeg(globalPos);

            int index = this.GetIndexRadioMasCercano(point);

            if (index > -1)
            {
                float radio = points[0, index].Y;
                radioCercano = radio;
                float distance = point.Z;
                if (distance < radio) // aki hay una collision
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Esta funcion te da el indice de el punto de la pieza que esta mas cerca 
        /// de la cuchilla en el eje X  
        /// </summary>
        private int GetIndexRadioMasCercano(Vector3 position)
        {
            for (int i = 0; i < arrSize; i++)
            {
                if (Math.Abs(position.X - points[0, i].X) < distPoints)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Esta funcion rebaja la pieza, la posicion que se pasa como parametro,
        /// es la posicion de la cuchilla 
        /// </summary>
        public void RebajarPieza(Vector3 position)
        {
            position.TranslateNeg(globalPos);

            int index = this.GetIndexRadioMasCercano(position);

            if (index > -1)
            {
                float radio = points[0, index].Y;
                float distance = position.Z;
                if (distance < radio) // aki hay una collision
                {
                    RebajarRadio(index, distance);
                }
            }
        }

        public void GuardarPieza()
        {

        }

        public void CargarPieza(Vector3[] arrPoints)
        {
            for (int i = 0; i < arrSize; i++)
            {
                points[0, i] = arrPoints[i];
            }
            RotarFuncion();
        }

        public void Resetear()
        {
            ConstruirPieza(1.2f);
        }

        /// <summary>
        /// Esta funcion dibuja los puntos de la pieza
        /// </summary>
        public void Dibujar()
        {
            //Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glPushMatrix();
            Gl.glScalef(scale.X, scale.Y, scale.Z);
            Gl.glTranslatef(globalPos.X, globalPos.Y, globalPos.Z);
            Gl.glColor3ub(color.R, color.G, color.B);
            Gl.glRotatef(rotation.Y, 0, 1, 0);
            Gl.glRotatef(rotation.X, 1, 0, 0);

            switch (drawMode)
            {
                case DrawMode.Mallas:
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
                    break;
                case DrawMode.Poligonos:
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
                    break;
                case DrawMode.Puntos:
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_POINT);
                    break;
                default:
                    break;
            }

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, material.TextureID);

            Gl.glBegin(Gl.GL_QUADS);
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < arrSize - 1; j++)
                {
                    float float_x = (float)i / 36.0f;		// Create A Floating Point X Value
                    float float_y = (float)j / 128f;		// Create A Floating Point Y Value
                    float float_xb = (float)(i + 1) / 36.0f;		// Create A Floating Point Y Value+0.0227f
                    float float_yb = (float)(j + 1) / 128f;		// Create A Floating Point Y Value+0.0227f


                    if (i == 35)
                    {
                        Gl.glTexCoord2f(float_x, float_y); Gl.glVertex3f(points[i, j].X, points[i, j].Y, points[i, j].Z);

                        Gl.glTexCoord2f(float_x, float_yb); Gl.glVertex3f(points[0, j].X, points[0, j].Y, points[0, j].Z);

                        Gl.glTexCoord2f(float_xb, float_yb); Gl.glVertex3f(points[0, j + 1].X, points[0, j + 1].Y, points[0, j + 1].Z);

                        Gl.glTexCoord2f(float_xb, float_y); Gl.glVertex3f(points[i, j + 1].X, points[i, j + 1].Y, points[i, j + 1].Z);
                    }
                    else
                    {
                        Gl.glTexCoord2f(float_x, float_y); Gl.glVertex3f(points[i, j].X, points[i, j].Y, points[i, j].Z);

                        Gl.glTexCoord2f(float_xb, float_y); Gl.glVertex3f(points[i + 1, j].X, points[i + 1, j].Y, points[i + 1, j].Z);

                        Gl.glTexCoord2f(float_xb, float_yb); Gl.glVertex3f(points[i + 1, j + 1].X, points[i + 1, j + 1].Y, points[i + 1, j + 1].Z);

                        Gl.glTexCoord2f(float_x, float_yb); Gl.glVertex3f(points[i, j + 1].X, points[i, j + 1].Y, points[i, j + 1].Z);
                    }
                }
            }
            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);

            for (int i = 0; i < 35; i++)
            {
                if (i == 34)
                {
                    Gl.glVertex3f(points[0, 0].X, 0, 0);
                    Gl.glVertex3f(points[i, 0].X, points[i, 0].Y, points[i, 0].Z);
                    Gl.glVertex3f(points[0, 0].X, points[0, 0].Y, points[0, 0].Z);

                    Gl.glVertex3f(points[0, arrSize - 1].X, 0, 0);
                    Gl.glVertex3f(points[i, arrSize - 1].X, points[i, arrSize - 1].Y, points[i, arrSize - 1].Z);
                    Gl.glVertex3f(points[0, arrSize - 1].X, points[0, arrSize - 1].Y, points[0, arrSize - 1].Z);
                }
                Gl.glVertex3f(points[0, 0].X, 0, 0);
                Gl.glVertex3f(points[i, 0].X, points[i, 0].Y, points[i, 0].Z);
                Gl.glVertex3f(points[i + 1, 0].X, points[i + 1, 0].Y, points[i + 1, 0].Z);

                Gl.glVertex3f(points[0, arrSize - 1].X, 0, 0);
                Gl.glVertex3f(points[i, arrSize - 1].X, points[i, arrSize - 1].Y, points[i, arrSize - 1].Z);
                Gl.glVertex3f(points[i + 1, arrSize - 1].X, points[i + 1, arrSize - 1].Y, points[i + 1, arrSize - 1].Z);


            }

            //for (int i = 0; i < 35; i++)
            //{
            //    Gl.glVertex3f(points[i, 35].X, 0, 0);
            //    Gl.glVertex3f(points[i, 35].X, points[i, 35].Y, points[i, 35].Z);
            //    Gl.glVertex3f(points[i + 1, 35].X, points[i + 1, 35].Y, points[i + 1, 35].Z);
            //}

            Gl.glEnd();

            Gl.glColor3f(1, 1, 1);
            Gl.glPopMatrix();
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);

            if (showcaseRotation)
            {
                rotation.Y += 1;
            }
            if (rotating)
            {
                if (apagando)
                {
                    rotation.X += inercia;
                    inercia -= 0.5f;
                    if (inercia < 0)
                    {
                        apagando = false;
                        rotating = false;
                    }
                }
                else
                {
                    if (Main.Instancia.Escena.Torno.TipoRevolucion == RevolutionType.High)
                    {
                        rotation.X += velocidadAlta;
                    }
                    else
                    {
                        rotation.X += velocidadBaja;
                    }
                }
            }
        }

        /// <summary>
        /// Esta funcion para el movimiento de la pieza y se encarga de frenarla suavemente
        /// </summary>
        public void PararPieza()
        {
            apagando = true;
            if (Main.Instancia.Escena.Torno.TipoRevolucion == RevolutionType.High)
            {
                inercia = velocidadAlta;
            }
            else
            {
                inercia = velocidadBaja;
            }
        }

        /// <summary>
        /// Esta funcion se encarga de poner en movimiento la pieza nuevamente
        /// </summary>
        public void MoverPieza()
        {
            apagando = false;
            rotating = true;
        }
    }
}
