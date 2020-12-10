using System;

using VirtualLab.Programming;
using VirtualLabAPI.Core.BasicFunctions;
using VirtualLabAPI.Core.Common;
using VirtualLabAPI.Core.DataVisualization;
using VirtualLabAPI.Core.FieldRepresentations;
using VirtualLabAPI.Core.Functions;
using VirtualLabAPI.Core.GeometryDescription;
using VirtualLabAPI.Core.LightPath;
using VirtualLabAPI.Core.Materials;
using VirtualLabAPI.Core.Modules;
using VirtualLabAPI.Core.Numerics;
using VirtualLabAPI.Core.Numerics.Region2D;
using VirtualLabAPI.Core.OpticalSystems;
using VirtualLabAPI.Core.Propagation;
using VirtualLabAPI.Core.SupportFunctions;

namespace OwnCode {
    public class VLModule {
        public void Run() {
            // we could only use bool type to deal with and, not and or.
            bool x = true;
            bool y = false;
            bool z, z1, z2;
            // or
            z = x || y;
            //  and
            z1 = x && y;
            // not
            z2 = !x;
            Globals.DataDisplay.LogMessage($"{z}");
            Globals.DataDisplay.LogMessage($"{z1}");
            Globals.DataDisplay.LogMessage($"{z2}");
        }
    }
}