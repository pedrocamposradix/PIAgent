using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PIAgent;

namespace PIAgent.Test
{
    public class Class1
    {
        [Fact]
        public void ShouldReturnTrueWhenParameterIsOne()
        {
            PIAgent elemento = new PIAgent();

            bool t = elemento.IsOne(1);

            Assert.True(t, "Is One");
        }

        [Fact]
        public void ShouldReturnFalseWhenParameterIsNotOne()
        {
            PIAgent elemento = new PIAgent();

            bool w = elemento.IsOne(2);

            Assert.True(w, "Is not One");
        }
    }
}
