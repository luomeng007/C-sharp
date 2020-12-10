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
        public void Run() {
            var list1 = new List<int>();
            
            list1.Add(1);
            list1.Add(2);
            
            print(list1);
        }
        
        public void print(List<int> array)
        {
            foreach(var element in array)
            {
                Globals.DataDisplay.LogMessage(element.ToString());
            }
        }
    }
}