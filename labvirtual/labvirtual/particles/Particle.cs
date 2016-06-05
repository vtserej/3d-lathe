using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using ShadowEngine;

namespace labvirtual
{ 
    // Base class for particles
    public class Particle
    {
        protected int textureId;
        protected bool death;
        protected Vector3 position;
        protected static Random randomizer = new Random(); 
        protected int time;
        protected float alpha = 1;
        protected float scale = 1;
        protected static int initList = CreateParticle(); 

        static int CreateParticle()
        {
            initList = Gl.glGenLists(1);
            Gl.glNewList(initList, Gl.GL_COMPILE);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(0.5f, -0.5f, 0);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(0.5f, 0.5f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.5f, 0);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, -0.5f, 0);                 
            Gl.glEnd();
            Gl.glEndList();
            return initList; 
        }
    }
}
