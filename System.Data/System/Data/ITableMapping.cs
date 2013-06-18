﻿namespace System.Data
{
    using System;

    public interface ITableMapping
    {
        IColumnMappingCollection ColumnMappings { get; }

        string DataSetTable { get; set; }

        string SourceTable { get; set; }
    }
}

