using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange 
            var _source = "ScrewDriver";
            var _expected = "Screw Driver";

             //-- Act
            var _actual = _source.InsertSpaces();

            //-- Assert
            Assert.AreEqual(_expected,_actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            //--Arrange 
            var _source = "Sonic Screwdriver";
            var _expected = "Sonic Screwdriver";

            //-- Act
            var _actual = _source.InsertSpaces();

            //-- Assert
            Assert.AreEqual(_expected, _actual);
        }

    }
}
