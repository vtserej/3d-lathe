using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using ShadowEngine;
using System.Drawing;

namespace labvirtual
{
    class Chispa : Particle, IParticle
    {
        float x, y, z;
        float horzInc = 0.005f;
        float vertInc;

        int direction;

        public Chispa(float px, float py, float pz)
        {
            base.scale = 0.03f;
            alpha = 1;
            direction = Helper.Alternator();
            horzInc = (float)(randomizer.NextDouble() / 15) * direction;
            vertInc = (float)(randomizer.NextDouble() / 10) + 0.03f;

            x = px;
            y = py;
            z = pz;
            this.textureId = ContentManager.GetTextureByName("chispa.tga");
        }

        public bool Death()
        {
            return death;
        }

        public void Update()
        {
            alpha -= 0.02f;

            y -= vertInc;
            x += horzInc;
            time++;

            if (y < 0)
            {
                alpha = 0;
            }
        }

        public void Draw()
        {
            if (base.death == false)
            {
                if (alpha > 0)
                {
                    Gl.glDisable(Gl.GL_LIGHTING);
                    Gl.glColor4f(1.0f, 1.0f, 1.0f, alpha);
                    Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
                    Gl.glEnable(Gl.GL_BLEND);
                    Gl.glEnable(Gl.GL_TEXTURE_2D);
                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureId);
                    Gl.glPushMatrix();
                    Gl.glTranslated(x, y, z);
                    Gl.glRotatef(-Camera.Yaw, 0, 1, 0);
                    Gl.glRotatef(-Camera.Pitch, 1, 0, 0);
                    Gl.glScalef(base.scale, base.scale, base.scale);
                    Gl.glColor3ub(Color.Orange.R, Color.Orange.G, Color.Orange.B);
                    Gl.glCallList(initList);
                    Gl.glColor3f(1, 1, 1);
                    Gl.glPopMatrix();
                    Gl.glDisable(Gl.GL_BLEND);
                    Gl.glEnable(Gl.GL_LIGHTING);
                }
                else
                {
                    base.death = true;
                }
            }
        }
    }
}
