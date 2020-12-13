using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
                String pathOfFile = @"C:\Users\15025\Desktop\showDocumetDebug\showDocumentDebug.TXT";
                //size in s-domain to use for "sum up flux data"
                VectorD sizeSDomain = new VectorD(6, 6);
                //number of cells to use for "sum up flux data"
                Vector numberPointsSDomain = new Vector(7, 7);

         public void Run() {
                string[] lines = File.ReadLines(pathOfFile).ToArray();
                List<Vector3D> listPosition = new List<Vector3D>();
                List<float> listFlux = new List<float>();

                for (int runLines = 1; runLines < lines.Length; runLines++) 
                {
                    //read line from file
                    string readString = lines[runLines];

                    string[] splittedString = readString.Split(' ');

                    Vector3D positionVector = new Vector3D();
                    try {
                        //parse x, y, z position to double
                        float xPos = float.Parse(splittedString[0]);
                        float yPos = float.Parse(splittedString[1]);
                        float zPos = float.Parse(splittedString[1]);
                        //store in position vector variable
                        positionVector = new Vector3D(xPos, yPos, yPos);
                    }
                    catch {
                        continue;
                    }


                    float fluxValue = 0;
                    try {
                        fluxValue = float.Parse(splittedString[2]);
                    }
                    catch {         
                    }
                
                    listPosition.Add(positionVector);
                    listFlux.Add(fluxValue);

                }

                SamplingParameters sPara = new SamplingParameters();
                sPara.SamplingPoints = this.numberPointsSDomain;
                sPara.SamplingDistance = new VectorD(this.sizeSDomain.X / (sPara.SamplingPoints.X - 1),
                                                     this.sizeSDomain.Y / (sPara.SamplingPoints.Y - 1));
                
                
                //generate matrix to sum up flux values
                CFieldDerivative2DReal cfSummedFlux = new CFieldDerivative2DReal(sPara.SamplingPoints, PrecisionMode.Double);
                cfSummedFlux.Fill(0);

                //loop over all flux values
                for (int runReadRays = 0; runReadRays < listFlux.Count; runReadRays++) {

                    Vector3D directionVector = listPosition[runReadRays];

                    VectorD directionVector2D = new VectorD(directionVector.X, directionVector.Y);

                    float currentFlux = listFlux[runReadRays];

                    Vector pixelCoordinate = CoordinateTransformations.PointFromPhysicalToPixelCoordinates(directionVector2D, sPara);

                    cfSummedFlux[pixelCoordinate.X, pixelCoordinate.Y] += currentFlux;
                }
        
                DataArray2D da2DFluxDistribution = new DataArray2D(new ComplexFieldArray(new ComplexField[] { cfSummedFlux }),
                    new PhysicalProperty[] { PhysicalProperty.NoUnit },
                    new string[] { "Summed flux" },
                    sPara.SamplingDistance.X,
                    (-0.5 * sPara.Diameter.X) + (0.5 * sPara.SamplingDistanceX),
                    PhysicalProperty.NoUnit,
                    "Sx",
                    sPara.SamplingDistance.Y,
                    (-0.5 * sPara.Diameter.Y) + (0.5 * sPara.SamplingDistanceY),
                    PhysicalProperty.NoUnit,
                    "Sy");

                Globals.DataDisplay.ShowDocument(da2DFluxDistribution, "Summed Flux");
        }
    }
}