/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using ShadowEngine.ContentLoading;
using Tao.OpenGl; 

namespace labvirtual
{
    public class Workshop
    {
        ModelContainer m;

        public void Create()
        {
            m = ContentManager.GetModelByName("taller.3DS");
            m.CreateDisplayList(); 
        }

        public void CrearColisiones()
        {
            Collision.AddCollisionSegment(new Point3D(-3.02f, -1.02f, 0), new Point3D(2.21f, -1.30f, 0), 0.5f);//torno
            
            CollisionPoint c = new CollisionPoint();
            c.ColitionDistance = 2;
            c.enabled = true; 
            c.point = new Point3D(-14.59f, -0.68f, 0);

            Collision.AddCollisionPoint(c);    

            Collision.AddCollisionSegment(new Point3D(-21.98f, 34.08f, 0), new Point3D(-22.27f, -14.35f, 0), 1); //pared lateral

            Collision.AddCollisionSegment(new Point3D(-22.27f, -14.35f, 0), new Point3D(14.28f, -14.85f, 0), 1); // pared del ventilador
        }

        public void Dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(10, -0.2f, 10);
            Gl.glScalef(0.1f, 0.1f, 0.1f);
            Gl.glColor3f(1, 1, 1);
            Gl.glRotatef(-90, 0, 1, 0); 
            m.DrawWithTextures();
            Gl.glDisable(Gl.GL_TEXTURE_2D);  
            Gl.glPopMatrix(); 
        }
    }
}
