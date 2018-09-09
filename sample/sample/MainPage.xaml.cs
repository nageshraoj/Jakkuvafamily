using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Drawing;

namespace sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Create a new pen.
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);

            // Set the pen's width.
            skyBluePen.Width = 8.0F;

            // Set the LineJoin property.
            skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;

            // Draw a rectangle.
            e.Graphics.DrawRectangle(skyBluePen,
                new Rectangle(40, 40, 150, 200));

            //Dispose of the pen.
            skyBluePen.Dispose();
        }
    }
}
