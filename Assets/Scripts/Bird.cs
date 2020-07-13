using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Android;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float Speed = 10.0f;
    public float MaxVelocity = 3.0f;
    public float MinVelocity = -3.0f;
    public static bool IsAlive = true;
    private int score = 0;
    public Text _text;
    public GameObject RestartButton;
    private AudioSource source;
    public GameObject GameOver;
    


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        IsAlive = true;
        
        //GetComponents<Audio>
        foreach(var component in GetComponents<AudioSource>())
        {
            Debug.Log(component.clip);
        }


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rigidbody2D.velocity);


        if (IsAlive)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    var newVelocity = rigidbody2D.velocity += new Vector2(0.0f, Speed);
                    newVelocity.y = Mathf.Clamp(newVelocity.y, MinVelocity, MaxVelocity);
                    rigidbody2D.velocity = newVelocity;
                    Debug.Log(rigidbody2D.velocity);
                    source.Play();
                }
            }

            if (Input.GetKeyDown(KeyCode.T))
            {

                var newVelocity = rigidbody2D.velocity += new Vector2(0.0f, Speed);
                newVelocity.y = Mathf.Clamp(newVelocity.y, MinVelocity, MaxVelocity);
                rigidbody2D.velocity = newVelocity;
                Debug.Log(rigidbody2D.velocity);
                source.Play();
            }



        }


        /*private void OnCollisionStay2D(Collision2D collision)
        {
            //on stay
            Debug.Log("On Stay" + collision.gameObject);
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            //exit
            Debug.Log("On Exit" + collision.gameObject);

        }*/

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //enter
        Debug.Log("On Enter" + collision.gameObject);
        IsAlive = false;
        GameOver.SetActive(true);
        RestartButton.SetActive(true);
        



    }
    private void OnTriggerExit2D(Collider2D other)
    {
        score++;
        Debug.Log("Score: " + score);
        _text.text = score.ToString();
    }
    public void OnRestartButtonClick()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("UI");
        //IsAlive = true;
    }
}
