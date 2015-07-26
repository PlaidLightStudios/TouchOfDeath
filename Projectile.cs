using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace TouchOfDeath
{
    class Projectile
    {
        //texture
        public Bitmap texture;
        //direction of travel, Vector2
        //origin point, Vector2
        bool isDead;

        void projectile(string textName, bool isDead)
        {
            texture = BitmapFactory.DecodeFile(textName);
        }

        void projectile ()
        {
            texture = BitmapFactory.DecodeFile("projectile.png");
            isDead = false;
        }

        void Draw()
        {
            Canvas canv = new Canvas(texture);
        }
    }
}