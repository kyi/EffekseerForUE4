// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class EffekseerForUE4Target : TargetRules
{
    public EffekseerForUE4Target(TargetInfo Target)
    : base(Target)
    {
        Type = TargetType.Game;
        ExtraModuleNames.Add("EffekseerForUE4");
    }

    // UE4.15
    /*
	public EffekseerForUE4Target(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "EffekseerForUE4" } );
	}
    */
}
