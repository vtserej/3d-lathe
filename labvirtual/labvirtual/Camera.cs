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


namespace labvirtual
{
    public class Camera
    {
        #region Camera constants
        const double div1 = Math.PI / 180;
        const double div2 = 180 / Math.PI;
        #endregion

        #region Private atributes

        static float eyex, eyey, eyez;
        static float centerx, centery, centerz;
        static float forwardSpeed = 0.2f;
        static float yaw, pitch;
        static float rotationSpeed = 1 / 7f;
        static double i, j, k;
        bool libre = true;
        int difX;
        int difY;
        bool camaraRotando;
        int sentidoYaw;
        int sentidoPitch;

        #endregion

        #region properties

        public static float Pitch
        {
            get { return Camera.pitch; }
            set { Camera.pitch = value; }
        }

        public bool Libre
        {
            get { return libre; }
            set { libre = value; }
        }

        public static float Yaw
        {
            get { return Camera.yaw; }
            set { Camera.yaw = value; }
        }

        #endregion

        public void InitCamara()
        {
            eyex = 0f;
            eyey = 5f;
            eyez = 5f;
            centerx = 0;
            centery = 2;
            centerz = 0;
            Look();
        }

        public void SetCamara(int numero)
        {
            switch (numero)
            {
                case 1:
                    eyex = 0.27f;
                    eyey = 6.58f;
                    eyez = 4;
                    yaw = 0;
                    pitch = 63;
                    UpdateDirVector();
                    Look();
                    break;
                case 2:
                    eyex = 0.27f;
                    eyey = 4.71f;
                    eyez = 1.30f;
                    yaw = 0;
                    pitch = 63;
                    UpdateDirVector();
                    Look();
                    break;
                case 3:
                    eyex = 6.03f;
                    eyey = 4.72f;
                    eyez = -0.43f;
                    yaw = -87;
                    pitch = 156;
                    UpdateDirVector();
                    Look();
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public void EstablecerPerspectiva()
        {
            //selecciono la matrix de proyección
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //la reseteo
            Gl.glLoadIdentity();
            //45 = angulo de vision
            //1  = proporcion de alto por ancho
            //0.1f = distancia minima en la que se pinta
            //1000 = distancia maxima
            Glu.gluPerspective(55, Globals.ScreenProportion, 0.1f, 150);
        }

        public void LookSelection()
        {
            Glu.gluLookAt(eyex, eyey, eyez, centerx, centery, centerz, 0, 1, 0);
        }

        public void Look()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);//0.27 4.17 1.30
            Gl.glLoadIdentity();
            Gl.glMatrixMode(Gl.GL_PROJECTION);//0.27 4.17 1.30
            Gl.glLoadIdentity();
            Glu.gluPerspective(55, Globals.ScreenProportion, 0.1f, 190);
            Glu.gluLookAt(eyex, eyey, eyez, centerx, centery, centerz, 0, 1, 0);
        }

        static public float AngleToRad(double pAngle)
        {
            return (float)(pAngle * div1);
        }

        static public float RadToAngle(double pAngle)
        {
            return (float)(pAngle * div2);
        }

        public void RotarCamara(int sentidoYaw, int sentidoPitch, bool rotacion)
        {
            camaraRotando = rotacion;
            this.sentidoYaw = sentidoYaw;
            this.sentidoPitch = sentidoPitch;
        }

        public void UpdateDirVector()
        {
            k = Math.Cos(AngleToRad((double)yaw));
            i = -Math.Sin(AngleToRad((double)yaw));
            j = Math.Sin(AngleToRad((double)pitch));
            centerz = eyez - (float)k;
            centerx = eyex - (float)i;
            centery = eyey - (float)j;
        }

        public void Mover(int delta)
        {
            if (delta == 0 )
            {
                return ;
            }
            float sp = delta / 400f;
            if (!Collision.CheckCollision(new Point3D(eyex - (float)i * sp, eyez - (float)k * sp, 0)))
            {
                eyex -= (float)i * sp;
                eyez -= (float)k * sp;
                if ((eyey - (float)j * sp) > 1 && (eyey - (float)j * sp) < 14f)
                {
                    eyey -= (float)j * sp;
                }
            }
        }

        public void Update(int pressedButton)
        {
            #region Camara de apuntar

            if (camaraRotando)
            {
                switch (sentidoYaw)
                {
                    case 1:
                        difX += 15;
                        yaw -= rotationSpeed * -difX;
                        break;
                    case 2:
                        difX -= 15;
                        yaw += rotationSpeed * difX;
                        break;
                }
                switch (sentidoPitch)
                {
                    case 1:
                        difY -= 15;
                        pitch += rotationSpeed * difY;
                        break;
                    case 2:
                        difY += 15;
                        pitch -= rotationSpeed * -difY;
                        break;
                    default:
                        break;
                }
            }
            UpdateDirVector();
            difX = 0;
            difY = 0;

            if (pressedButton == 1) // se apreto el boton izquierdo de mouse
            {
                if (!Collision.CheckCollision(new Point3D(eyex - (float)i * forwardSpeed, eyez - (float)k * forwardSpeed, 0)))
                {
                    eyex -= (float)i * forwardSpeed;
                    eyez -= (float)k * forwardSpeed;
                    if ((eyey - (float)j * forwardSpeed) > 1 && (eyey - (float)j * forwardSpeed) < 14f)
                    {
                        eyey -= (float)j * forwardSpeed;
                    }
                }
            }
            else
                if (pressedButton == -1) // se apreto el boton derecho del mouse
                {
                    if (!Collision.CheckCollision(new Point3D(eyex + (float)i * forwardSpeed, eyez + (float)k * forwardSpeed, 0)))
                    {
                        eyex += (float)i * forwardSpeed;
                        eyez += (float)k * forwardSpeed;
                        if ((eyey + (float)j * forwardSpeed) > 1 && (eyey + (float)j * forwardSpeed) < 14f)
                        {
                            eyey += (float)j * forwardSpeed;
                        }
                    }
                }

            #endregion

            Look();
        }
    }
}
