using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        Move();
        //Restriction();
        //Clamp();
    }

    //プレイヤーの移動
    void Move()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.3f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.3f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.3f, 0, 0);
        }
    }

    //移動範囲の制限
    //void Restriction()
    //{
    //    Vector3 pos = transform.position;
    //    if (transform.position.z <= -15)
    //    {
    //        transform.position = new Vector3(pos.x, pos.y, -15);
    //    }
    //    if (transform.position.z >= 15)
    //    {
    //        transform.position = new Vector3(pos.x, pos.y, 15);
    //    }
    //    if (transform.position.x <= -5)
    //    {
    //        transform.position = new Vector3(-5, pos.y, pos.z);
    //    }
    //    if (transform.position.x >= 5)
    //    {
    //        transform.position = new Vector3(5, pos.y, pos.z);
    //    }

    //    if (transform.position.x >= 5 && transform.position.z <= -15)
    //    {
    //        transform.position = new Vector3(5, pos.y, -15);
    //    }
    //    if (transform.position.x >= 5 && transform.position.z >= 15)
    //    {
    //        transform.position = new Vector3(5, pos.y, 15);
    //    }
    //    if (transform.position.x <= -5 && transform.position.z <= -15)
    //    {
    //        transform.position = new Vector3(-5, pos.y, -15);
    //    }
    //    if (transform.position.x <= -5 && transform.position.z >= 15)
    //    {
    //        transform.position = new Vector3(-5, pos.y, 15);
    //    }
    //}

    private Vector3 player_pos;

    //void Clamp()
    //{
    //    player_pos = transform.position; //プレイヤーの位置を取得

    //    player_pos.x = Mathf.Clamp(player_pos.x, -5f, 5f); //x位置が常に範囲内か監視
    //    player_pos.z = Mathf.Clamp(player_pos.z, -15f, 10f);
    //    transform.position = new Vector3(player_pos.x, player_pos.z); //範囲内であれば常にその位置がそのまま入る
    //}
}
