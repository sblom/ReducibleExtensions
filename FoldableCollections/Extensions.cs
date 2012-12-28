using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldableCollections
{
    public static class Extensions
    {
      public static IFoldable<T> AsFoldable<T>(this IList<T> list)
      {
        return new FoldableList<T>();
      }
    }
}
