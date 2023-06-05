using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour
{
    public GameObject distance_obejct = null;
    public int distance_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text distance_text = distance_obejct.GetComponent<Text>();
        distance_text.text = "distance" + distance_num;
        distance_num += 1;

    }
}
