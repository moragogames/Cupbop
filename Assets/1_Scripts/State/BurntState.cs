using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurntState : FryingState
{
    public BurntState()
    {
        foodStateType = FoodStateType.burnt;
    }

    public override void EnterState(FringDish f)
    {
        Debug.Log("요리가 탔다");
        f.foodRenderer.sprite = f.burntSprite;
    }

   
    public override void OnMouseDown(FringDish f)
    {
        Debug.Log("요리버리기");
        f.Remove();
    }


}
