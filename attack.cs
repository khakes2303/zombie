using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision arg)
    {
        if (arg.gameObject.tag == "enemy")
        {
            score = score + 1;
            if (score == 1)
            {
                Destroy(arg.gameObject);
                
            }
        }
    }
}
