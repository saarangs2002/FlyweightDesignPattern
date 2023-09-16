/******************************************************************************
* Filename    = FlyweightUnitTest.cs
*
* Author      = Saarang S
*
* Product     = FlyweightDesignPattern
* 
* Project     = FlyweightUnitTest
*
* Description = Unit tests for the Flyweight pattern demo.
*****************************************************************************/

global using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyweightDesignPattern;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the Flyweight Design Pattern using a ButtonFactory.
    /// </summary>

    [TestClass]
    public class FlyweightUnitTests
    {
        /// <summary>
        /// Test for reusing a flyweight for buttons with shared properties.
        /// </summary>
        [TestMethod]
        public void ReuseFlyweightForSharedProperties()
        {
            ButtonFactory elementFactory = new();

            // Create and render buttons with shared properties
            IUIElement redButton = elementFactory.GetButton( "OK" , "Red" );
            redButton.Render( 10 , 20 );

            // Reuse the flyweight for another button
            IUIElement anotherRedButton = elementFactory.GetButton( "OK" , "Red" );
            anotherRedButton.Render( 50 , 60 );

            // Assert that the same flyweight instance is reused
            Assert.IsTrue( redButton == anotherRedButton );
        }

        /// <summary>
        /// Test for comparing two flyweights with different properties.
        /// </summary>
        [TestMethod]
        public void CompareFlyweightsWithDifferentProperties()
        {
            ButtonFactory elementFactory = new();

            // Create and render buttons with different properties
            IUIElement redButton = elementFactory.GetButton( "OK" , "Red" );
            IUIElement blueButton = elementFactory.GetButton( "Cancel" , "Blue" );

            redButton.Render( 10 , 20 );
            blueButton.Render( 30 , 40 );

            // Assert that the two flyweights are not the same instance
            Assert.IsTrue( redButton != blueButton );
        }

        /// <summary>
        /// Test for comparing two flyweights of the same color with different labels.
        /// </summary>
        [TestMethod]
        public void CompareFlyweightsWithSameColorDifferentLabels()
        {
            ButtonFactory elementFactory = new();

            // Create and render buttons with the same color but different labels
            IUIElement blueButton = elementFactory.GetButton( "Cancel" , "Blue" );
            IUIElement anotherBlueButton = elementFactory.GetButton( "OK" , "Blue" );

            blueButton.Render( 30 , 40 );
            anotherBlueButton.Render( 10 , 20 );

            // Assert that the two flyweights are not the same instance
            Assert.IsTrue( anotherBlueButton != blueButton );
        }
    }
}
