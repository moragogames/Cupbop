using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupbop : MonoBehaviour
{

    [SerializeField] Food[] foodPrefabs;
    [SerializeField] bool draging = false;
    Vector3 pos;


    private void Awake()
    {
        pos = gameObject.transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D[] cols = Physics2D.OverlapPointAll(worldPos);

            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].CompareTag("Food"))
                {
                    AddCupbopFood(cols[i].GetComponent<Food>().foodName);
                    break;
                }
            }
        }
    }

    public void AddCupbopFood(string fName)
    {
        for (int i = 0; i < foodPrefabs.Length; i++)
        {
            if (foodPrefabs[i].name.Equals(fName))
            {
                Food food = Instantiate(foodPrefabs[i]);
                food.transform.position = transform.position;
                food.transform.SetParent(transform);
                break;
            }
        }
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] cols = Physics2D.OverlapPointAll(worldPos);

        for (int i = 0; i < cols.Length; i++)
        {
            if (cols[i].CompareTag("Cup"))
            {
                Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = vec;
            }
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

    }

    private void OnMouseUp()
    {
        transform.position = pos;
        Debug.Log("OnMouseUp");

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] cols = Physics2D.OverlapPointAll(worldPos);

        for (int i = 0; i < cols.Length; i++)
        {
            
            if (cols[i].CompareTag("Customer"))
            {
                Debug.Log("받으세요");
                Destroy(gameObject);
            }
        }
    }
}
