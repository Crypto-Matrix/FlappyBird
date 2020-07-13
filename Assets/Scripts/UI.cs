using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            source.Play();
        }
    }
    //callback for button cclick
    public void OnStartButtonClick()
    {
        Debug.Log("Hey button Click");
        
        SceneManager.LoadScene("Game");
        
    }

    public void OnNameChange(string name) {
        Debug.Log(name);
    }
    public void OnDropDown(int value) { 
        if (value == 0)
        {
            Debug.Log("Option 0");
        }
        else if (value == 1)
        {
            Debug.Log("Option 1");
        }
        else if (value == 2)
        {
            Debug.Log("Option 2");
        }

    }
}
