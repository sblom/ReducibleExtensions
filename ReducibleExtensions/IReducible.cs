using System;

namespace ReducibleExtensions
{
  public interface IReducible<T>
  {
    TResult Fold<TResult>(Func<TResult, T, TResult> reducer, TResult init);
    TResult Fold<TResult>(Monoid<TResult, T> reducer);
  }
}
