﻿namespace System.Reflection.Emit
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), ComVisible(true)]
    public struct OpCode
    {
        internal string m_stringname;
        internal StackBehaviour m_pop;
        internal StackBehaviour m_push;
        internal System.Reflection.Emit.OperandType m_operand;
        internal System.Reflection.Emit.OpCodeType m_type;
        internal int m_size;
        internal byte m_s1;
        internal byte m_s2;
        internal System.Reflection.Emit.FlowControl m_ctrl;
        internal bool m_endsUncondJmpBlk;
        internal int m_stackChange;
        internal OpCode(string stringname, StackBehaviour pop, StackBehaviour push, System.Reflection.Emit.OperandType operand, System.Reflection.Emit.OpCodeType type, int size, byte s1, byte s2, System.Reflection.Emit.FlowControl ctrl, bool endsjmpblk, int stack)
        {
            this.m_stringname = stringname;
            this.m_pop = pop;
            this.m_push = push;
            this.m_operand = operand;
            this.m_type = type;
            this.m_size = size;
            this.m_s1 = s1;
            this.m_s2 = s2;
            this.m_ctrl = ctrl;
            this.m_endsUncondJmpBlk = endsjmpblk;
            this.m_stackChange = stack;
        }

        internal bool EndsUncondJmpBlk()
        {
            return this.m_endsUncondJmpBlk;
        }

        internal int StackChange()
        {
            return this.m_stackChange;
        }

        public System.Reflection.Emit.OperandType OperandType
        {
            get
            {
                return this.m_operand;
            }
        }
        public System.Reflection.Emit.FlowControl FlowControl
        {
            get
            {
                return this.m_ctrl;
            }
        }
        public System.Reflection.Emit.OpCodeType OpCodeType
        {
            get
            {
                return this.m_type;
            }
        }
        public StackBehaviour StackBehaviourPop
        {
            get
            {
                return this.m_pop;
            }
        }
        public StackBehaviour StackBehaviourPush
        {
            get
            {
                return this.m_push;
            }
        }
        public int Size
        {
            get
            {
                return this.m_size;
            }
        }
        public short Value
        {
            get
            {
                if (this.m_size == 2)
                {
                    return (short) ((this.m_s1 << 8) | this.m_s2);
                }
                return this.m_s2;
            }
        }
        public string Name
        {
            get
            {
                return this.m_stringname;
            }
        }
        public override bool Equals(object obj)
        {
            return ((obj is OpCode) && this.Equals((OpCode) obj));
        }

        public bool Equals(OpCode obj)
        {
            return ((obj.m_s1 == this.m_s1) && (obj.m_s2 == this.m_s2));
        }

        public static bool operator ==(OpCode a, OpCode b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(OpCode a, OpCode b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return this.m_stringname.GetHashCode();
        }

        public override string ToString()
        {
            return this.m_stringname;
        }
    }
}

