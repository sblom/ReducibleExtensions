using System.Collections.Generic;
using NUnit.Framework;

namespace ReducibleExtensions.Test
{
  [TestFixture]
  class Reductions
  {
    [Test]
    public void SumListUsingReducer()
    {
      var list = new List<int> {1, 2, 3, 4, 5};
      var result = list.AsReducible().Fold((int a, int b) => a + b, 0);
      Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void SumListUsingMonoid()
    {
      var list = new List<int> {1, 2, 3, 4, 5};
      var monoid = new Monoid<int,int>((int a, int b) => a + b, 0);
      var result = list.AsReducible().Fold(monoid);
      Assert.That(result, Is.EqualTo(15));
    }
  }
}
