namespace labvirtual
{
    partial class Ventana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDown = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bFow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrPaint = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPiezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPiezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encenderTornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarTornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.camara1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.bDown);
            this.panel2.Controls.Add(this.bUp);
            this.panel2.Controls.Add(this.bBack);
            this.panel2.Controls.Add(this.bFow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bRight);
            this.panel2.Controls.Add(this.bLeft);
            this.panel2.Controls.Add(this.lblRotacion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(9, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 195);
            this.panel2.TabIndex = 6;
            // 
            // bDown
            // 
            this.bDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDown.Location = new System.Drawing.Point(85, 103);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(45, 35);
            this.bDown.TabIndex = 8;
            this.bDown.Text = "|";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bDown_MouseDown);
            this.bDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bDown_MouseUp);
            // 
            // bUp
            // 
            this.bUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUp.Location = new System.Drawing.Point(85, 28);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(45, 35);
            this.bUp.TabIndex = 7;
            this.bUp.Text = "|";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bUp_MouseDown);
            this.bUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bUp_MouseUp);
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(152, 156);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(45, 35);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "-";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bBack_MouseDown);
            this.bBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bFow_MouseUp);
            this.bBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // bFow
            // 
            this.bFow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFow.Location = new System.Drawing.Point(12, 156);
            this.bFow.Name = "bFow";
            this.bFow.Size = new System.Drawing.Size(49, 36);
            this.bFow.TabIndex = 5;
            this.bFow.Text = "+";
            this.bFow.UseVisualStyleBackColor = true;
            this.bFow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bFow_MouseDown);
            this.bFow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bFow_MouseUp);
            this.bFow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movimiento";
            // 
            // bRight
            // 
            this.bRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRight.Location = new System.Drawing.Point(158, 63);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(45, 35);
            this.bRight.TabIndex = 3;
            this.bRight.Text = "->";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bRight_MouseDown);
            this.bRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bRight_MouseUp);
            this.bRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // bLeft
            // 
            this.bLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLeft.Location = new System.Drawing.Point(18, 63);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(49, 36);
            this.bLeft.TabIndex = 2;
            this.bLeft.Text = "<-";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bLeft_MouseDown);
            this.bLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bLeft_MouseUp);
            this.bLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotacion.Location = new System.Drawing.Point(82, 75);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(58, 13);
            this.lblRotacion.TabIndex = 1;
            this.lblRotacion.Text = "Rotación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Movimientos de cámara";
            // 
            // tmrPaint
            // 
            this.tmrPaint.Enabled = true;
            this.tmrPaint.Interval = 25;
            this.tmrPaint.Tick += new System.EventHandler(this.tmrPaint_Tick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem,
            this.configurarToolStripMenuItem,
            this.visualizacionToolStripMenuItem,
            this.camaraToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1024, 24);
            this.menuStripMain.TabIndex = 19;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cargarPiezaToolStripMenuItem,
            this.guardarPiezaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "Nueva pieza";
            // 
            // cargarPiezaToolStripMenuItem
            // 
            this.cargarPiezaToolStripMenuItem.Name = "cargarPiezaToolStripMenuItem";
            this.cargarPiezaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cargarPiezaToolStripMenuItem.Text = "Cargar pieza";
            // 
            // guardarPiezaToolStripMenuItem
            // 
            this.guardarPiezaToolStripMenuItem.Name = "guardarPiezaToolStripMenuItem";
            this.guardarPiezaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.guardarPiezaToolStripMenuItem.Text = "Guardar pieza";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encenderTornoToolStripMenuItem,
            this.apagarTornoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // encenderTornoToolStripMenuItem
            // 
            this.encenderTornoToolStripMenuItem.Name = "encenderTornoToolStripMenuItem";
            this.encenderTornoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.encenderTornoToolStripMenuItem.Text = "Encender torno";
            this.encenderTornoToolStripMenuItem.Click += new System.EventHandler(this.encenderTornoToolStripMenuItem_Click);
            // 
            // apagarTornoToolStripMenuItem
            // 
            this.apagarTornoToolStripMenuItem.Enabled = false;
            this.apagarTornoToolStripMenuItem.Name = "apagarTornoToolStripMenuItem";
            this.apagarTornoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.apagarTornoToolStripMenuItem.Text = "Apagar torno";
            this.apagarTornoToolStripMenuItem.Click += new System.EventHandler(this.apagarTornoToolStripMenuItem_Click);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // visualizacionToolStripMenuItem
            // 
            this.visualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poligonosToolStripMenuItem,
            this.mallasToolStripMenuItem,
            this.puntosToolStripMenuItem});
            this.visualizacionToolStripMenuItem.Name = "visualizacionToolStripMenuItem";
            this.visualizacionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.visualizacionToolStripMenuItem.Text = "Visualizacion";
            // 
            // poligonosToolStripMenuItem
            // 
            this.poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            this.poligonosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.poligonosToolStripMenuItem.Text = "Poligonos";
            this.poligonosToolStripMenuItem.Click += new System.EventHandler(this.poligonosToolStripMenuItem_Click);
            // 
            // mallasToolStripMenuItem
            // 
            this.mallasToolStripMenuItem.Name = "mallasToolStripMenuItem";
            this.mallasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mallasToolStripMenuItem.Text = "Mallas";
            this.mallasToolStripMenuItem.Click += new System.EventHandler(this.mallasToolStripMenuItem_Click);
            // 
            // puntosToolStripMenuItem
            // 
            this.puntosToolStripMenuItem.Name = "puntosToolStripMenuItem";
            this.puntosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.puntosToolStripMenuItem.Text = "Puntos";
            this.puntosToolStripMenuItem.Click += new System.EventHandler(this.puntosToolStripMenuItem_Click);
            // 
            // camaraToolStripMenuItem
            // 
            this.camaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camara1ToolStripMenuItem,
            this.camara2ToolStripMenuItem,
            this.camara3ToolStripMenuItem,
            this.camara4ToolStripMenuItem});
            this.camaraToolStripMenuItem.Name = "camaraToolStripMenuItem";
            this.camaraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.camaraToolStripMenuItem.Text = "Camara";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 152);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(85, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "|";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(85, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "|";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(158, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(18, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 36);
            this.button6.TabIndex = 2;
            this.button6.Text = "<-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Movimientos del torno";
            // 
            // camara1ToolStripMenuItem
            // 
            this.camara1ToolStripMenuItem.Name = "camara1ToolStripMenuItem";
            this.camara1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camara1ToolStripMenuItem.Text = "Camara 1";
            // 
            // camara2ToolStripMenuItem
            // 
            this.camara2ToolStripMenuItem.Name = "camara2ToolStripMenuItem";
            this.camara2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camara2ToolStripMenuItem.Text = "Camara 2";
            // 
            // camara3ToolStripMenuItem
            // 
            this.camara3ToolStripMenuItem.Name = "camara3ToolStripMenuItem";
            this.camara3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camara3ToolStripMenuItem.Text = "Camara 3";
            // 
            // camara4ToolStripMenuItem
            // 
            this.camara4ToolStripMenuItem.Name = "camara4ToolStripMenuItem";
            this.camara4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.camara4ToolStripMenuItem.Text = "Camara 4";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio virtual";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.Ventana_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPaint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bFow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPiezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarPiezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encenderTornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarTornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem camara1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara4ToolStripMenuItem;
    }
}

