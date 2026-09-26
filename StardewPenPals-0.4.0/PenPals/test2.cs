using System;
using StardewValley;
using StardewValley.Quests;

public class Test
{
    public void Run(NPC npc, Farmer farmer, Item item)
    {
        var previousActiveItem = farmer.ActiveItem;
        farmer.ActiveItem = item;
        try
        {
            npc.tryToReceiveActiveObject(farmer);
        }
        finally
        {
            farmer.ActiveItem = previousActiveItem;
        }
    }
}
