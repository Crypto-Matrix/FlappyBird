using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class PipeMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Camera camera;
    private int pipeCount,pipeDistance;
    public float Min;
    public float Max;
    public int factor = 5;


    
    // Start is called before the first frame update
    void Start()
    {
        //var pipeGeneratorGo = GameObject.Find("PipeGeneratorGO");
       // PipeGenerator = pipeGo
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.IsAlive)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            var pos = transform.position;
            pos.x += pipeCount * pipeDistance;
            pos.y = Random.Range(Min, Max);

            if (transform.position.x + factor < Camera.main.transform.position.x)
            {
                //transform.position += new Vector3(pipeCount * pipeDistance, 0, 0);
                pos = new Vector3(pos.x, pos.y, 0);
                transform.position = pos;
            }
        }
       
        //Camera.main
    }
    public void Init(int pipeCount, int pipeDistance, float Max , float Min)
    {
        this.pipeCount = pipeCount;
        this.pipeDistance = pipeDistance;
        this.Max = Max;
        this.Min = Min;
    }
}
