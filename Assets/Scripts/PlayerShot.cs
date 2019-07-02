using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // bullet prefab
    public GameObject PlayerBullet;

    // 弾丸発射点
    public Transform Muzzle;

    //発射間隔
    float count;

    //フレーム
    int frame;

    // 弾丸の速度
    public float speed = 1000;

    // Use this for initialization
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        frame = 0;
        count = 10;
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        // z キーが押された時
        if (Input.GetKey(KeyCode.Z) && frame % count == 0)
        {
            // 弾丸の複製
            GameObject PlayerBullets = Instantiate(PlayerBullet) as GameObject;

            Vector3 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            PlayerBullets.GetComponent<Rigidbody>().AddForce(force);

            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1);

            // 弾丸の位置を調整
            PlayerBullets.transform.position = Muzzle.position;

            Destroy(PlayerBullets, 5f);
        }
    }
}
