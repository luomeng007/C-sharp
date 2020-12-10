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
            // take x, y, z value of vector3D separately
            // create vector3D
            double x = 3;
            double y = 4;
            double z = 5; 
            Vector3D vec3D = new Vector3D(x, y, z);
            Globals.DataDisplay.LogMessage($"The vector3D is: {vec3D}");
            Globals.DataDisplay.LogMessage($"The X portion of vector3D is: {vec3D.X}");
            Globals.DataDisplay.LogMessage($"The Y portion of vector3D is: {vec3D.Y}");
            Globals.DataDisplay.LogMessage($"The Z portion of vector3D is: {vec3D.Z}");        
        }
    }
}
//[12/10/2020 16:19:45] The X portion of vector3D is: 3
//[12/10/2020 16:19:45] The Y portion of vector3D is: 4
//[12/10/2020 16:19:45] The Z portion of vector3D is: 5


