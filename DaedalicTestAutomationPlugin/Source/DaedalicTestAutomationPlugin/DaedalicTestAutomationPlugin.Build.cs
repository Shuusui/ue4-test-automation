// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class DaedalicTestAutomationPlugin : ModuleRules
	{
		public DaedalicTestAutomationPlugin(ReadOnlyTargetRules Target) : base(Target)
		{
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			ShortName = "DTA";

			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
                    "CoreUObject",
                    "Engine",
                    "InputCore",
                    "Gauntlet",
                    "UMG",
                    "SlateCore",
                    "RenderCore",
                    "Projects"
                }
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
			string ReportPath = "$(PluginDir)/Content/ReportTemplates/";
			RuntimeDependencies.Add($"{ReportPath}bootstrap.min.css");
			RuntimeDependencies.Add($"{ReportPath}PerformanceReport.template.html");
			RuntimeDependencies.Add($"{ReportPath}PerformanceReportBudgetViolation.template.html");
			RuntimeDependencies.Add($"{ReportPath}PerformanceReportMap.template.html");

		}
	}
}
