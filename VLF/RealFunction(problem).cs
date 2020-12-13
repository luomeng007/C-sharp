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
            // RealFuntion() 
            // RealFunction()
            // Complex VirtualLabAPI.Core.Numerics.ComplexFunction  ( double  x, double y ) 
            double x = 2;
            double y = 3;
            RealFunction rf = new RealFunction (x, y);
            Globals.DataDisplay.LogMessage($"{rf}");
            
            // how to apply real function
        }
    }
}




