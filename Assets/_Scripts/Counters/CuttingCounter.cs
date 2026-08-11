using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cuttingRecipeSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //There is no kitchen object here
            if (player.HasKitchenObject())
            {
                //Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //Player is not carrying something
            }
        }
        else
        {
            //There is a kitchen Object here
            if (player.HasKitchenObject())
            {

            }
            else
            {
                //Player is not carrying something
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject())
        {
            //There is a kitchen object here and the player is carrying something
            GetKitchenObject().DestroySelf();
            KitchenObject.SpawnKitchenObject(cuttingRecipeSO, this);
        }
    }
}
