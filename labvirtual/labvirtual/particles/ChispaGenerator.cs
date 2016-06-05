using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;

namespace labvirtual
{
    class ChispaGenerator : ParticleEngine
    {
        static bool stop;

        public static bool StopFire
        {
            get
            {
                return stop; 
            }
            set
            {
                stop = value; 
            }
        }

        public ChispaGenerator(Vector3 coordenada)
        {
            base.coordinate = coordenada;
        }

        public override void GenerateParticle()
        {
            if (base.death == false)
            {
                count++;
                if (count == 1)
                {
                    int len = randomize.Next(3) + 2;
                    for (int i = 0; i < len; i++)
                    {
                        AddParticle(new Chispa(coordinate.X , coordinate.Y, coordinate.Z));
                    }
                    count = 0; 
                    life++;
                }
                if (life == 16)
                {
                    base.death = true;
                }
            }       
        }
    }
}
