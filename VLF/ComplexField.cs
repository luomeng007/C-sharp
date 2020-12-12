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
            // ComplexField() 
            // totally seven method
            // method 1:
            // Creates a ComplexField with 1x1 sampling points. The default precision is used and the internal data presentation is complex. 
            ComplexField cf = new ComplexField();
            Globals.DataDisplay.LogMessage($"{cf}");
            
            // method 2
            // ComplexField  ( Vector  samplingPoints )
            // samplingPoints Number of points in x and y direction. 
            int x = 5;
            int y = 5;
            Vector vec = new Vector(x, y);
            ComplexField cf1 = new ComplexField(vec);
            Globals.DataDisplay.LogMessage($"{cf1}");
            
            // method 3: ComplexField  ( ComplexField  field ), leave out this one
            // method 4: ComplexField  ( Vector  samplingPoints, bool isComplex, PrecisionMode  precision) 
            // samplingPoints Number of values in x and y direction. 
            // precision Desired PrecisionMode. 
            // isComplex Indicates if new ComplexField should internally store real + imaginary part(complex = true) or the real part only(complex = false)(imaginary part is zero). 
            int x1 = 5;
            int y1 = 5;
            Vector vec1 = new Vector(x1, y1);
            bool flag = true;
            
            ComplexField cf2 = new ComplexField(vec1, flag, PrecisionMode.Double);
            Globals.DataDisplay.LogMessage($"{cf2}");
            
            // method 5 ComplexField(Vector  samplingPoints, bool isComplex, PrecisionMode  precision, Complex c)
            double Re = 5.5;
            double Im = 6.0;
            Complex c = new Complex(Re, Im);
            ComplexField cf3 = new ComplexField(vec1, flag, PrecisionMode.Double, c);
            Globals.DataDisplay.LogMessage($"{cf3}");
            
            // method 6: ComplexField(Vector  samplingPoints, bool isComplexFunction, PrecisionMode  precision, RealFunction f, ParallelizationType  parallelizationType)
            
            ComplexField cf4 = new ComplexField(vec1, flag, PrecisionMode.Double, f ,ParallelizationType.AutomaticMeasure );
            // how to make real function no idea. Need to ask Christian.
            
        }
    }
}




