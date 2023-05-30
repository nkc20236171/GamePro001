using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
   

   

    // Start is called before the first frame update
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.00028f;
    }
    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void moving()
    {

    }
}
