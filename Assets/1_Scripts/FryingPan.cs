using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPan : MonoBehaviour
{
    [SerializeField] Pan[] pans;
    [SerializeField] FringDish[] fryingPrefabs;


    private void Start()
    {
        pans = GetComponentsInChildren<Pan>();
        for (int i = 0; i < pans.Length; i++)
        {
            pans[i].Init(i);
        }
    }
    private void Update()
    {
        // 클릭한곳에 좌표
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D[] cols = Physics2D.OverlapPointAll(worldPos);

            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].CompareTag("FriedFood"))
                {
                    AddFood(cols[i].GetComponent<FriedFood>().foodName);
                    break; // 이유
                }

            }
        }
    }
   
    
    public void AddFood(string fName)
    {
        Pan emptyPan = GetEmptyPan();
        if (emptyPan == null)
        {
            return;
        }

        FringDish food = GetFoodObj(fName);
        food.FoodSpawn(emptyPan);
    }

    FringDish GetFoodObj(string fName)
    {
        for (int i = 0; i < fryingPrefabs.Length; i++)
        {
            if (fryingPrefabs[i].foodName.Equals(fName))
            {
                return Instantiate(fryingPrefabs[i]);
            }
        }
        return null;
    }

    Pan GetEmptyPan()
    {
        for (int i = 0; i < pans.Length; i++)
        {
            if (pans[i].isUsing)
            {
                continue;
            }

            return pans[i];
        }

        return null;
    }

}
