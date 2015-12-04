// Unreal Engine 4 C++ QuickStart Tutorial.

using UnrealBuildTool;
using System.Collections.Generic;

public class GearVrTestTarget : TargetRules
{
	public GearVrTestTarget(TargetInfo Target)
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
		OutExtraModuleNames.AddRange( new string[] { "GearVrTest" } );
	}
}
