using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bossblood : MonoBehaviour
{
    public Image bar;
    public GameObject image;
    public float health, maxhealth = 30;

    public void Update()
    {
        BarFiller();
    }

    private void BarFiller()
    {
        bar.fillAmount = health / maxhealth;
    }

    public bool JudgeBlood()
    {
        if(health <= 0)
        {
            return true;
        }
        else
            return false;
    }
}
