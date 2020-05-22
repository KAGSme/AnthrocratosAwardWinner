// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Anthrocratos_UE4Target : TargetRules
{
	public Anthrocratos_UE4Target(TargetInfo Target) : base(Target)
    {
		Type = TargetType.Game;

        ExtraModuleNames.AddRange(new string[] { "Anthrocratos_UE4" });
    }
}
