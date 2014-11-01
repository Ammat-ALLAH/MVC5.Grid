﻿using System;
using System.Linq;

namespace NonFactors.Mvc.Grid
{
    public interface IGrid
    {
        String EmptyText { get; set; }

        IGridColumns Columns { get; }
        IGridRows Rows { get; }

        IGridPager Pager { get; }
    }

    public interface IGrid<TModel> : IGrid where TModel : class
    {
        IQueryable<TModel> Source { get; }
    }
}