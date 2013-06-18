﻿namespace System.ServiceModel.Security
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct ReceiveSecurityHeaderEntry
    {
        internal ReceiveSecurityHeaderElementCategory elementCategory;
        internal object element;
        internal ReceiveSecurityHeaderBindingModes bindingMode;
        internal string id;
        internal string encryptedFormId;
        internal string encryptedFormWsuId;
        internal bool signed;
        internal bool encrypted;
        internal byte[] decryptedBuffer;
        internal TokenTracker supportingTokenTracker;
        internal bool doubleEncrypted;
        public bool MatchesId(string id, bool requiresEncryptedFormId)
        {
            if (this.doubleEncrypted)
            {
                if (!(this.encryptedFormId == id))
                {
                    return (this.encryptedFormWsuId == id);
                }
                return true;
            }
            if (requiresEncryptedFormId)
            {
                return (this.encryptedFormId == id);
            }
            return (this.id == id);
        }

        public void PreserveIdBeforeDecryption()
        {
            this.encryptedFormId = this.id;
        }

        public void SetElement(ReceiveSecurityHeaderElementCategory elementCategory, object element, ReceiveSecurityHeaderBindingModes bindingMode, string id, bool encrypted, byte[] decryptedBuffer, TokenTracker supportingTokenTracker)
        {
            this.elementCategory = elementCategory;
            this.element = element;
            this.bindingMode = bindingMode;
            this.encrypted = encrypted;
            this.decryptedBuffer = decryptedBuffer;
            this.supportingTokenTracker = supportingTokenTracker;
            this.id = id;
        }
    }
}

