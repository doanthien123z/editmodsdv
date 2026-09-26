$asm = [Reflection.Assembly]::LoadFrom("D:\Steam\steamapps\common\Stardew Valley\Stardew Valley.dll")
$type = $asm.GetType("StardewValley.Quests.ItemDeliveryQuest")
$type.GetMethods() | Select-Object Name
