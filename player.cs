using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    float v;
    float speed = 5f;
    Transform tr;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        rb.velocity = transform.forward * v * 5f;
        if (v != 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("attack");
        }

    }
    public void rotatePlayer(float arg) 
    {
        tr.rotation = Quaternion.Euler(0, arg, 0);
    }
}
