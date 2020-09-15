using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.UI;

namespace HellPie.Revit.DebugTab {
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    internal class App : IExternalApplication {
        /// <inheritdoc />
        public Result OnStartup(UIControlledApplication application) {
            return Result.Succeeded;
        }

        /// <inheritdoc />
        public Result OnShutdown(UIControlledApplication application) {
            return Result.Succeeded;
        }
    }
}
