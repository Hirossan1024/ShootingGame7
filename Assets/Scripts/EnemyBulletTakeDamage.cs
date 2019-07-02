using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletTakeDamage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        //相手のオブジェクトのHP機能を読み込む
        var health = hit.GetComponent<PlayerHP>();
        if (health != null)
        {
            //当たったオブジェクトのHPを1つ減らす
            health.TakeDamage(1);
            //この弾は消滅する
            Destroy(gameObject);
        }

        //var health = hit.GetComponent<EnemyHP>();
        //if (health != null)
        //{
        //    //当たったオブジェクトのHPを1つ減らす
        //    health.TakeDamage(1);
        //    //この弾は消滅する
        //    Destroy(gameObject);
        //}
    }
}
