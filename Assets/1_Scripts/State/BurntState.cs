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
        Debug.Log("�丮�� ����");
        f.foodRenderer.sprite = f.burntSprite;
    }

   
    public override void OnMouseDown(FringDish f)
    {
        Debug.Log("�丮������");
        f.Remove();
    }


}
