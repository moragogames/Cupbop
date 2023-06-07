using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupContainer : MonoBehaviour
{

    [SerializeField] GameObject cupContainer;
    [SerializeField] Transform cupPos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D[] cols = Physics2D.OverlapPointAll(worldPos);

            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].CompareTag("CupContainer"))
                {
                    Debug.Log("ÄÅ¹ä»ý¼º");
                    Instantiate(cupContainer, cupPos);
                    
                }
            }
        }
    }
}
