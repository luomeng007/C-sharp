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
            // CFieldDerivative1DReal
            int sampling = 10;
            CFieldDerivative1DReal cf = new CFieldDerivative1DReal(sampling);  
            Globals.DataDisplay.LogMessage($"The CFieldDerivative1DReal is: {cf}");
            // CFieldDerivative2DReal, cannot find this in our documentation
            int x = 5;
            int y = 5;
            Vector vec = new Vector(x, y);
            CFieldDerivative2DReal cf1 = new CFieldDerivative2DReal(vec);
            Globals.DataDisplay.LogMessage($"The CFieldDerivative1DReal is: {cf1}");
            // CFieldDerivative3DReal, we do not have CFieldDerivative3DReal stuff, be careful about this.
            double x1 = 3;
            double y1 = 4;
            double z1 = 5;
            Vector3D vec3D = new Vector3D(x1, y1, z1);
            // CFieldDerivative3DReal cf2 = new CFieldDerivative3DReal(vec3D);
            // Globals.DataDisplay.LogMessage($"The CFieldDerivative1DReal is: {cf2}");
        }
    }
}
//[12/10/2020 18:17:42] The CFieldDerivative1DReal is: VirtualLabAPI.Core.Numerics.CFieldDerivative1DReal
//[12/10/2020 18:17:42] The CFieldDerivative1DReal is: VirtualLabAPI.Core.Numerics.CFieldDerivative2DReal



