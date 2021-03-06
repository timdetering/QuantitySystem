﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantitySystem.Quantities.BaseQuantities
{
    public class AmountOfSubstance<T> : AnyQuantity<T>
    {
        public AmountOfSubstance() : base(1) { }

        public AmountOfSubstance(float exponent) : base(exponent) { }


        private static QuantityDimension _Dimension = new QuantityDimension(0, 0, 0, 0, 0, 1, 0);
        public override QuantityDimension Dimension
        {
            get
            {
                return _Dimension * Exponent;
            }
        }

        public static implicit operator AmountOfSubstance<T>(T value)
        {
            AmountOfSubstance<T> Q = new AmountOfSubstance<T>();

            Q.Value = value;

            return Q;
        }


    }
}
