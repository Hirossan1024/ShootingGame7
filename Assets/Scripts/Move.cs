using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float posA;
    float posB;
    // Start is called before the first frame update
    void Start()
    {
        posA = 10;
        posB = 13;
    }

    // Update is called once per frame
  
        void Update()
        {
            //...transform.position.zが変化するような操作処理...;
            Vector3 pos = transform.position;
            transform.position = new Vector3(Mathf.Clamp(pos.x, -20, 20), pos.y, Mathf.Clamp(pos.z, -posA, posB));

        }
    
}