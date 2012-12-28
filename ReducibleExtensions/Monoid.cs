using System;

namespace ReducibleExtensions
{
  public class Monoid<TLeft, TRight>
  {
    public Func<TLeft, TRight, TLeft> Op { get; private set; }
    public TLeft Init { get; private set; }

    public Monoid(Func<TLeft, TRight, TLeft> op, TLeft init)
    {
      this.Op = op;
      this.Init = init;
    }
  }
}
