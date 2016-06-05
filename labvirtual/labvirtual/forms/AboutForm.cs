using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labvirtual
{
    public partial class AcercaDeForm : Form
    {
        static AcercaDeForm instancia;

        public static AcercaDeForm Instancia
        {
            get { return AcercaDeForm.instancia; }
            set { AcercaDeForm.instancia = value; }
        }
        public AcercaDeForm()
        {
            instancia = this;
            InitializeComponent();
        }
    }
}
