/******************************************************************************
* Filename    = IUIElement.cs
*
* Author      = Saarang S
*
* Product     = FlyweightDesignPattern
* 
* Project     = FlyweightDesignPattern
*
* Description = A contract for a UI element.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    /// <summary>
    /// Represents a UI element that can be rendered.
    /// </summary>
    public interface IUIElement
    {
        /// <summary>
        /// Renders the UI element at the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate for rendering.</param>
        /// <param name="y">The Y-coordinate for rendering.</param>
        void Render(int x, int y);
    }
}
