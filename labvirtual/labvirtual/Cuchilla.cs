using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.Sound;
using ShadowEngine.ContentLoading;

namespace labvirtual
{
    public class Cuchilla
    {
        Vector3 position;
        float speed = 0.02f;
        int soundCount;
        Mesh blade;

        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Cuchilla()
        {
            position = new Vector3(0, 2, 0);
        }

        public void Create(Mesh mesh)
        {
            this.blade = mesh; 
        }

        public void Move(Movement movement)
        {
            Vector3 pos = new Vector3(position);

            switch (movement)
            {
                case Movement.Forward:
                    pos.Y += 0.02f;
                    break;
                case Movement.Backward:
                    pos.Y -= 0.02f;
                    break;
                case Movement.Left:
                    pos.X -= 0.02f;
                    break;
                case Movement.Right:
                    pos.X += 0.02f;
                    break;
                default:
                    break;
            }

            if (pos.Y < 0.01f)// para que no parta la pieza
                return; 

            if (Controladora.Instancia.Solido.ChequearCollision(pos))
            {
                speed = 0.005f;
               // AudioPlayback.Play("metal-grinding.mp3");
            }
            else
                speed = 0.03f;

            switch (movement)
            {
                case Movement.Forward:
                    position.Y += speed;
                    break;
                case Movement.Backward:
                    position.Y -= speed;
                    break;
                case Movement.Left:
                    position.X -= speed;
                    break;
                case Movement.Right:
                    position.X += speed;
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            Gl.glColor3f(1, 1, 1);
            Gl.glPushMatrix();
            Gl.glTranslatef(Pieza.GlobalPos.X, Pieza.GlobalPos.Y, Pieza.GlobalPos.Z);
            Gl.glTranslatef(position.X, position.Y, position.Z);
            //Gl.glScalef(Pieza.Scale.X, Pieza.Scale.Y, Pieza.Scale.Z);
            Gl.glScalef(0.2f, 1, 1);
            Gl.glTranslatef(0, 0.5f, 0);
            Glut.glutSolidCube(1);
            Gl.glPopMatrix();
        }
    }
}
