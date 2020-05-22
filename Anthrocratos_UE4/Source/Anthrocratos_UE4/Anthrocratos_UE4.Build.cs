// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Anthrocratos_UE4 : ModuleRules
{
	public Anthrocratos_UE4(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
