using System.Collections.Generic;
using NUnit.Framework;

namespace ReducibleExtensions.Test
{
  [TestFixture]
  public class Conversions
  {
    [TestCase]
    public void ArrayAsFoldable()
    {
      var array = new int[0];
      var foldable = array.AsReducible();
      Assert.That(foldable, Is.AssignableTo<IReducible<int>>());
    }

    [TestCase]
    public void ListAsFoldable()
    {
      var list = new List<int>();
      var foldable = list.AsReducible();
      Assert.That(foldable, Is.AssignableTo<IReducible<int>>());
    }
  }
}
