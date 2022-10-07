﻿namespace BH.Engine.Adapters.Karamba3D
{
    using Karamba.Loads.Beam;
    using Karamba.Models;
    using Karamba3D_Engine;
    using oM.Structure.Loads;
    using System.Collections.Generic;
    using System.Linq;
    using Adapter.Karamba3D;

    public static partial class Convert
    {
        private static IEnumerable<ILoad> ToBhOM(this TranslationalGap k3dLoad, Model k3dModel, BhOMModel bhomModel)
        {
            K3dLogger.RecordError(
                string.Format(
                    Resource.WarningNotSupportedType,
                    nameof(TranslationalGap)));

            return Enumerable.Empty<ILoad>();
        }
    }
}