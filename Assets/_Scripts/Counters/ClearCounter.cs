using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

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
            if(player.HasKitchenObject())
            {
                
            }
            else
            {
                //Player is not carrying something
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }

    }
}
