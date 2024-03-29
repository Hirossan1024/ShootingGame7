﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    Slider slider;

    public const int maxHealth = 5;
    public int currentHealth = maxHealth;

    void Start()
    {
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.value = currentHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        //体力が0以下になったら
        if (currentHealth <= 0)
        {
            //HPを0で固定する
            currentHealth = 0;
            slider.value = 0;
            //ログを出す
            Debug.Log("Dead!");
            //体力が0になったプレイヤーが死ぬ
            Destroy(gameObject);
        }
        slider.value = currentHealth;
    }
}
