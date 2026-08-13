using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : BaseCounter
{
   public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            KitchenObject kitchenObject = player.GetKitchenObject();
            kitchenObject.DestroySelf();
        }
    }
}
