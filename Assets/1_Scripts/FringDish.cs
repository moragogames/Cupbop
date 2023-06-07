using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FringDish : MonoBehaviour
{
    FryingState curFryingState;

    public Pan curPan;

    public float cookingSec = 4f;
    public float burntSec = 10f;

    public CookingState cookingState;
    public CookedState cookedState;
    public BurntState burntState;

    public string foodName;
    public SpriteRenderer foodRenderer;

    [SerializeField] public Sprite coolkingSprite;
    [SerializeField] public Sprite coolkedSprite;
    [SerializeField] public Sprite burntSprite;


    private void Awake()
    {
        cookingState = new CookingState();
        cookedState = new CookedState();
        burntState = new BurntState();
        foodRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    public void FoodSpawn(Pan pan)
    {

        curPan = pan;
        curPan.isUsing = true;
        gameObject.SetActive(true);


        transform.position = curPan.transform.position;
        transform.SetParent(curPan.transform);
        NextState(cookingState);
    }

    public FoodStateType curFoodStateType;

    public void NextState(FryingState fStae)
    {
        curFryingState = fStae;
        curFoodStateType = fStae.foodStateType;


        curFryingState.EnterState(this);

    }

    public void OnMouseDown()
    {
        curFryingState.OnMouseDown(this);
    }
    private void Update()
    {
        curFryingState?.UpdateState(this);
    }


    public void Remove()
    {
        gameObject.SetActive(false);
    }


}


public enum FoodStateType
{
    cooking,
    cooked,
    burnt
}

