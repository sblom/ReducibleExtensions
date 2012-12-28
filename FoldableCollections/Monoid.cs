using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoldableCollections
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
