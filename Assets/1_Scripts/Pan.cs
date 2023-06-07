using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public int Idx;

    public bool isUsing;

    public void Init(int _idx)
    {
        Idx = _idx;
    }
}
