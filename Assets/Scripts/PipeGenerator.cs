using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PipePrefab;
    public int PipeCount = 10;
    private Transform _transform;
    public int Distance = 5;
    public float Max = 1.0f;
    public float Min = -1.0f;
    
    void Start()
    {
        for (int i = 0; i < PipeCount; i++)
        {
            var pipe = Instantiate(PipePrefab) as GameObject;
            var _transform = pipe.GetComponent<Transform>();
            var PipeMovement = pipe.GetComponent<PipeMovement>();
            PipeMovement.Init(PipeCount, Distance, Max,Min);
            _transform.position += new Vector3(Distance * i, Random.Range(Min,Max), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
