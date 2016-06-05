using System;
using System.Collections.Generic;
using System.Text;

namespace labvirtual
{
    public interface IParticle
    {
        bool Death();

        void Update();

        void Draw();
    }
}
