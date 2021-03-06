﻿namespace System.Workflow.Activities.Rules
{
    using System;
    using System.Globalization;

    internal class DoubleArithmeticLiteral : ArithmeticLiteral
    {
        private double m_value;

        internal DoubleArithmeticLiteral(double literalValue)
        {
            this.m_value = literalValue;
            base.m_type = typeof(double);
        }

        internal override object Add()
        {
            return null;
        }

        internal override object Add(char v)
        {
            return (((double) v) + this.m_value);
        }

        internal override object Add(double v)
        {
            return (v + this.m_value);
        }

        internal override object Add(int v)
        {
            return (v + this.m_value);
        }

        internal override object Add(long v)
        {
            return (v + this.m_value);
        }

        internal override object Add(float v)
        {
            return (v + this.m_value);
        }

        internal override object Add(string v)
        {
            return (v + this.m_value.ToString(CultureInfo.CurrentCulture));
        }

        internal override object Add(ushort v)
        {
            return (v + this.m_value);
        }

        internal override object Add(uint v)
        {
            return (v + this.m_value);
        }

        internal override object Add(ulong v)
        {
            return (v + this.m_value);
        }

        internal override object Add(ArithmeticLiteral v)
        {
            return v.Add(this.m_value);
        }

        internal override object Divide()
        {
            return null;
        }

        internal override object Divide(double v)
        {
            return (v / this.m_value);
        }

        internal override object Divide(int v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(long v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(float v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(ushort v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(uint v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(ulong v)
        {
            return (((double) v) / this.m_value);
        }

        internal override object Divide(ArithmeticLiteral v)
        {
            return v.Divide(this.m_value);
        }

        internal override object Modulus()
        {
            return null;
        }

        internal override object Modulus(double v)
        {
            return (v % this.m_value);
        }

        internal override object Modulus(int v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(long v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(float v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(ushort v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(uint v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(ulong v)
        {
            return (((double) v) % this.m_value);
        }

        internal override object Modulus(ArithmeticLiteral v)
        {
            return v.Modulus(this.m_value);
        }

        internal override object Multiply()
        {
            return null;
        }

        internal override object Multiply(double v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(int v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(long v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(float v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(ushort v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(uint v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(ulong v)
        {
            return (v * this.m_value);
        }

        internal override object Multiply(ArithmeticLiteral v)
        {
            return v.Multiply(this.m_value);
        }

        internal override object Subtract()
        {
            return null;
        }

        internal override object Subtract(double v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(int v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(long v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(float v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(ushort v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(uint v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(ulong v)
        {
            return (v - this.m_value);
        }

        internal override object Subtract(ArithmeticLiteral v)
        {
            return v.Subtract(this.m_value);
        }

        internal override object Value
        {
            get
            {
                return this.m_value;
            }
        }
    }
}

