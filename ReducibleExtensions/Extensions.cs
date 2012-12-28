using System.Collections.Generic;

namespace ReducibleExtensions
{
    public static class Extensions
    {
      public static IReducible<T> AsReducible<T>(this IList<T> list)
      {
        return new ReducibleList<T>(list);
      }
    }
}
