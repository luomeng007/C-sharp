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
            // six kind of method to define DataArray2D
            // DataArray2D could be use as IDocument
            // method 1, copy method, leave out
            // method 2
            //DataArray2D  (ComplexFieldArray  data,  
            // PhysicalProperty[]  physicalPropertiesOfData,  
            // string[]  commentsOfData,  
            // double  samplingDistanceX,  
            // double  coordinateOfFirstDataPointX,  
            // PhysicalProperty  physicalPropertyOfCoordinatesX,  
            // string  commentOfCoordinatesX,  
            // double  samplingDistanceY,  
            // double  coordinateOfFirstDataPointY,  
            // PhysicalProperty  physicalPropertyOfCoordinatesY,  
            // string  commentOfCoordinatesY,  
            // ExtrapolationInfo  extrapolation = null,  
            // InterpolationMethod  interpolationX = InterpolationMethod.Nearest,  
            // InterpolationMethod  interpolationY = InterpolationMethod.Nearest
            // )  
            
            // create ComplexFieldArray, x1, y1 is like the dimension in CFieldDerivative2DReal
            int x1 = 2;
            int y1 = 2;
            
            Vector vec1 = new Vector(x1, y1);
            
            ComplexField cf1 = new ComplexField(vec1);
            // need to distinguish the ComplexField and ComplexField[], I went to wrong direction before.
            
            // this array only have one value
            ComplexField[] array = new ComplexField[4];
            array[0] = cf1;
            array[1] = cf1;
            array[2] = cf1;
            array[3] = cf1;
            
            ComplexFieldArray cfa1 = new ComplexFieldArray(array);
            
//            Globals.DataDisplay.LogMessage($"{cfa1}");
            // create PhysicalProperty[]
//            PhysicalProperty[] pp = new PhysicalProperty[]{ PhysicalProperty.NoUnit };
            // string[]
//            string[] str = new string[] { "Hello World!" };
            // CFieldDerivative1DReal
            
            int sx = 2;
            int sy = 2;
            Vector svec = new Vector(sx, sy);
            // create vectorD, double or float type
            float sx1 = 1f;
            float sy1 = 1f;
            VectorD svecD = new VectorD(sx1, sy1);
            SamplingParameters sam_para = new SamplingParameters(svec, svecD) ;
            Globals.DataDisplay.LogMessage($"{sam_para}");  // (2; 2) × (1; 1) = (2; 2)

            
            // string should use "", char should use ''
//            string str1 = "x coordinate";
//            string str2 = "y coordinate";
            // here we use method: CFieldDerivative1DReal  ( int  samplingPoints ) 
            double d1 = (-0.5 * sam_para.Diameter.X) + (0.5 * sam_para.SamplingDistanceX);
            double d2 = (-0.5 * sam_para.Diameter.Y) + (0.5 * sam_para.SamplingDistanceY);
            
            //debug
            // with dot and without dot, both are same
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistanceX}");
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistanceY}");
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistance.X}");
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistance.Y}");
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistance.X.GetType()}");     // System.Double
//            Globals.DataDisplay.LogMessage($"{sam_para.SamplingDistance.Y.GetType()}");     // System.Double
            
            DataArray2D da2d = new DataArray2D(cfa1, 
                new PhysicalProperty[]{ PhysicalProperty.NoUnit },
                new string[] { "Hello World!" }, 
                sam_para.SamplingDistance.X,
                d1,
                PhysicalProperty.NoUnit, 
                "x coordinate",     
                sam_para.SamplingDistance.Y, 
                d2,
                PhysicalProperty.NoUnit, 
                "y coordinate");
//            Globals.DataDisplay.ShowDocument($"{da2d}");
        }
    }
}

// meet some problem


