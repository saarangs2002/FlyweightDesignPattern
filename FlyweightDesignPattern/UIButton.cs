/******************************************************************************
* Filename    = UIButton.cs
*
* Author      = Saarang S
*
* Product     = FlyweightDesignPattern
* 
* Project     = FlyweightDesignPattern
*
* Description = A UI Button which can be rendered.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    /// <summary>
    /// Represents a UI Button that implements the IUIElement interface.
    /// </summary>
    public class UIButton : IUIElement
    {
        private readonly string _label;
        private readonly string _color;

        /// <summary>
        /// Initializes a new instance of the UIButton class with the specified label and color.
        /// </summary>
        /// <param name="label">The label text for the button.</param>
        /// <param name="color">The color of the button.</param>
        public UIButton (string label, string color)
        {
            _label = label;
            _color = color;
        }

        /// <summary>
        /// Renders the button at the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate for rendering.</param>
        /// <param name="y">The Y-coordinate for rendering.</param>
        public void Render (int x, int y)
        {
            Console.WriteLine($"Rendering Button {_label} of Color {_color} at ({x},{y})");
        }
    }
}
