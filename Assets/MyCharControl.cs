using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharControl : MonoBehaviour
{
    [SerializeField] float speed;
    float xLimit = 8.5f;
    float yLimit = 4.5f;
    Animator anim;
    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }

    

    // Update is called once per frame
    void Update()
    {
        float spped = Time.time;

        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3( x * 0.14f,0);

        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0,y * 0.14f);
        if (y == 0)
        {
            anim.Play("player");
           
        }
        else if (y == 1)
        {
            anim.Play("PlayerL");
            
        }
        else if(y ==-1)
        {
            anim.Play("playerR");
            


        }

        Vector3 currentPos = transform.position;

        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, yLimit);

        transform.position = currentPos;

    }
    
}
