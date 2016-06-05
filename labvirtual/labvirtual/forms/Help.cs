using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labvirtual
{
    public partial class Ayuda : Form
    {
        static Ayuda instancia;

        public static Ayuda Instancia
        {
            get { return Ayuda.instancia; }
            set { Ayuda.instancia = value; }
        }

        public Ayuda()
        {
            instancia = this; 
            InitializeComponent();
        }
    }
}
