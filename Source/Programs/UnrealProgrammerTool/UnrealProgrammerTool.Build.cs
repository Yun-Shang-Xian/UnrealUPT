// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class UnrealProgrammerTool : ModuleRules
{
    public UnrealProgrammerTool(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicIncludePaths.AddRange(
            new string[]
            {
                Path.Combine(EngineDirectory, "Source/Runtime/Launch/Public"),

                Path.Combine(ModuleDirectory, "Source/Action"),
                Path.Combine(ModuleDirectory, "Source/Classes"),
                Path.Combine(ModuleDirectory, "Source/Laucher"),
                Path.Combine(ModuleDirectory, "Source/Manager"),
                Path.Combine(ModuleDirectory, "Source/Slate"),
                Path.Combine(ModuleDirectory, "Source/Slate/ProjectUnit"),
                Path.Combine(ModuleDirectory, "Source/Utility"),
            }
            );

        PrivateIncludePaths.Add(System.IO.Path.Combine(EngineDirectory, "Source/Runtime/Launch/Private"));      // For LaunchEngineLoop.cpp include

        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "InputCore",
            "AppFramework",
            "ApplicationCore",
            "Projects",
            "Slate",
            "SlateCore",
            "StandaloneRenderer",
            "SourceCodeAccess",
            "EditorStyle",
        });

        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "SlateReflector",
        });

        DynamicallyLoadedModuleNames.AddRange(new string[]
        {
            //"SlateReflector",
        });

        if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            PrivateDependencyModuleNames.Add("XCodeSourceCodeAccess");
            AddEngineThirdPartyPrivateStaticDependencies(Target, "CEF3");
        }
        else if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PrivateDependencyModuleNames.Add("VisualStudioSourceCodeAccess");
        }
    }
}