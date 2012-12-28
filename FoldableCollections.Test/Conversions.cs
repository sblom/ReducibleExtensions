using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using FoldableCollections;

namespace FoldableCollections.Test
{
  [TestFixture]
  public class Conversions
  {
    [TestCase]
    public void ArrayAsFoldable()
    {
      var array = new int[0];
      var foldable = array.AsFoldable();
      Assert.That(foldable, Is.AssignableTo<IFoldable<int>>());
    }

    [TestCase]
    public void ListAsFoldable()
    {
      var list = new List<int>();
      var foldable = list.AsFoldable();
      Assert.That(foldable, Is.AssignableTo<IFoldable<int>>());
    }
  }
}
