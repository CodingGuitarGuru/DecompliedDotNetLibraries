﻿namespace System.ServiceModel.Dispatcher
{
    using System;

    internal class StringBranchIndex : HashBranchIndex
    {
        internal override void Match(int valIndex, ref Value val, QueryBranchResultSet results)
        {
            QueryBranch branch = null;
            if (ValueDataType.Sequence == val.Type)
            {
                NodeSequence sequence = val.Sequence;
                for (int i = 0; i < sequence.Count; i++)
                {
                    branch = this[sequence.Items[i].StringValue()];
                    if (branch != null)
                    {
                        results.Add(branch, valIndex);
                    }
                }
            }
            else
            {
                branch = this[val.String];
                if (branch != null)
                {
                    results.Add(branch, valIndex);
                }
            }
        }
    }
}

