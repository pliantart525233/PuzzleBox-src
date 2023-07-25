
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Color : MonoBehaviour

{

    // Variables

    private int max = 6;

    public static int now = 0;

    [Header("Cor")]

    [SerializeField] private Sprite red;

    [SerializeField] private Sprite green;

    [SerializeField] private Sprite yellow;

    [SerializeField] private Sprite blue;

    [SerializeField] private Sprite black;

    [SerializeField] private Sprite orange;

    [SerializeField] private Sprite white;

    public void Next()

    {

        now = now + 1;

    }

    public void back()

    {

        now = now - 1;

    }
    
    void Start()

    {


        
    }

    void Update()
    {

        if(now >= 7)

        {

            now = 0;
            
        }

        if(now <= -1)

        {

            now = 6;

        }

        if(now == 0)

        {

            this.gameObject.GetComponent<Image>().sprite = green;

        }

        if(now == 1)

        {

            this.gameObject.GetComponent<Image>().sprite = red;

        }

        if(now == 2)

        {

            this.gameObject.GetComponent<Image>().sprite = blue;

        }

        if(now == 3)

        {

            this.gameObject.GetComponent<Image>().sprite = yellow;

        }

        if(now == 4)

        {

            this.gameObject.GetComponent<Image>().sprite = orange;

        }

        if(now == 5)

        {

            this.gameObject.GetComponent<Image>().sprite = white;

        }

        if(now == 6)

        {

            this.gameObject.GetComponent<Image>().sprite = black;

        }
        
    }

}
