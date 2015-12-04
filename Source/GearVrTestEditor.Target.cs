// Unreal Engine 4 C++ QuickStart Tutorial.

using UnrealBuildTool;
using System.Collections.Generic;

public class GearVrTestEditorTarget : TargetRules
{
	public GearVrTestEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
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
