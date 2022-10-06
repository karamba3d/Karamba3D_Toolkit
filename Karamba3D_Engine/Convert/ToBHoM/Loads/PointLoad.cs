﻿namespace BH.Engine.Adapters.Karamba3D
{
    using oM.Base;
    using oM.Structure.Elements;
    using oM.Structure.Loads;
    using System.Collections.Generic;

    public static partial class Convert
    {
        private static IEnumerable<ILoad> ToBhOM(this Karamba.Loads.PointLoad k3dPointLoad, BhOMModel bhomModel)
        {
            var nodes = new BHoMGroup<Node>();
            nodes.Elements.Add(bhomModel.Nodes[k3dPointLoad.node_ind]);

            yield return new PointLoad()
            {
                Axis = LoadAxis.Global,
                Loadcase = null,
                Force = k3dPointLoad.force.ToBhOM(),
                Moment = k3dPointLoad.moment.ToBhOM(),
                Projected = false,
                Objects = nodes,
            };

        }
    }
}