using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Autodesk.Revit.UI;

namespace HellPie.Revit.DebugTab {
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    internal class App : IExternalApplication {
        /// <inheritdoc />
        public Result OnStartup(UIControlledApplication application) {
            UIFramework.RevitRibbonControl.RibbonControl.Tabs.Add(UIFramework.RevitRibbonControl.RibbonControl.DebugTab.Clone());
            UIFramework.RevitRibbonControl.RibbonControl.Tabs.Last().IsVisible = true;
            UIFramework.RevitRibbonControl.RibbonControl.Tabs.Last().Id = "Debug_Shadowed";

            return Result.Succeeded;
        }

        /// <inheritdoc />
        public Result OnShutdown(UIControlledApplication application) {
            return Result.Succeeded;
        }
    }
}
