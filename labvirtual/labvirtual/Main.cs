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
using System.Xml;


namespace labvirtual
{
    public class Main
    {
        Camera camara = new Camera();     
        Dictionary<string, Material> materiales = new Dictionary<string, Material>();
        bool practicaIniciada;
        Practice practica;
        Scene escena;

        public Scene Escena
        {
            get { return escena; }
            set { escena = value; }
        }

        static Main controladora;

        #region properties    

        static public Main Instancia
        {
            get { return controladora; }
        }

        public Camera Camara
        {
            get { return camara; }
        }

        public bool PracticaIniciada
        {
            get { return practicaIniciada; }
            set { practicaIniciada = value; }
        }

        public Dictionary<string, Material> Materiales
        {
            get { return materiales; }
            set { materiales = value; }
        }

        public Practice Practica
        {
            get { return practica; }
            set { practica = value; }
        }

        #endregion

        public Main()
        {
            controladora = this;
            practica = new Practice("", DateTime.Now, new Piece());
            escena = new Scene(); 
        }

        public void Create()
        {
            materiales.Add("aluminio", new Material("aluminio", 1, "pieza_acero.jpg"));
            materiales.Add("acero", new Material("acero", 3, "pieza_acero.jpg"));
            materiales.Add("cobre", new Material("acero", 2, "pieza_cobre.jpg"));
            escena.Create(); 
        }


        public void DibujarEscena()
        {
            escena.Dibujar();
            //Sprite.Begin();
            //Sprite.DrawText(300, 300, controladora.Escena.Torno.Speed.ToString(), Glut.GLUT_BITMAP_TIMES_ROMAN_24);
            //Sprite.End();
            //Collision.DrawColissions(); //dibuja la colisiones
            //DebugMode.WriteCamaraPos(300, 300); //escriba la pos de la camara
            //Collision.GhostMode = true;   //modo fantasma
        }
    }
}
