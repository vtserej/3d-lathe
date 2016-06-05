using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using ShadowEngine.ContentLoading;
using Tao.OpenGl; 

namespace labvirtual
{
    public class Local
    {
        ModelContainer m;

        public void Create()
        {
            m = ContentManager.GetModelByName("jovenClub.3DS");
            m.CreateDisplayList(); 
        }

        public void CrearColisiones()
        {
            Collision.AddCollisionSegment(new Point3D(-8.7f, -28.5f, 0), new Point3D(-8.7f, 20.9f, 0), 1);//derecha
            Collision.AddCollisionSegment(new Point3D(-8.7f, 20.9f, 0), new Point3D(10.3f, 20.9f, 0), 1); //pizarra
            Collision.AddCollisionSegment(new Point3D(10.3f, 20.9f, 0), new Point3D(10.3f, -28.5f, 0), 1); // izquierda
            Collision.AddCollisionSegment(new Point3D(10.3f, -28.5f, 0), new Point3D(-8.7f, -28.5f, 0), 1);//atras
            Collision.AddCollisionSegment(new Point3D(3.5f, -13, 0), new Point3D(10.3f, -13, 0), 1); //entrada izquierda
            Collision.AddCollisionSegment(new Point3D(1.3f, -13, 0), new Point3D(-8.7f, -13, 0), 1);//entrada derecha
        }

        public void Dibujar()
        {
            Gl.glPushMatrix(); 
            Gl.glScalef(0.2f, 0.2f, 0.2f);
            Gl.glColor3f(1, 1, 1); 
            m.DrawWithTextures();
            Gl.glDisable(Gl.GL_TEXTURE_2D);  
            Gl.glPopMatrix(); 
        }
    }
}
