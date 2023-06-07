using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingState : FryingState
{
    float cookingTimer;
    public CookingState()
    {
        foodStateType = FoodStateType.cooking;
    }

    public override void EnterState(FringDish f)
    {
        cookingTimer = 0;
        f.foodRenderer.sprite = f.coolkingSprite;

    }

    public override void UpdateState(FringDish f)
    {
        cookingTimer += Time.deltaTime;
        if (cookingTimer > f.cookingSec)
        {
            f.NextState(f.cookedState);
        }
    }
    



}
