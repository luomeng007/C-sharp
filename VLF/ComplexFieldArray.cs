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
            // ComplexFieldArray() 
            // method 1: ComplexFieldArray  (  ) :Default constructor. Creates an empty array of length 1. 
            ComplexFieldArray cfa = new ComplexFieldArray();
            Globals.DataDisplay.LogMessage($"{cfa}");
            
            // method 2:ComplexFieldArray  ( long  length ) :length Length of the array to create. 
            long x = 5;
            ComplexFieldArray cfa1 = new ComplexFieldArray(x);
            Globals.DataDisplay.LogMessage($"{cfa1}");
            
            // method 3: copy method, leave this out
            
            // method 4: normal way to create array
            // ComplexFieldArray  ( ComplexField[]  array ) :array One or more ComplexField objects or an array of ComplexField objects. 
            int x1 = 5;
            int y1 = 5;
            Vector vec = new Vector(x1, y1);
            ComplexField cf1 = new ComplexField(vec);
            ComplexField cf2 = new ComplexField(vec);
            // this array only have one value
            ComplexField[] array = new ComplexField[2];
            array[0] = cf1;
            array[1] = cf2;
            Globals.DataDisplay.LogMessage($"{array}");
            ComplexFieldArray cfa3 = new ComplexFieldArray(array);
            Globals.DataDisplay.LogMessage($"{cfa3}");
        }
    }
}
//[12/12/2020 08:34:32] VirtualLabAPI.Core.Numerics.ComplexFieldArray
//[12/12/2020 08:34:32] VirtualLabAPI.Core.Numerics.ComplexFieldArray
//[12/12/2020 08:34:32] VirtualLabAPI.Core.Numerics.ComplexField[]
//[12/12/2020 08:34:32] VirtualLabAPI.Core.Numerics.ComplexFieldArray





