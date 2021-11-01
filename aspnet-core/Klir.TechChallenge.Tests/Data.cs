using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Klir.TechChallenge.Tests
{
    class Data
    {
        [Fact]
        public void Products_Repository()
        {
            if( Assert.NotNull(products) )
                if( Assert.NotEmpty(products) );
        }
        
    }
}
