using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMgr : MonoBehaviour
{
    #region ΩÃ±€≈Ê
    private static FoodMgr instance;
    public static FoodMgr Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    [SerializeField] FoodData[] foodDatas;

    public FoodData GetFoodData(string name)
    {
        for (int i = 0; i < foodDatas.Length; i++)
        {
            if (foodDatas[i].name.Equals(name))
            {
                return foodDatas[i];
            }
        }
        return null;
    }



}
[System.Serializable]
public class FoodData
{

    public int count;
    public string name;
    public Sprite sprite;
}
