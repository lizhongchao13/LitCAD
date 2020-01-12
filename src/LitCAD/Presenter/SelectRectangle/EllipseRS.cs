﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitCAD.DatabaseServices;

namespace LitCAD
{
    internal class EllipseRS : EntityRS
    {
        internal override bool Cross(Bounding selectBound, Entity entity)
        {
            Ellipse ellipse = entity as Ellipse;
            if (ellipse == null)
            {
                return false;
            }

            return MathUtils.BoundingCross(selectBound, ellipse);
        }
    }
}
