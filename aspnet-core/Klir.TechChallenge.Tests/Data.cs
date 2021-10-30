using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Klir.TechChallenge.Tests
{
    class Data
    {
        [Fact]
        public void List_Products_Repository()
        {
            Assert.NotEmpty(products);
        }
        
    }
}
