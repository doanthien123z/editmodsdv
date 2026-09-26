using System;
using StardewValley;
using StardewValley.Quests;

public class Test
{
    public void Run(NPC npc, Item item)
    {
        ItemDeliveryQuest q = new ItemDeliveryQuest();
        q.checkIfComplete(npc, -1, -1, item);
        FishingQuest fq = new FishingQuest();
        fq.checkIfComplete(npc, -1, -1, item);
    }
}
