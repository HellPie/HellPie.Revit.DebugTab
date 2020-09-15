using System.Diagnostics.CodeAnalysis;
using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Debug Tab Enabled for Revit")]
[assembly: AssemblyDescription("Enable the hidden internal Debug tab in the Revit Ribbon")]

[assembly: AssemblyProduct("Debug Tab Enabled for Revit")]
[assembly: AssemblyCompany("Diego \"HellPie\" Rossi (https://hellpie.dev)")]
[assembly: AssemblyCopyright("Copyright © Diego Rossi (https://hellpie.dev)")]

[assembly: NeutralResourcesLanguage("en")]

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("81DA0C07-123D-4B6F-9B1D-175F59BB409F")]

// Versions must be represented in the following schema:
//     - <Major>.<Minor>.<Build>.<Revision>
//
// Major:
//     - Follows the year of release
// Minor:
//     - Follows the yearly release numbers
//     - Increments:
//         - When breaking changes are introduced
//         - When planned releases reach feature set
// Build:
//     - Marks patches to Stable releases only
//     - Is always 0 in non-Stable releases
// Revision:
//     - 1*** Marks Canary releases (1001 = Canary 1, 1002 = Canary 2, etc.)
//     - 2*** Marks Beta releases (2001 = PTB 1, 2002 = PTB 2, etc.)
//     - 3*** Marks Release Candidate releases (3001 = RC1, 3002 = RC2, etc.)
//     - 4000 Marks Stable releases

[assembly: AssemblyVersion(VersionInformation.Version)]
[assembly: AssemblyFileVersion(VersionInformation.Version)]
[assembly: AssemblyInformationalVersion(VersionInformation.Version)]

[SuppressMessage("ReSharper", "CheckNamespace")]
internal static class VersionInformation {
    private const string Major    = "2020";
    private const string Minor    = "0";
    private const string Build    = "0";
    private const string Revision = "4000";
    public const  string Version  = Major + "." + Minor + "." + Build + "." + Revision;
}
