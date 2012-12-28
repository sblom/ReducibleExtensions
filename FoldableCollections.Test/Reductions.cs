using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using FoldableCollections;

namespace FoldableCollections.Test
{
  [TestFixture]
  class Reductions
  {
    [Test]
    public void SumListUsingReducer()
    {
      var list = new List<int> {1, 2, 3, 4, 5};
      var result = list.AsFoldable().Fold((int a, int b) => a + b, 0);
      Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void SumListUsingMonoid()
    {
      var list = new List<int> {1, 2, 3, 4, 5};
      var monoid = new Monoid<int,int>((int a, int b) => a + b, 0);
      var result = list.AsFoldable().Fold(monoid);
      Assert.That(result, Is.EqualTo(15));
    }
  }
}
