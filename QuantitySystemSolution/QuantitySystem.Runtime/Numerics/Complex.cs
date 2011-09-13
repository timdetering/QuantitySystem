﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NativeComplex = System.Numerics.Complex;
using System.Globalization;

namespace Qs.Numerics
{
    /// <summary>
    /// Qs Complex storage type.
    /// </summary>
    public struct Complex
    {
        private NativeComplex _NativeComplex;
        public NativeComplex NativeComplex
        {
            get
            {
                return _NativeComplex;
            }
        }

        public double Real
        {
            get
            {
                return _NativeComplex.Real;
            }
        }

        public double Imaginary
        {
            get
            {
                
                return _NativeComplex.Imaginary;
            }
        }

        
        public static  readonly Complex Zero =  new Complex(NativeComplex.Zero);
         

        public Complex(NativeComplex nativeComplex)
        {
            _NativeComplex = nativeComplex;
        }

        public Complex(double real, double imaginary)
        {

            _NativeComplex = new NativeComplex(real, imaginary);
        }



        public override string ToString()
        {
            return "(" + Real.ToString(CultureInfo.InvariantCulture) + ", " + Imaginary.ToString(CultureInfo.InvariantCulture) + "i)";
        }


        public static implicit operator Complex(double d)
        {
            NativeComplex dd = d;
            return new Complex(dd);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.NativeComplex == rhs.NativeComplex;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.NativeComplex != rhs.NativeComplex;
        }

        public override bool Equals(object obj)
        {
            return _NativeComplex.Equals(obj);
        }
        public override int GetHashCode()
        {
            return _NativeComplex.GetHashCode();
        }

        #region Operations
        public static Complex operator +(Complex a, Complex b)
        {
            var result = a._NativeComplex + b._NativeComplex;
            return new Complex(result);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            var result = a._NativeComplex - b._NativeComplex;
            return new Complex(result);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            var result = a._NativeComplex * b._NativeComplex;
            return new Complex(result);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            var result = a._NativeComplex / b._NativeComplex;
            return new Complex(result);
        }


        public static Complex operator /(double a, Complex b)
        {
            var result = new NativeComplex(a, 0) / b._NativeComplex;
            return new Complex(result);
        }

        public static Complex operator /(Complex a, double b)
        {
            var result = a._NativeComplex / new NativeComplex(b, 0);
            return new Complex(result);
        }

        public static Complex operator *(double a, Complex b)
        {
            var result = new NativeComplex(a, 0) * b._NativeComplex;
            return new Complex(result);
        }

        public static Complex operator *(Complex a, double b)
        {
            var result = a._NativeComplex * new NativeComplex(b, 0);
            return new Complex(result);
        }

        public static Complex Pow(Complex a, double power)
        {
            var result = NativeComplex.Pow(a._NativeComplex, power);
            return new Complex(result);
        }
        
        public static Complex Pow(Complex a, Complex power)
        {
            var result = NativeComplex.Pow(a._NativeComplex, power._NativeComplex);
            return new Complex(result);
        }


        #endregion
    }
}
