/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl;

namespace labvirtual
{
    public class Scene
    {
        Exterior exterior = new Exterior();
        Workshop local = new Workshop();
        Piece pieza = new Piece();
        Lathe torno = new Lathe();
        Cutter recortadora = new Cutter();


        List<ParticleEngine> generator = new List<ParticleEngine>(15);
        List<IParticle> particles = new List<IParticle>(110);

        public Lathe Torno
        {
            get { return torno; }
        }

        public Piece Pieza
        {
            get { return pieza; }
            set { pieza = value; }
        }

        public void Create()
        {
            local.Create();
            local.CrearColisiones();
            Sprite.Create();
            exterior.Crear();
            pieza.ConstruirPieza(1.2f);
            pieza.Create();
            torno.Create();
            recortadora.Create();  
        }

        #region particulas

        public void AddParticle(Particle particle)
        {
            for (int i = 0; i < particles.Count; i++)
            {
                if (particles[i].Death())
                {
                    particles[i] = (IParticle)particle;
                    return;
                }
            }
            particles.Add((IParticle)particle);
        }

        public void AddGenerator(ParticleEngine pGenerator)
        {
            // añado la lista de particulas al generador 
            pGenerator.AddList(particles);
            // añado al generador a la lista de generadores
            generator.Add(pGenerator);
        }

        public void ClearGenerator()
        {
            if (generator.Count == 0)
                return;
            ParticleEngine g = generator[generator.Count - 1];
            generator.Clear();
            generator.Add(g);
        }

        public void CleanGenerator()
        {
            generator.Clear();
        }

        public void Dibujar()
        {
            foreach (var item in generator)
            {
                item.GenerateParticle();
            }

            foreach (var item in particles)
            {
                item.Update();
            }

            // Dibuja las particulas
            //Gl.glDepthMask(Gl.GL_FALSE);

            //Gl.glDepthMask(Gl.GL_TRUE);

            local.Dibujar();
            exterior.Dibujar();
            pieza.Dibujar();
            torno.Dibujar();
            recortadora.Dibujar();

            foreach (var item in particles)
            {
                item.Draw();
            }

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }

        #endregion
    }
}
