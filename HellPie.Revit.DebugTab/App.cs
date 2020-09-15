using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Autodesk.Revit.UI;
using UIFramework;

namespace HellPie.Revit.DebugTab {
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    internal class App : IExternalApplication {
        /// <inheritdoc />
        public Result OnStartup(UIControlledApplication application) {
            RevitRibbonControl ribbonControl = RevitRibbonControl.RibbonControl;

            ribbonControl.Tabs.Add(ribbonControl.DebugTab.Clone());
            ribbonControl.Tabs.Last().IsVisible = true;
            ribbonControl.Tabs.Last().Id = "Debug_Shadowed";

            return Result.Succeeded;
        }

        /// <inheritdoc />
        public Result OnShutdown(UIControlledApplication application) {
            return Result.Succeeded;
        }
    }
}
