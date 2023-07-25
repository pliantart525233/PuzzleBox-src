
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Switch_Gravity : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool OnTop;

    // Start is called before the first frame update

    void Start()

    {

        // Get Rigidbody

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame

    void Update()

    {

        // Invert Gravity

        if(Input.GetKeyDown("e"))
        {

            rb.gravityScale *= -1;

            Rotation();

        }
        
    }

    // Makes the object stay standing 

    void Rotation()

    {

        if(OnTop == false)

        {

            transform.eulerAngles = new Vector3(0, 0, 180f);

        }

        else

        {

            transform.eulerAngles = Vector3.zero;

        }

        OnTop = !OnTop;

    }

}
