
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class AutoDoor : MonoBehaviour

{

    //variables

    private int moveSpeed = 3;

    private bool onceOpen = false;

    private bool open = false;

    private bool go = false;

    private float up = 2f;

    private float down = -2f;

    private bool MoveUp = false;

    // Start is called before the first frame update

    void Start()

    {
        
    }

    // Update is called once per frame

    void Update()

    {

        onceOpen = Pressed.OnceOpen;

        open = Pressed.Open;

        if(onceOpen == true)
        
        {

            if(open == true)

            {

                go = true;

            }

        }

        else

        {

            if(open == true)

            {

                go = true;

            }

            else

            {

                go = false;

            }

        }

        if(go == true)

        {

            Destroy(gameObject);

            /*if (transform.position.y <= up)

                transform.position = new Vector2(transform.position.y + moveSpeed * Time.deltaTime, transform.position.x);*/

        }

        else
    
        {

            /*if(transform.position.y >= down)
            
            {

                transform.position = new Vector2(transform.position.y - moveSpeed * Time.deltaTime, transform.position.y);

            }*/

        }
        
    }

}
