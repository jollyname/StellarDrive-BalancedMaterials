using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(BalancedMaterials.BuildInfo.Description)]
[assembly: AssemblyDescription(BalancedMaterials.BuildInfo.Description)]
[assembly: AssemblyCompany(BalancedMaterials.BuildInfo.Company)]
[assembly: AssemblyProduct(BalancedMaterials.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + BalancedMaterials.BuildInfo.Author)]
[assembly: AssemblyTrademark(BalancedMaterials.BuildInfo.Company)]
[assembly: AssemblyVersion(BalancedMaterials.BuildInfo.Version)]
[assembly: AssemblyFileVersion(BalancedMaterials.BuildInfo.Version)]
[assembly: MelonInfo(typeof(BalancedMaterials.BalancedMaterials), BalancedMaterials.BuildInfo.Name, BalancedMaterials.BuildInfo.Version, BalancedMaterials.BuildInfo.Author, BalancedMaterials.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("CuriousOwlGames", "StellarDrive")]