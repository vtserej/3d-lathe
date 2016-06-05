namespace labvirtual
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelPC = new System.Windows.Forms.Label();
            this.labelPosicionC = new System.Windows.Forms.Label();
            this.labelRV = new System.Windows.Forms.Label();
            this.labelRadio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectedPiece = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bFow = new System.Windows.Forms.Button();
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
            this.altaRevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaRevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAjustes = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verPracticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelButtons.Controls.Add(this.labelPC);
            this.panelButtons.Controls.Add(this.labelPosicionC);
            this.panelButtons.Controls.Add(this.labelRV);
            this.panelButtons.Controls.Add(this.labelRadio);
            this.panelButtons.Controls.Add(this.label3);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.labelSelectedPiece);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button6);
            this.panelButtons.Controls.Add(this.button5);
            this.panelButtons.Controls.Add(this.bBack);
            this.panelButtons.Controls.Add(this.bFow);
            this.panelButtons.Location = new System.Drawing.Point(0, 24);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1024, 41);
            this.panelButtons.TabIndex = 6;
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPC.Location = new System.Drawing.Point(775, 25);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(13, 13);
            this.labelPC.TabIndex = 16;
            this.labelPC.Text = "0";
            // 
            // labelPosicionC
            // 
            this.labelPosicionC.AutoSize = true;
            this.labelPosicionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosicionC.Location = new System.Drawing.Point(683, 25);
            this.labelPosicionC.Name = "labelPosicionC";
            this.labelPosicionC.Size = new System.Drawing.Size(86, 13);
            this.labelPosicionC.TabIndex = 15;
            this.labelPosicionC.Text = "Posicion cuchilla";
            // 
            // labelRV
            // 
            this.labelRV.AutoSize = true;
            this.labelRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRV.Location = new System.Drawing.Point(456, 25);
            this.labelRV.Name = "labelRV";
            this.labelRV.Size = new System.Drawing.Size(13, 13);
            this.labelRV.TabIndex = 14;
            this.labelRV.Text = "0";
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadio.Location = new System.Drawing.Point(383, 25);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(67, 13);
            this.labelRadio.TabIndex = 13;
            this.labelRadio.Text = "Radio actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Camara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Torno";
            // 
            // labelSelectedPiece
            // 
            this.labelSelectedPiece.AutoSize = true;
            this.labelSelectedPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPiece.Location = new System.Drawing.Point(488, 3);
            this.labelSelectedPiece.Name = "labelSelectedPiece";
            this.labelSelectedPiece.Size = new System.Drawing.Size(47, 13);
            this.labelSelectedPiece.TabIndex = 10;
            this.labelSelectedPiece.Text = "Ninguna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pieza seleccionada";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(274, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "|";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "|";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(182, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "<-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(320, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(93, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(35, 35);
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
            this.bFow.Location = new System.Drawing.Point(52, 3);
            this.bFow.Name = "bFow";
            this.bFow.Size = new System.Drawing.Size(35, 35);
            this.bFow.TabIndex = 5;
            this.bFow.Text = "+";
            this.bFow.UseVisualStyleBackColor = true;
            this.bFow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bFow_MouseDown);
            this.bFow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bFow_MouseUp);
            this.bFow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
            this.visualizacionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.camaraToolStripMenuItem,
            this.toolStripMenuItemAjustes,
            this.ayudaToolStripMenuItem});
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Nueva practica";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cargarPiezaToolStripMenuItem
            // 
            this.cargarPiezaToolStripMenuItem.Name = "cargarPiezaToolStripMenuItem";
            this.cargarPiezaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cargarPiezaToolStripMenuItem.Text = "Cargar practica";
            this.cargarPiezaToolStripMenuItem.Click += new System.EventHandler(this.cargarPiezaToolStripMenuItem_Click);
            // 
            // guardarPiezaToolStripMenuItem
            // 
            this.guardarPiezaToolStripMenuItem.Enabled = false;
            this.guardarPiezaToolStripMenuItem.Name = "guardarPiezaToolStripMenuItem";
            this.guardarPiezaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.guardarPiezaToolStripMenuItem.Text = "Guardar practica";
            this.guardarPiezaToolStripMenuItem.Click += new System.EventHandler(this.guardarPiezaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encenderTornoToolStripMenuItem,
            this.apagarTornoToolStripMenuItem,
            this.altaRevolucionToolStripMenuItem,
            this.bajaRevolucionToolStripMenuItem});
            this.accionesToolStripMenuItem.Enabled = false;
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
            // altaRevolucionToolStripMenuItem
            // 
            this.altaRevolucionToolStripMenuItem.Name = "altaRevolucionToolStripMenuItem";
            this.altaRevolucionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.altaRevolucionToolStripMenuItem.Text = "Alta revolucion";
            this.altaRevolucionToolStripMenuItem.Click += new System.EventHandler(this.altaRevolucionToolStripMenuItem_Click);
            // 
            // bajaRevolucionToolStripMenuItem
            // 
            this.bajaRevolucionToolStripMenuItem.Name = "bajaRevolucionToolStripMenuItem";
            this.bajaRevolucionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bajaRevolucionToolStripMenuItem.Text = "Baja revolucion";
            this.bajaRevolucionToolStripMenuItem.Click += new System.EventHandler(this.bajaRevolucionToolStripMenuItem_Click);
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
            this.camara3ToolStripMenuItem});
            this.camaraToolStripMenuItem.Name = "camaraToolStripMenuItem";
            this.camaraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.camaraToolStripMenuItem.Text = "Camara";
            // 
            // camara1ToolStripMenuItem
            // 
            this.camara1ToolStripMenuItem.Name = "camara1ToolStripMenuItem";
            this.camara1ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.camara1ToolStripMenuItem.Text = "Frontal";
            this.camara1ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // camara2ToolStripMenuItem
            // 
            this.camara2ToolStripMenuItem.Name = "camara2ToolStripMenuItem";
            this.camara2ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.camara2ToolStripMenuItem.Text = "Frontal cercana";
            this.camara2ToolStripMenuItem.Click += new System.EventHandler(this.camara2ToolStripMenuItem_Click);
            // 
            // camara3ToolStripMenuItem
            // 
            this.camara3ToolStripMenuItem.Name = "camara3ToolStripMenuItem";
            this.camara3ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.camara3ToolStripMenuItem.Text = "Costado";
            this.camara3ToolStripMenuItem.Click += new System.EventHandler(this.camara3ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAjustes
            // 
            this.toolStripMenuItemAjustes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desactivarAudioToolStripMenuItem});
            this.toolStripMenuItemAjustes.Name = "toolStripMenuItemAjustes";
            this.toolStripMenuItemAjustes.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemAjustes.Text = "Ajustes";
            // 
            // desactivarAudioToolStripMenuItem
            // 
            this.desactivarAudioToolStripMenuItem.Name = "desactivarAudioToolStripMenuItem";
            this.desactivarAudioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.desactivarAudioToolStripMenuItem.Text = "Desactivar audio";
            this.desactivarAudioToolStripMenuItem.Click += new System.EventHandler(this.desactivarAudioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerData
            // 
            this.timerData.Interval = 200;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPracticaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem2.Text = "Practica";
            // 
            // verPracticaToolStripMenuItem
            // 
            this.verPracticaToolStripMenuItem.Name = "verPracticaToolStripMenuItem";
            this.verPracticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verPracticaToolStripMenuItem.Text = "Ver practica";
            this.verPracticaToolStripMenuItem.Click += new System.EventHandler(this.verPracticaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 748);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio virtual";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ventana_MouseUp);
            this.SizeChanged += new System.EventHandler(this.Ventana_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ventana_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ventana_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPaint;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bFow;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPiezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encenderTornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarTornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem camara1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara3ToolStripMenuItem;
        private System.Windows.Forms.Label labelSelectedPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem altaRevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaRevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAjustes;
        private System.Windows.Forms.ToolStripMenuItem desactivarAudioToolStripMenuItem;
        private System.Windows.Forms.Label labelRV;
        private System.Windows.Forms.Label labelRadio;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Label labelPosicionC;
        public System.Windows.Forms.Timer timerData;
        public System.Windows.Forms.ToolStripMenuItem guardarPiezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verPracticaToolStripMenuItem;
    }
}

