using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private GameObject PlayerObject;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //シーン開始時にヒエラルキーから"Player"という名前のゲームオブジェクトを検索する
        PlayerObject = GameObject.Find("Player");
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);
                Invoke("Call", 0.9f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("NormalStage");
            }
        }

        if (SceneManager.GetActiveScene().name == "NormalStage")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("BossStage");
            }
            else if (PlayerObject == false)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        if (SceneManager.GetActiveScene().name == "BossStage")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Ending");
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        if (SceneManager.GetActiveScene().name == "Ending")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Title");
            }
        }

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Title");
            }
        }
    }

    void Call()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            SceneManager.LoadScene("NormalStage");
        }
    }
}
