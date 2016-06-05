/*
 * This project is property of Vasily Tserekh
 * if you wish to contribute visit my dev blog
 * at http://vasilydev.blogspot.com
 */

using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;

namespace labvirtual
{
    public class Material
    {
        string nombre;
        float resistencia;
        int textureID;
        string texture;

        #region properties

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int TextureID
        {
            get { return textureID; }
            set { textureID = value; }
        }

        public float Resistencia
        {
            get { return resistencia; }
            set { resistencia = value; }
        }

        public string Texture
        {
            get { return texture; }
        }

        #endregion

        public Material(string nombre, float resistencia, string texture)
        {
            this.nombre = nombre;
            this.resistencia = resistencia;
            this.texture = texture; 
            this.textureID = ContentManager.GetTextureByName(texture);
        }
    }
}
