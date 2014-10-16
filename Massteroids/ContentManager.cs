using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Massteroids
{
    class ContentManager
    {
        String baseLocation;
        GraphicsDeviceManager graphics;

        public ContentManager(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            this.baseLocation = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\Content\\";
        }

        public Texture2D load(String fileName)
        {
            String fileLocation = baseLocation + fileName;
            System.IO.Stream stream = new System.IO.FileStream(fileLocation, System.IO.FileMode.Open);

            return Texture2D.FromStream(graphics.GraphicsDevice, stream);
        }
    }
}
