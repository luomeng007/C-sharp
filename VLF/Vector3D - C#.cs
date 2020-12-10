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

// float 类型的x,y,z类型的参数也可以被使用

namespace OwnCode {
    public class VLModule {
        public void Run() {
            // Three kinds of calling method to create a Vector3D
            // 1. Creates a Vector3D from three double values： Vector3D  ( double  x,  double y,  double z  )   
            // 2. Creates a copy of the referenced Vector3D  ： Vector3D  ( Vector3D  toCopy )  
            // 3. Creates a Vector3D using given angles and length. Vector3D  ( double  alpha,  double beta,  double length,  bool useDirectionAngles  )  
            // method 1
            double x = 0;
            double y = 0;
            double z = 1;
            Vector3D vec3D = new Vector3D(x, y, z);
            Globals.DataDisplay.LogMessage($"The vector3D is: {vec3D}");
            // method 2
            Vector3D vec3D1 = new Vector3D(vec3D);
            Globals.DataDisplay.LogMessage($"The vector3D1 is: {vec3D1}");
            // method 3
            double alpha = 30;
            double beta = 60;
            double length = 1;
            // true means: use cartesian angle, false means sphere angles.
            bool flag = true;
            Vector3D vec3D2 = new Vector3D(alpha, beta, length, flag);
            Globals.DataDisplay.LogMessage($"The vector3D2 is: {vec3D2}");
            double alpha1 = 45;
            double beta1 = 10;
            Vector3D vec3D3 = new Vector3D(alpha1, beta1, length, flag);
            Globals.DataDisplay.LogMessage($"The vector3D2 is: {vec3D3}");
        }
    }
}
//The vector3D is: (0; 0; 1)
//The vector3D1 is: (0; 0; 1)
//The vector3D2 is: (0.98683; -0.049307; -0.15406)
//The vector3D2 is: (-0.80547; -0.32241; -0.49727)

