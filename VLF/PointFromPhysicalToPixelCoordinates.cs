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
            // PointFromPhysicalToPixelCoordinates()
            // Converts a given point in physical coordinates into a point in pixel coordinates:static Vector PointFromPhysicalToPixelCoordinates  ( VectorD  pointInMeters, SamplingParameters samplingParameters) 
            //pointInMeters The point given in physical coordinates. 
            //samplingParameters The sampling parameters (needed for conversion). 
            
            // create a SamplingParameters
            int x = 5;
            int y = 5;
            Vector vec = new Vector(x, y);
//            Globals.DataDisplay.LogMessage($"The vector is: {vec}");
            // create vectorD, double or float type
            float x1 = 0.5f;
            float y1 = 0.25f;
            VectorD vecD = new VectorD(x1, y1);
//            Globals.DataDisplay.LogMessage($"The vectorD is: {vecD}");
            // create SamplingParameters
            SamplingParameters sam_para = new SamplingParameters(vec, vecD);
            Globals.DataDisplay.LogMessage($"The szie of sampling area is: {sam_para}");
            // tranform the coordinates
//            double x2 = 8.8;
//            double y2 = 10;
//            VectorD directionVector2D = new VectorD(x2, y2);
//            Vector pixelCoordinate = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D, sam_para);
//            Globals.DataDisplay.LogMessage($"{pixelCoordinate}");
            
//            double x3 = 10;
//            double y3 = 10;
//            VectorD directionVector2D1 = new VectorD(x3, y3);
//            Vector pixelCoordinate1 = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D1, sam_para);
//            Globals.DataDisplay.LogMessage($"{pixelCoordinate1}");
            
            List<double> list1 = new List<double>(10);
            List<double> list2 = new List<double>(10);
            for (int i = 0;i < 10;i++)
            {
                list1.Add(Convert.ToDouble(i));
                list2.Add(Convert.ToDouble(i + 2));
            }
            for (int i = 0;i < 10;i++)
            {
                double x2 = list1[i];
                double y2 = list2[i];
                VectorD directionVector2D = new VectorD(x2, y2);
                Vector pixelCoordinate = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D, sam_para);
                Globals.DataDisplay.LogMessage($"{pixelCoordinate}");
                // the sampling distance along x is 0.5, so 1 will be 1/0.5 = 2, and sampling distance along y is 0.25, so it will be 1 / 0.25 = 4.
                // the other points we use same algorithm.
            }
            
        }
    }
}
//[12/10/2020 19:00:45] The szie of sampling area is: (5; 5) × (0.5; 0.25) = (2.5; 1.25)
//[12/10/2020 19:00:45] (2; 10)
//[12/10/2020 19:00:45] (4; 14)
//[12/10/2020 19:00:45] (6; 18)
//[12/10/2020 19:00:45] (8; 22)
//[12/10/2020 19:00:45] (10; 26)
//[12/10/2020 19:00:45] (12; 30)
//[12/10/2020 19:00:45] (14; 34)
//[12/10/2020 19:00:45] (16; 38)
//[12/10/2020 19:00:45] (18; 42)
//[12/10/2020 19:00:45] (20; 46)




