/******************************************************************************
* Filename    = ButtonFactory.cs
*
* Author      = Saarang S
*
* Product     = FlyweightDesignPattern
* 
* Project     = FlyweightDesignPattern
*
* Description = A Button factory that creates and manages UIButton.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    /// <summary>
    /// Factory class for creating and managing UI buttons.
    /// </summary>
    public class ButtonFactory
    {
        private readonly Dictionary<string , IUIElement> _elements;

        /// <summary>
        /// Initializes a new instance of the ButtonFactory class.
        /// </summary>
        public ButtonFactory() 
        {
            _elements = new();
        }

        /// <summary>
        /// Gets or creates a UI button with the specified label and color.
        /// </summary>
        /// <param name="label">The label text for the button.</param>
        /// <param name="color">The color of the button.</param>
        /// <returns>An instance of the IUIElement representing the button.</returns>
        public IUIElement GetButton (string label, string color) {
            

            string key = $"{label}-{color}";
            if(!_elements.ContainsKey(key))
            {
                _elements[key] = new UIButton(label, color);
            }
            return _elements[key];
        }
    }
}
