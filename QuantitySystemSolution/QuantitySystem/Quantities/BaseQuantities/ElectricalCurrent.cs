﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantitySystem.Quantities.BaseQuantities
{
    public class ElectricalCurrent<T> : AnyQuantity<T>
    {
        public ElectricalCurrent() : base(1) { }

        public ElectricalCurrent(float exponent) : base(exponent) { }

        public override QuantityDimension Dimension
        {
            get
            {
                return new QuantityDimension(0, 0, 0, 0, 1, 0, 0) * Exponent;
            }
        }


        public static implicit operator ElectricalCurrent<T>(T value)
        {
            ElectricalCurrent<T> Q = new ElectricalCurrent<T>();

            Q.Value = value;

            return Q;
        }
    }
}
