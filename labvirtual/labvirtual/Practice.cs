/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using ShadowEngine;

namespace labvirtual
{
    public class Practice
    {
        string nombreAlumno;
        DateTime fecha;
        Piece pieza;

        #region properties

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Piece Pieza
        {
            get { return pieza; }
            set { pieza = value; }
        }

        #endregion

        public Practice(string nombreAlumno, DateTime fecha, Piece pieza)
        {
            this.nombreAlumno = nombreAlumno;
            this.fecha = fecha;
            this.pieza = pieza;
        }

        public void SavePractica(string path)
        {
            using (XmlWriter outputPractica = XmlWriter.Create(path))
            {
                outputPractica.WriteStartDocument();

                outputPractica.WriteStartElement("Datos_de_la_practica");
                outputPractica.WriteElementString("Nombre", nombreAlumno);
                outputPractica.WriteElementString("Fecha", fecha.ToShortDateString().Replace('/', '-'));

                outputPractica.WriteStartElement("Pieza");
                outputPractica.WriteElementString("Material", pieza.Material.Nombre);
                outputPractica.WriteElementString("Resistencia", pieza.Material.Resistencia.ToString());
                outputPractica.WriteElementString("Textura", pieza.Material.Texture);
                outputPractica.WriteElementString("Radio", pieza.Radio.ToString());
                outputPractica.WriteStartElement("Puntos_de_la_pieza");

                for (int i = 0; i < pieza.ArrSize; i++)
                {
                    outputPractica.WriteElementString("X", pieza.Points[0, i].X.ToString());
                    outputPractica.WriteElementString("Y", pieza.Points[0, i].Y.ToString());
                    outputPractica.WriteElementString("Z", pieza.Points[0, i].Z.ToString());
                }

                outputPractica.WriteEndElement();
                outputPractica.WriteEndElement();

                outputPractica.WriteEndElement();
                outputPractica.WriteEndDocument();
            }
        }

        public void LoadPractica(string path)
        {
            using (XmlReader inputPractica = XmlReader.Create(path))
            {
                while (inputPractica.Read())
                {
                     switch (inputPractica.NodeType) 
                     { 
                         case XmlNodeType.Element:
                             switch (inputPractica.Name)
                             {
                                 case "Nombre":
                                     inputPractica.Read();
                                     this.nombreAlumno = inputPractica.Value;  
                                     break;
                                 case "Fecha":
                                     inputPractica.Read();
                                     this.fecha = DateTime.Parse(inputPractica.Value);  
                                     break;
                                 case "Pieza":
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     string materialNombre = inputPractica.Value;
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     float resistencia = float.Parse(inputPractica.Value);
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     string textura = inputPractica.Value;
                                     pieza.Material = new Material(materialNombre, resistencia, textura);

                                     inputPractica.Read();
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     float radio = float.Parse(inputPractica.Value);
                                     inputPractica.Read();
                                     inputPractica.Read();
                                     inputPractica.Read();

                                     Vector3[] arrPoints = new Vector3[128]; 

                                     for (int i = 0; i < 128; i++)
                                     {
                                         Vector3 p1 = new Vector3(); 
                                         inputPractica.Read();
                                         p1.X = float.Parse(inputPractica.Value);
                                         inputPractica.Read();
                                         inputPractica.Read();
                                         inputPractica.Read();
                                         p1.Y = float.Parse(inputPractica.Value);
                                         inputPractica.Read();
                                         inputPractica.Read();
                                         inputPractica.Read();
                                         p1.Z = float.Parse(inputPractica.Value);
                                         inputPractica.Read();
                                         inputPractica.Read();

                                         arrPoints[i] = p1; 
                                     }

                                     pieza.Radio = radio; 
                                     pieza.CargarPieza(arrPoints);
                                     Main.Instancia.Escena.Pieza = pieza;   

                                     break;
                             }
                             break;
                     }              
                }
            }
        }
    }
}
