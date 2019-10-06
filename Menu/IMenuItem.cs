using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An interface of all things a menu item
    /// should have.
    /// </summary>
    public interface IMenuItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> Ingredients { get; }
    }
}
