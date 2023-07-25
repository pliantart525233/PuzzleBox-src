
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Show_Deaths : MonoBehaviour

{

    float TimesDied = 0;

    public Text TheText;

    // Start is called before the first frame update

    void Start()

    {

        // Make the amount of deaths you had appear at the end

        TimesDied = Character2DController.Deaths;

        TheText = GetComponent<Text>();

        TheText.text = TimesDied.ToString();
        
    }

    // Update is called once per frame

}
