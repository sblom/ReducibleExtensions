using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldableCollections
{
  public interface IFoldable<T>
  {
    TResult Fold<TResult>(Func<TResult, T, TResult> reducer);
  }
}
