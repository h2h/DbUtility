﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Ivony.Data
{
  public class AccessDbUtility : DbUtility
  {
    protected override IDbExpressionParser GetExpressionParser()
    {
      throw new NotImplementedException();
    }


    private class AccessExpressionParser : IDbExpressionParser
    {

      public IDbCommand Parse( IDbExpression expression )
      {

        throw new NotImplementedException();

      }

    }


  }
}
