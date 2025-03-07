// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class XFVoiceUE : ModuleRules
{
	public XFVoiceUE(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore","Json" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
        //指定搜索文件路径
        PrivateIncludePaths.Add("XFVoiceUE/Private");
        PublicIncludePaths.Add("XFVoiceUE/Public");
        //引入讯飞语音库
        PublicLibraryPaths.AddRange(new string[] { "../XFVoiceLib/libs" });
        PublicAdditionalLibraries.AddRange(new string[] { "msc_x64.lib" });
        //添加文件搜索路径
        PublicIncludePaths.AddRange(new string[]{ "../XFVoiceLib/include"});


    }
}
