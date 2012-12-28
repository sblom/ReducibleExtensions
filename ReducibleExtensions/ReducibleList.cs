using System;
using System.Collections.Generic;
using System.Linq;

namespace ReducibleExtensions
{
  internal class ReducibleList<T>: IReducible<T>
  {
    private IList<T> List { get; set; }

    internal ReducibleList(IList<T> list)
    {
      this.List = list;
    }

    public TResult Fold<TResult>(Func<TResult, T, TResult> reducer, TResult init)
    {
      // TODO: This downlevel "reducible" behavior should be replaced with parallel foldable behavior.
      return List.Aggregate(init, reducer);
    }

    public TResult Fold<TResult>(Monoid<TResult, T> reducer)
    {
      // TODO: This downlevel "reducible" behavior should be replaced with parallel foldable behavior.
      return List.Aggregate(reducer.Init, reducer.Op);
    }
  }
}
