﻿namespace System.Web.UI.WebControls
{
    using System;
    using System.ComponentModel;

    public class DetailsViewPageEventArgs : CancelEventArgs
    {
        private int _newPageIndex;

        public DetailsViewPageEventArgs(int newPageIndex)
        {
            this._newPageIndex = newPageIndex;
        }

        public int NewPageIndex
        {
            get
            {
                return this._newPageIndex;
            }
            set
            {
                this._newPageIndex = value;
            }
        }
    }
}

