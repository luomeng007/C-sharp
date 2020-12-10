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
            // three kinds of calling method to create a VectorD
            // 1. Creates a VectorD from two double values； VectorD(double  x,  double y), 
            // 2. Creates a new VectorD object from an existing object： VectorD  ( VectorD  vector ) 
            // 3. Creates a new VectorD object from an existing Vector： VectorD  ( Vector  vector )
            // method 1
            double x = 5;
            double y = 10;
            VectorD vecD = new VectorD(x, y);
            Globals.DataDisplay.LogMessage($"The vectorD is: {vecD}");
            // method 2
            VectorD vecD1 = new VectorD(vecD);
            Globals.DataDisplay.LogMessage($"The vectorD1 is: {vecD1}");
            // method 3
            int x1 = 1;
            int y1 = 2;
            Vector vec = new Vector(x1, y1);
            Globals.DataDisplay.LogMessage($"The vector is: {vec}");
        }
    }
}
//The vectorD is: (5; 10)
//The vectorD1 is: (5; 10)
//The vector is: (1; 2)
