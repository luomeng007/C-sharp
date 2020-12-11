using System;
using System.Collections.Generic; // contain List

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
            // complex number
            // method 1:
            // Complex(double  Re, double Im)
            double Re = 5.1;
            double Im = 6.0;
            Complex c = new Complex(Re, Im);
            Globals.DataDisplay.LogMessage($"{c}");
            // method 2:
            Complex c1 = new Complex(Re);
            Globals.DataDisplay.LogMessage($"{c1}");
            // method 3: copy method, leave out
        }
    }
}




