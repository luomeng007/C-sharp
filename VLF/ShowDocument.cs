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
            // need to study again tomorrow!
            VectorD sizeSDomain = new VectorD(2, 2);
            // should be odd number, then we could get symmetric structure about (0, 0) point
            Vector numberPointsSDomain = new Vector(5, 5);
            
            SamplingParameters sPara = new SamplingParameters();
            
            sPara.SamplingPoints = numberPointsSDomain;
            sPara.SamplingDistance = new VectorD(sizeSDomain.X / (sPara.SamplingPoints.X - 1),
                sizeSDomain.Y / (sPara.SamplingPoints.Y - 1));


            CFieldDerivative2DReal cfSummedFlux = new CFieldDerivative2DReal(sPara.SamplingPoints, PrecisionMode.Double);
            cfSummedFlux.Fill(0);
            // 
            double x1 = 0;
            double y1 = -0.5;
            double x2 = 0;
            double y2 = 0.5;
            VectorD directionVector2D1 = new VectorD(x1, y1);
            VectorD directionVector2D2 = new VectorD(x2, y2);
            Vector pixelCoordinate = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D1, sPara);
            Globals.DataDisplay.LogMessage($"{pixelCoordinate}");
            cfSummedFlux[pixelCoordinate.X, pixelCoordinate.Y] += 10;
            Vector pixelCoordinate1 = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D2, sPara);
            Globals.DataDisplay.LogMessage($"{pixelCoordinate1}");
            cfSummedFlux[pixelCoordinate1.X, pixelCoordinate1.Y] += 14;
            
            DataArray2D da2DFluxDistribution = new DataArray2D(new ComplexFieldArray(new ComplexField[] { cfSummedFlux }),
                new PhysicalProperty[] { PhysicalProperty.NoUnit },
                new string[] { "Summed flux" },
                sPara.SamplingDistance.X,
                -0.5 * sPara.Diameter.X,
                PhysicalProperty.NoUnit,
                "Sx",
                sPara.SamplingDistance.Y,
                -0.5 * sPara.Diameter.Y,
                PhysicalProperty.NoUnit,
                "Sy");
            
            Globals.DataDisplay.ShowDocument(da2DFluxDistribution, "Summed Flux");
        }
    }
}




