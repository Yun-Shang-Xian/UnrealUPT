// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "UPTGameModeBase.generated.h"

/**
 *
 */
UCLASS()
class UPTPROJECT_API AUPTGameModeBase : public AGameModeBase
{
	GENERATED_BODY()
public:
	void InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage) override;
protected:
	void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
};
