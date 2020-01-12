using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitCAD.DatabaseServices;

namespace LitCAD.UI
{
    internal class EllipseHitter : EntityHitter
    {
        internal override bool Hit(PickupBox pkbox, Entity entity)
        {
            Ellipse ellipse = entity as Ellipse;
            if (ellipse == null)
                return false;

            return MathUtils.BoundingCross(pkbox.reservedBounding, ellipse);
        }
    }
}
