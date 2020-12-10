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
            // two kinds of calling method to create a Vector
            // 1. Creates a Vector from two int values： Vector  ( int  x, int y )  
            // 2. Copy constructor ： Vector  ( Vector  v )  
            // method 1
            int x1 = 1;
            int y1 = 2;
            Vector vec = new Vector(x1, y1);
            Globals.DataDisplay.LogMessage($"The vector is: {vec}");
            // method 2
            Vector vec1 = new Vector(vec);
            Globals.DataDisplay.LogMessage($"The vectorD1 is: {vec1}");           
        }
    }
}
//The vector is: (1; 2)
//The vectorD1 is: (1; 2)
