using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwner : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }
    }
}
