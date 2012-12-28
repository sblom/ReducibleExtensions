using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldableCollections
{
  internal class FoldableList<T>: IFoldable<T>
  {
    public TResult Fold<TResult>(Func<TResult, T, TResult> reducer)
    {
      throw new NotImplementedException();
    }
  }
}
