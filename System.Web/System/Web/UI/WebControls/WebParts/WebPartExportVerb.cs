﻿namespace System.Web.UI.WebControls.WebParts
{
    using System;
    using System.Web;

    internal sealed class WebPartExportVerb : WebPartActionVerb
    {
        private string _defaultDescription;
        private string _defaultText;

        private string DefaultDescription
        {
            get
            {
                if (this._defaultDescription == null)
                {
                    this._defaultDescription = System.Web.SR.GetString("WebPartExportVerb_Description");
                }
                return this._defaultDescription;
            }
        }

        private string DefaultText
        {
            get
            {
                if (this._defaultText == null)
                {
                    this._defaultText = System.Web.SR.GetString("WebPartExportVerb_Text");
                }
                return this._defaultText;
            }
        }

        [WebSysDefaultValue("WebPartExportVerb_Description")]
        public override string Description
        {
            get
            {
                object obj2 = base.ViewState["Description"];
                if (obj2 != null)
                {
                    return (string) obj2;
                }
                return this.DefaultDescription;
            }
            set
            {
                base.ViewState["Description"] = value;
            }
        }

        [WebSysDefaultValue("WebPartExportVerb_Text")]
        public override string Text
        {
            get
            {
                object obj2 = base.ViewState["Text"];
                if (obj2 != null)
                {
                    return (string) obj2;
                }
                return this.DefaultText;
            }
            set
            {
                base.ViewState["Text"] = value;
            }
        }
    }
}

