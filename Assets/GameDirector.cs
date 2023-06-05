using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    //GameObject moving;
    //public GameObject moving_object = null; // Textオブジェクト
    //public int moving_num = 0; // スコア変数





    // Start is called before the first frame update
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
        //this.moving = GameObject.Find("moving");

    }

    // Update is called once per frame
    void Update()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.00028f;
        // this.moving.GetComponent<Image>().fillAmount += Time.time;
        //Text moving = moving_object.GetComponent<Text>();
        //moving.text = "moving" + moving_num;
        //moving_num += 1;
    }
   
    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }


    
}
