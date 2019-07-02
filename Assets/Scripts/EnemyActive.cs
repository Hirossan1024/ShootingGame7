using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActive : MonoBehaviour
{
    public GameObject obj;
    float Count;
    public float ActiveTime;

    void Start()
    {
        Count = 0;
    }

    void Update()
    {
        if (ActiveTime <= Count)
        {
            obj.SetActive(true);
        }
        Count++;
    }
}
