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
            // Create SamplingParameters
            // 1. Creates SamplingParameters using given sampling points and distance. 
            // SamplingParameters  ( Vector  SamplingPoints, VectorD SamplingDistance ) 
            // create vector, 3 points along x axis, and 3 points along y aixs
            int x = 5;
            int y = 5;
            Vector vec = new Vector(x, y);
            Globals.DataDisplay.LogMessage($"The vector is: {vec}");
            // create vectorD, double or float type
            float x1 = 0.5f;
            float y1 = 0.25f;
            VectorD vecD = new VectorD(x1, y1);
            Globals.DataDisplay.LogMessage($"The vectorD is: {vecD}");
            // create SamplingParameters
            SamplingParameters sam_para = new SamplingParameters(vec, vecD) ;
            Globals.DataDisplay.LogMessage($"The szie of sampling area is: {sam_para}");
            Globals.DataDisplay.LogMessage($"The number of sampling points is: {sam_para.SamplingPoints}");
            Globals.DataDisplay.LogMessage($"The number of sampling points along x axis is: {sam_para.SamplingPoints.X}");
            Globals.DataDisplay.LogMessage($"The number of sampling points along y axis is: {sam_para.SamplingPoints.Y}");
            Globals.DataDisplay.LogMessage($"The distance of sampling area is: {sam_para.SamplingDistance }");
            Globals.DataDisplay.LogMessage($"The distance of sampling area along x axis is: {sam_para.SamplingDistance.X }");
            Globals.DataDisplay.LogMessage($"The distance of sampling area along y axis is: {sam_para.SamplingDistance.Y }");
        }
    }
}
//[12/10/2020 16:14:02] The vector is: (5; 5)
//[12/10/2020 16:14:02] The vectorD is: (0.5; 0.25)
//[12/10/2020 16:14:02] The szie of sampling area is: (5; 5) × (0.5; 0.25) = (2.5; 1.25)
//[12/10/2020 16:14:02] The number of sampling points is: (5; 5)
//[12/10/2020 16:14:02] The number of sampling points along x axis is: 5
//[12/10/2020 16:14:02] The number of sampling points along y axis is: 5
//[12/10/2020 16:14:02] The distance of sampling area is: (0.5; 0.25)
//[12/10/2020 16:14:02] The distance of sampling area along x axis is: 0.5
//[12/10/2020 16:14:02] The distance of sampling area along y axis is: 0.25

