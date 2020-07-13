using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject sphereRef;
    private Transform _transform;
    private Renderer _renderer;
    public Material material;
    public GameObject PlayerPrefab;

    //[HideInInspector]
    public float speed = 10f;
    private Color defaultColor;
    private Material newMaterial;
    
    private void Awake()
    {
        
        _transform = GetComponent<Transform>();
        _renderer = sphereRef.GetComponent<Renderer>();
        defaultColor = _renderer.material.color;

        var newGameObject = Instantiate(PlayerPrefab) as GameObject;

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log("Start is Called");
    }

    // Update is called once per frame
    void Update()
    {

        // press any key -- GetkeyDown
        // hold any key -- Getkey
        // release any key -- Getkeyup
       if(Input.GetKey(KeyCode.D)){
        //    Debug.Log("D is pressed");
           _transform.position += Vector3.right* Time.deltaTime *speed;
           
       }
       if(Input.GetKey(KeyCode.A)){
           _transform.position += Vector3.left*Time.deltaTime * speed ;
       }
       if(Input.GetKey(KeyCode.W)){
           _transform.position += Vector3.forward*Time.deltaTime * speed ;
       }
       if(Input.GetKey(KeyCode.S)){
           _transform.position += Vector3.back*Time.deltaTime * speed ;
       }

       if(Input.GetKeyDown(KeyCode.Space)){
           sphereRef.SetActive(false);
       }
       if(Input.GetKeyDown(KeyCode.P)){
           sphereRef.SetActive(true);
       }
        if (Input.GetKey(KeyCode.V))
        {
            _renderer.material.SetColor("_Color", Color.red);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            _renderer.material.color = defaultColor;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            _renderer.material = newMaterial;
        }

        //    if(Input.GetKeyDown(KeyCode.W)){
        //        Debug.Log("W is pressed");
        //    }
    }
}
