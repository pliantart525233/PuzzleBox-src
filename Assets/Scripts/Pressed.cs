
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Pressed : MonoBehaviour

{

    public static bool OnceOpen = false;

    public static bool Open = false;

    // Start is called before the first frame update

    void Start()

    {
        
    }

    // Update is called once per frame

    void Update()

    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    
    {

        if(other.gameObject.CompareTag("Player"))

        {

            Open = true;

        }

        if(other.gameObject.CompareTag("Puzzle Cube"))

        {

            Open = true;

        }

    }

    private void OnCollisionExit2D(Collision2D other) 

    {

        if(OnceOpen == true)

        {

            Open = true;

        }

        else

        {
            
            Open = false;

        }

    }

}
