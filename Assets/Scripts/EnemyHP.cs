using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public const int maxHealth = 5;
    public int currentHealth = maxHealth;
    private int scoreValue = 100;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        //体力が0以下になったら
        if(currentHealth <= 0)
        {
            //スコアを加算する
            ScoreManager.score += scoreValue;
            //HPを0で固定する
            currentHealth = 0;
            //ログを出す
            Debug.Log("Dead!");
            //体力が0になったエネミーが死ぬ
            Destroy(gameObject);
        }
    }
}
