
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;  

public class Main_Menu : MonoBehaviour

{

    public void PlayGame ()

    {

       //SceneManager.LoadScene(1);

       SceneManager.LoadScene("Level 1");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame ()

    {

        Application.Quit();

    }

    public void Menu ()

    {

        SceneManager.LoadScene(0);

    }

    public void Restart ()

    {

        SceneManager.LoadScene(1);

    }


    // Start is called before the first frame update

    void Start()

    {


        
    }

    // Update is called once per frame

    void Update()

    {

        
        
    }

}
