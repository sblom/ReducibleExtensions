using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldableCollections
{
  internal class FoldableList<T>: IFoldable<T>
  {
    private IList<T> List { get; set; }

    internal FoldableList(IList<T> list)
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
