using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookedState : FryingState
{
    public float burntTimer;
    public CookedState()
    {
        foodStateType = FoodStateType.cooked;
    }

    public override void EnterState(FringDish f)
    {
        burntTimer = 0;
        Debug.Log("요리익었다");
        f.foodRenderer.sprite = f.coolkedSprite;
    }


    public override void UpdateState(FringDish f)
    {
        burntTimer += Time.deltaTime;
        if (burntTimer > f.burntSec)
        {
            f.NextState(f.burntState);
        }
    }
    public override void OnMouseDown(FringDish f)
    {
       
    }

}
