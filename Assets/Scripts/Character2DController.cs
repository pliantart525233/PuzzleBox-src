
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class Character2DController : MonoBehaviour

{

    // Variables

    public static float Deaths = 0;

    [Header("Movimentação")]

    [SerializeField] private float JumpForce = 1;

    [SerializeField] private float MovementSpeed = 1;

    private Rigidbody2D _rigidbody; 

    private int coins = 0;

    [Header("Moedas")]

    [SerializeField] private int MaxCoins = 1000;

    [Header("Cor")]

    [SerializeField] private int SpriteColor = 0;

    [SerializeField] private Sprite red;

    [SerializeField] private Sprite green;

    [SerializeField] private Sprite yellow;

    [SerializeField] private Sprite blue;

    [SerializeField] private Sprite black;

    [SerializeField] private Sprite orange;

    [SerializeField] private Sprite white;

    private bool IsTheReal = false;

    // Start is called before the first frame update

    void Start()

    {

        // Make the character's color equal to the color chosen in the main menu

        SpriteColor = Color.now;

        // Get the Rigidbody of the player 

        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D other) 

    {

        // Check if it collided with a coin

        if(other.gameObject.CompareTag("Coins"))

        {

            // Increase coin collected amount + destroy the coin

            Destroy(other.gameObject);

            coins = coins + 1;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    
    {

        // Check if it collided with lava

        if(other.gameObject.CompareTag("Lava"))

        {

            // Add death count and restart level

            Deaths = Deaths + 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        }

        if(other.gameObject.CompareTag("Player"))

        {

            // Idk

            if(IsTheReal)
            {

                Deaths = Deaths + 1;

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

            }

        }

    }

    // Update is called once per frame

    void Update()

    {

        // Change Sprite color

        if(SpriteColor == 0)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = green;

        }

        if(SpriteColor == 1)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = red;

        }

        if(SpriteColor == 2)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = blue;

        }

        if(SpriteColor == 3)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = yellow;

        }

        if(SpriteColor == 4)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = orange;

        }

        if(SpriteColor == 5)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = white;

        }

        if(SpriteColor == 6)

        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = black;

        }

        // Move in the X-axis

        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0,0) * Time.deltaTime * MovementSpeed;

        // Jump

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)

        {

            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }

        // Pass level because all coins were collected

        if(coins == MaxCoins)

        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        
    }

}
