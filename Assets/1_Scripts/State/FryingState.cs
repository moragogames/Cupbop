using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FryingState
{
    public FoodStateType foodStateType;

    //�������Խ� ȣ��
    public abstract void EnterState(FringDish f);

    public virtual void UpdateState(FringDish f)
    {

    }
    public virtual void OnMouseDown(FringDish f)
    {

    }

    public virtual void OnMouseUp(FringDish f)
    {

    }
    public virtual void OnMouseDrag(FringDish f)
    {

    }

}
