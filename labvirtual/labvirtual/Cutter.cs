using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine.ContentLoading;
using ShadowEngine;
using Tao.OpenGl;

namespace labvirtual
{
    class Cutter
    {
        ModelContainer m; // este es el que contiene el modelo

        public void Create()
        {
            m = ContentManager.GetModelByName("recortadora.3DS");
            m.CreateDisplayList(); // optimiza el modelo
        }

        public void Dibujar()
        {
            //Gl.glPushMatrix();

            //Gl.glTranslatef(-10, 0, 0); 
            //Gl.glScalef(0.03f, 0.03f, 0.03f); 
            //m.DrawWithTextures();

            //Gl.glPopMatrix(); 
        }
    }
}
