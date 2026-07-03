# Container Search Research

## SPT Version

SPT 4.0.13  
EFT 0.16.9.40087

## Found class

`GClass3515`

## Found method

`method_6() : Task`

## Purpose

This method controls the vanilla container/body search loop.

## Important logic

```csharp
float num = flag
    ? (1f + skillsInfo.AttentionLootSpeedValue + skillsInfo.SearchBuffSpeedValue)
    : (1f + skillsInfo.AttentionLootSpeedValue);

Task.Delay((int)((this.Bool_0 ? 0f : ((float)UnityEngine.Random.Range(1, 3) / num)) * 1000f))