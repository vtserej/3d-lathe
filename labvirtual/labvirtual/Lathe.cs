/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine.ContentLoading;
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.Sound;
using System.Drawing;

namespace labvirtual
{
    public class Lathe
    {
        #region private attributes

        ModelContainer m;

        #region meshes del torno

        Mesh baseTorno;
        Mesh baseCarro;
        Mesh portaCuchilla;
        Mesh platoAutoCentrante;
        Mesh barrena;
        Mesh cuchilla;

        Mesh botonAlta;
        Mesh botonBaja;
        Mesh botonEncender;

        //meshes del carro
        List<Mesh> tornillos = new List<Mesh>();
        Mesh manivela2c;
        Mesh manibela1c;
        Mesh base1;
        Mesh base2;
        Mesh base3;
        Mesh base4;
        Mesh base5;

        Mesh rueda1carro;
        Mesh rueda2carro;
        Mesh baseBotones;
        Mesh boton1Carro;
        Mesh boton2Carro;
        Mesh manivela5c;
        Mesh manivela3c;
        Mesh manivela6c;
        Mesh manivela4c;

        #endregion

        List<Mesh> targets = new List<Mesh>();

        Vector3 baseTornoPos = new Vector3();
        Vector3 cuchillaPos1 = new Vector3();
        Vector3 cuchillaPos2 = new Vector3();

        float speed = 0.02f;
        float speedBase = 0.03f;
        float scale = 0.2f;

        Movement movimiento;
        bool moviendo;

        RevolutionType tipoRevolucion;
        int counterSpeed;

        //variable botones apretados
        bool altaRevolucion;
        bool bajaRevolucion;
        bool encendido;


        #region variables de picking

        int[] buffer;
        int[] viewport;
        int hits;

        #endregion

        #endregion

        #region properties

        public Vector3 BaseTornoPos
        {
            get { return baseTornoPos; }
            set { baseTornoPos = value; }
        }

        public bool Moviendo
        {
            get { return moviendo; }
            set { moviendo = value; }
        }

        public Movement Movimiento
        {
            get { return movimiento; }
            set { movimiento = value; }
        }

        public bool Encendido
        {
            get { return encendido; }
            set { encendido = value; }
        }

        public RevolutionType TipoRevolucion
        {
            get { return tipoRevolucion; }
            set { tipoRevolucion = value; }
        }

        public float Speed
        {
            get { return speed; }
        }

        public void MovimientoAvance(float movimiento)
        {
            speed *= movimiento;  
        }

        #endregion

        public Lathe()
        {
            tipoRevolucion = RevolutionType.Low;
        }

        public void Resetear()
        {
            baseTornoPos = new Vector3(0, 0, 1.81f);
        }

        public void Create()
        {
            m = ContentManager.GetModelByName("torno.3DS");
            barrena = m.GetMeshWithName("barrena");
            platoAutoCentrante = m.GetMeshWithName("platoautoc");
            portaCuchilla = m.GetMeshWithName("portatorni");
            baseTorno = m.GetMeshWithName("basetorno");
            cuchilla = m.GetMeshWithName("cuchilla");

            //botones
            botonAlta = m.GetMeshWithName("boton1base");
            botonBaja = m.GetMeshWithName("boton2base");
            botonEncender = m.GetMeshWithName("boton3base");

            //todos los meshes del carro

            baseCarro = m.GetMeshWithName("basecarro");
            manivela2c = m.GetMeshWithName("manivela2c");
            manibela1c = m.GetMeshWithName("manibela1c");
            manivela5c = m.GetMeshWithName("manivela5c");
            base1 = m.GetMeshWithName("base1");
            base2 = m.GetMeshWithName("base2");
            base3 = m.GetMeshWithName("base3");
            base4 = m.GetMeshWithName("base3");
            base5 = m.GetMeshWithName("base3");
            rueda1carro = m.GetMeshWithName("rueda1carr");
            rueda2carro = m.GetMeshWithName("rueda2carr");
            baseBotones = m.GetMeshWithName("basebotone");
            boton1Carro = m.GetMeshWithName("boton1carr");
            boton2Carro = m.GetMeshWithName("boton2carr");
            manivela3c = m.GetMeshWithName("manivela3c");
            manivela6c = m.GetMeshWithName("manivela6c");
            manivela4c = m.GetMeshWithName("manivela6c");
            
            for (int i = 0; i < 8; i++)
            {
                tornillos.Add(m.GetMeshWithName("tornillo" + (i + 1).ToString()));
            }

            Mesh manivela3b = m.GetMeshWithName("manivela3b");        
            Mesh manivela4b = m.GetMeshWithName("manivela4b");      
            Mesh manivela5b = m.GetMeshWithName("manivela5b");          
            Mesh manivela6b = m.GetMeshWithName("manivela6b");

            Mesh control1ba = m.GetMeshWithName("control1ba");
            Mesh manivela1b = m.GetMeshWithName("manivela1b");
            Mesh manivela2b = m.GetMeshWithName("manivela2b");

            Mesh cilindro1 = m.GetMeshWithName("ciliindro1");
            Mesh cilindro2 = m.GetMeshWithName("cilindro2");
            Mesh cilindro3 = m.GetMeshWithName("cilindro3");
            Mesh palancacil = m.GetMeshWithName("palancacil");
            Mesh palancacar = m.GetMeshWithName("palancacar");

            Mesh contrapunta = m.GetMeshWithName("contrapunt");
            Mesh manivela1c = m.GetMeshWithName("manivela1c");
            Mesh rueda1cont = m.GetMeshWithName("rueda1cont");
            Mesh correcuchilla = m.GetMeshWithName("correcuhch"); 


            manivela3b.Description = "Palanca para el movimiento de traslación automatico del brazo";
            manivela4b.Description = manivela3b.Description;
            manivela5b.Description = manivela3b.Description;
            manivela6b.Description = manivela3b.Description;

            control1ba.Description = "Palanca para el ajuste de la velocidad del plato autocentrante";
            manivela1b.Description = control1ba.Description;
            manivela2b.Description = control1ba.Description;

            cilindro1.Description = "Barra de roscar";
            cilindro2.Description = "Barra de cilindrar";
            cilindro3.Description = "Barra de accionar el plato autocentrante";
            palancacil.Description = "Palanca para accionar la barra que acciona el plato autocentrante";
            palancacar.Description = palancacil.Description;   

            barrena.Description = "Barrena";
            platoAutoCentrante.Description = "Plato autocentrante";
            portaCuchilla.Description = "Porta cuchilla";
            baseTorno.Description = "Base del torno";
            cuchilla.Description = "Cuchilla";

            botonAlta.Description = "Boton de alta revolucion";
            botonBaja.Description = "Boton de baja revolucion";
            botonEncender.Description = "Boton de encendido";

            baseCarro.Description = "Delantar";
            manibela1c.Description = "Manivela de movimiento longitudinal manual";
            rueda1carro.Description = "Manivela de movimiento transversal mannual";
            boton1Carro.Description = "Boton para el movimiento de forma rapida del delantar con el portacuchillas longitudinal";
            boton2Carro.Description = "Boton para el movimiento de forma rapida del delantar con el portacuchillas transversal";
            manivela5c.Description = "Manivela que permite unir el delantar con la barra de roscar";
            manivela6c.Description = "Selector de movimiento automatico";

            contrapunta.Description = "Cabezal móvil o contrapunta";
            manivela1c.Description = "Manivela para frenar el movimiento del husillo de la contrapunta";
            rueda1cont.Description = "Manivela para el movimiento longitudinal del husillo de la contrapunta";
            correcuchilla.Description = "Guias del torno";

            //manivelas
            targets.Add(manivela3b);
            targets.Add(manivela4b);
            targets.Add(manivela5b);
            targets.Add(manivela6b);

            targets.Add(control1ba);
            targets.Add(manivela1b);
            targets.Add(manivela2b);   

            //barras
            targets.Add(cilindro1);
            targets.Add(cilindro2);
            targets.Add(cilindro3);
            targets.Add(palancacil);
            targets.Add(palancacar); 

            //targets.Add(barrena);
            targets.Add(platoAutoCentrante);
            targets.Add(portaCuchilla);
            targets.Add(baseTorno);
            targets.Add(cuchilla);

            //botones
            targets.Add(botonAlta);
            targets.Add(botonBaja);
            targets.Add(botonEncender);

            targets.Add(baseCarro);
            targets.Add(manibela1c);
            targets.Add(rueda1carro);
            targets.Add(boton1Carro);
            targets.Add(boton2Carro);
            targets.Add(manivela5c);
            targets.Add(manivela6c);

            targets.Add(contrapunta);
            targets.Add(manivela1c);
            targets.Add(rueda1cont);
            targets.Add(correcuchilla);  

            platoAutoCentrante.CalcCenterPoint();

            cuchilla.CalcCenterPoint();
            cuchillaPos1 = cuchilla.CenterPoint; // -0.74 12.11 2.37
            // la possion deseada no es el centro sino el borde de la cuchilla
            // por eso le suma los siguientes numeros
            cuchillaPos1.Z -= 0.51f;
            cuchillaPos1.X += 0.05f;

            cuchillaPos2 = new Vector3(cuchillaPos1);
            cuchillaPos2.Z -= 0.05f;
            cuchillaPos2.X -= 0.05f; 

            baseTornoPos.Translate(new Vector3(0, 0, 1.81f));
            cuchillaPos1.Translate(new Vector3(0, 0, 1.81f));
            cuchillaPos2.Translate(new Vector3(0, 0, 1.81f));

            m.RemoveMeshByName("barrena");
            m.RemoveMeshByName("platoautoc");
            m.RemoveMeshByName("portatorni");
            m.RemoveMeshByName("cuchilla");

            m.RemoveMeshByName("boton1base");
            m.RemoveMeshByName("boton2base");
            m.RemoveMeshByName("boton3base");

            for (int i = 0; i < 8; i++)
            {
                m.RemoveMeshByName("tornillo" + (i + 1).ToString());
            }
            m.RemoveMeshByName("manivela2c");
            m.RemoveMeshByName("manibela1c");
            m.RemoveMeshByName("manivela5c");
            m.RemoveMeshByName("base1");
            m.RemoveMeshByName("base2");
            m.RemoveMeshByName("base3");
            m.RemoveMeshByName("base4");
            m.RemoveMeshByName("base5");
            m.RemoveMeshByName("basecarro");
            m.RemoveMeshByName("rueda1carr");
            m.RemoveMeshByName("rueda2carr");
            m.RemoveMeshByName("basebotone");
            m.RemoveMeshByName("boton1carr");
            m.RemoveMeshByName("boton2carr");
            m.RemoveMeshByName("manivela3c");
            m.RemoveMeshByName("manivela6c");
            m.RemoveMeshByName("manivela4c");
            
            m.CreateDisplayList();
        }

        public void MoverBase(Movement movement)
        {
            if (encendido == false)
            {
                return;
            }
            if (Main.Instancia.PracticaIniciada == false)
            {
                return;
            }
            Vector3 posC1 = new Vector3(cuchillaPos1);
            Vector3 posC2 = new Vector3(cuchillaPos2);

            Vector3 posTorno = new Vector3(baseTornoPos);

            switch (movement)
            {
                case Movement.Backward:
                    posC1.Z += speed;
                    posC2.Z += speed;
                    posTorno.Z += speed;
                    break;
                case Movement.Forward:
                    posC1.Z -= speed;
                    posC2.Z -= speed;
                    posTorno.Z -= speed;
                    break;
                case Movement.Left:
                    posC1.X -= speed;
                    posC2.X -= speed;
                    posTorno.X -= speed;
                    break;
                case Movement.Right:
                    posC1.X += speed;
                    posC2.X += speed;
                    posTorno.X += speed;
                    break;
            }
            if (Main.Instancia.Escena.Pieza.ChequearCollision(posC1) ||
                Main.Instancia.Escena.Pieza.ChequearCollision(posC2))
            {
                speed = Main.Instancia.Escena.Pieza.Material.Resistencia / 350;
                AudioPlayback.Play("rebajado.mp3");
                Vector3 v = new Vector3(cuchillaPos1);
                v.Scale(scale);
                Main.Instancia.Escena.AddGenerator(new ChispaGenerator(v));
            }
            else
            {
                counterSpeed++;
                if (counterSpeed == 22)
                {
                    counterSpeed = 0;
                    speed = speedBase;
                }

                //if (movement == Movement.Left || movement == Movement.Right)
                //{
                //    Controladora.Instancia.CleanGenerator();
                //}
            }
            if (movement == Movement.Left || movement == Movement.Right)
            {
                Main.Instancia.Escena.ClearGenerator();
            }
            if (movement == Movement.Backward)
            {
                Main.Instancia.Escena.CleanGenerator();
                AudioPlayback.StopSound("rebajado.mp3");
            }

            if (posTorno.Z < 2.37f && posTorno.Z > 0.06f && // aki se dan los topes
                (movement == Movement.Forward || movement == Movement.Backward))
            {
                baseTornoPos.Z = posTorno.Z;
                cuchillaPos1.Z = posC1.Z;
                cuchillaPos2.Z = posC2.Z;

            }
            if (posTorno.X > -5.84 && posTorno.X < 3.25f &&
               (movement == Movement.Left || movement == Movement.Right))
            {
                baseTornoPos.X = posTorno.X;
                cuchillaPos1.X = posC1.X;
                cuchillaPos2.X = posC2.X;
            }


            if (posC1.Y < 0.1f)// para que no parta la pieza
                return;

            Main.Instancia.Escena.Pieza.RebajarPieza(cuchillaPos1);
            Main.Instancia.Escena.Pieza.RebajarPieza(cuchillaPos2);
        }

        public void Dibujar()
        {
            if (moviendo)
            {
                MoverBase(movimiento);
            }

            Gl.glPushMatrix();       

            Gl.glScalef(scale, scale, scale);
            Gl.glColor3f(1, 1, 1);

            //botones
            Gl.glPushMatrix();
            if (altaRevolucion)
                Gl.glTranslatef(0, 0, -0.05f);
            botonAlta.DrawWithTextures();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            if (bajaRevolucion)
                Gl.glTranslatef(0, 0, -0.05f);
            botonBaja.DrawWithTextures();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            if (encendido)
                Gl.glTranslatef(0, 0, -0.05f);
            botonEncender.DrawWithTextures();
            Gl.glPopMatrix();


            //plato autocentrante
            Gl.glPushMatrix();
            Vector3 center = platoAutoCentrante.CenterPoint;
            Gl.glTranslatef(center.X, center.Y, center.Z);
            Gl.glRotatef(Piece.Rotation.X, 1, 0, 0);
            Gl.glTranslatef(-center.X, -center.Y, -center.Z);
            platoAutoCentrante.DrawWithTextures();
            Gl.glPopMatrix();

            //base del torno
            baseTorno.DrawWithTextures();

            //piezas moviles
            Gl.glPushMatrix();

            Gl.glTranslatef(baseTornoPos.X, 0, 0);

            manibela1c.DrawWithTextures();
            baseCarro.DrawWithTextures();
            rueda1carro.DrawWithTextures();         
            baseBotones.DrawWithTextures();
            boton1Carro.DrawWithTextures();
            boton2Carro.DrawWithTextures();
            manivela5c.DrawWithTextures();
            manivela3c.DrawWithTextures();
            manivela6c.DrawWithTextures();
            manivela4c.DrawWithTextures();

            Gl.glTranslatef(0, 0, baseTornoPos.Z);
            portaCuchilla.DrawWithTextures();

            for (int i = 0; i < 8; i++)
            {
                tornillos[i].DrawWithTextures();
            }
            manivela2c.DrawWithTextures();
            cuchilla.DrawWithTextures();
            base1.DrawWithTextures();
            base2.DrawWithTextures();
            base3.DrawWithTextures();
            base4.DrawWithTextures();
            base5.DrawWithTextures();
            rueda2carro.DrawWithTextures();



            Gl.glPopMatrix();         

            //barrena.Draw();
            m.DrawWithTextures();
            Gl.glPopMatrix();

            //Gl.glColor3f(1, 0, 0); 
            //Gl.glPointSize(5);
            //Gl.glBegin(Gl.GL_POINTS);

            //Vector3 c1 = new Vector3(cuchillaPos1);
            //c1.Scale(0.2f);
            //Gl.glVertex3f(c1.X, c1.Y, c1.Z);

            //Vector3 c2 = new Vector3(cuchillaPos2);
            //c2.Scale(0.2f);
            //Gl.glVertex3f(c2.X, c2.Y, c2.Z);
           
            //Gl.glEnd();
            //Gl.glColor3f(1, 1, 1); 
        }

        public void Encender()
        {
            if (Main.Instancia.PracticaIniciada == false)
            {
                return;
            }
            if (encendido == true) //apago
            {
                encendido = false;
                Main.Instancia.Escena.Pieza.PararPieza();
                Main.Instancia.Escena.Torno.Encendido = false;

                AudioPlayback.PlayOne("apagado.mp3");
                AudioPlayback.StopLoop("trabajando.mp3");
            }
            else //enciendo
            {
                encendido = true;
                Main.Instancia.Escena.Pieza.MoverPieza();
                Main.Instancia.Escena.Torno.Encendido = true;
                AudioPlayback.PlayTwo("arranque.mp3", "trabajando.mp3");
                bajaRevolucion = true;
                altaRevolucion = false;
            }
        }

        public void AccionesTorno(string pieza)
        {
            switch (pieza)
            {
                case "Boton de alta revolucion":
                    tipoRevolucion = RevolutionType.High;
                    altaRevolucion = true;
                    bajaRevolucion = false;
                    break;
                case "Boton de baja revolucion":
                    tipoRevolucion = RevolutionType.Low;
                    altaRevolucion = false;
                    bajaRevolucion = true;
                    break;
                case "Boton de encendido":
                    Encender();
                    break;
            }
        }

        #region  Seleccion de objetos con el mouse

        void DrawTargets()
        {
            //dibuja los objetos en el buffer de selección
            for (int i = 0; i < targets.Count; i++)
            {
                try
                {
                    Gl.glLoadName(i);
                    Gl.glPushMatrix();
                    Gl.glScalef(scale, scale, scale);
                    targets[i].Draw();
                    Gl.glPopMatrix();
                }
                catch (Exception)
                {
                }
               
            }
        }

        void Selection(float mouseX, float mouseY)
        {
            hits = 0;
            this.buffer = new int[512];
            viewport = new int[4];
            Gl.glGetIntegerv(Gl.GL_VIEWPORT, viewport);
            Gl.glSelectBuffer(512, buffer);

            Gl.glRenderMode(Gl.GL_SELECT);
            Gl.glInitNames();
            Gl.glPushName(0);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glPushMatrix();
            Gl.glLoadIdentity();
            Glu.gluPickMatrix((double)mouseX, (double)(viewport[3] - mouseY), 0.5f, 0.5f, viewport);
            Glu.gluPerspective(55.0f, Globals.ScreenProportion, 0.1f, 50.0f);
        }

        public string PieceSelection(float mouseX, float mouseY)
        {
            Selection(mouseX, mouseY);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glPushMatrix();
            Gl.glLoadIdentity();
            Main.Instancia.Camara.LookSelection();

            this.DrawTargets();

            Gl.glPopMatrix();

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glPopMatrix();
            hits = Gl.glRenderMode(Gl.GL_RENDER);

            if (hits > 0)
            {
                int choose = buffer[3];
                int depth = buffer[1];
                if (hits > 1)
                {
                    for (int loop = 1; loop < hits; loop++)
                    {
                        // If This Object Is Closer To Us Than The One We Have Selected
                        if (buffer[loop * 4 + 1] < depth)
                        {
                            choose = buffer[loop * 4 + 3];			// Select The Closer Object
                            depth = buffer[loop * 4 + 1];			// Store How Far Away It Is
                        }
                    }
                }
                return targets[(int)choose].Description;
            }
            return string.Empty;
        }

        #endregion
    }
}
