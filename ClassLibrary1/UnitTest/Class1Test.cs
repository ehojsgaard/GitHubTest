using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ClassLibrary1.UnitTest
{
  [TestFixture]
  [Category("UnitTest")]
  class Class1Test
  {
    [Test]
    public void FailingTest()
    {
      Assert.Fail();
    }
  }
}
