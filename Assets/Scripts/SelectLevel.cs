
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;  

public class SelectLevel : MonoBehaviour

{

    int Level = 0;

    public Text TheText;

    // Start is called before the first frame update

    void Start()

    {

        //TheText = GetComponent<Text>();

        TheText.text = Level.ToString();

        //Level = TheText;
        
    }

    // Choose level

    // 1 - 5

    public void one ()

    {

        //SceneManager.LoadScene(1);

        //SceneManager.LoadScene(Level);

    }

    public void two ()

    {

        SceneManager.LoadScene(2);

    }

    public void three ()

    {

        SceneManager.LoadScene(3);

    }

    public void four ()

    {

        SceneManager.LoadScene(4);

    }

    public void five ()

    {

        SceneManager.LoadScene(5);

    }

    // 6 - 10

    public void six ()

    {

        SceneManager.LoadScene(6);

    }

    public void seven ()

    {

        SceneManager.LoadScene(7);

    }

    public void eight ()

    {

        SceneManager.LoadScene(8);

    }

    public void nine ()

    {

        SceneManager.LoadScene(9);

    }

    public void ten ()

    {

        SceneManager.LoadScene(10);

    }

    // 11 - 15

    public void eleven ()

    {

        SceneManager.LoadScene(11);

    }

    public void twelve ()

    {

        SceneManager.LoadScene(12);

    }

    public void thirteen ()

    {

        SceneManager.LoadScene(13);

    }

    public void fourteen ()

    {

        SceneManager.LoadScene(14);

    }

    public void fifteen ()

    {

        SceneManager.LoadScene(15);

    }

    // 16 - 20

    public void sixteen ()

    {

        SceneManager.LoadScene(16);

    }

    public void seventeen ()

    {

        SceneManager.LoadScene(17);

    }

    public void eighteen ()

    {

        SceneManager.LoadScene(18);

    }

    public void nineteen ()

    {

        SceneManager.LoadScene(19);

    }

    public void twenty ()

    {

        SceneManager.LoadScene(20);

    }

    // 21 - 25

    public void twentyOne ()

    {

        SceneManager.LoadScene(21);

    }

    public void twentyTwo ()

    {

        SceneManager.LoadScene(22);

    }

    public void twentyThree ()

    {

        SceneManager.LoadScene(23);

    }

    public void twentyFour ()

    {

        SceneManager.LoadScene(24);

    }

    public void twentyFive ()

    {

        SceneManager.LoadScene(25);

    }

    // 26 - 30

    public void twentySix ()

    {

        SceneManager.LoadScene(26);

    }

    public void twentySeven ()

    {

        SceneManager.LoadScene(27);

    }

    public void twentyEight ()

    {

        SceneManager.LoadScene(28);

    }

    public void twentyNine ()

    {

        SceneManager.LoadScene(29);

    }

    public void thirty ()

    {

        SceneManager.LoadScene(30);

    }

    // 31 - 36

    public void thirtyOne ()

    {

        SceneManager.LoadScene(31);

    }

}
