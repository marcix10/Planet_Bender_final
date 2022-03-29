using UnrealBuildTool;

public class BlockoutTarget : TargetRules
{
	public BlockoutTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Blockout");
	}
}
