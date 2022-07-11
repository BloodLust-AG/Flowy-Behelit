using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed=5f;
    public float drag=0.04f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.Lerp(transform.position,new Vector2(transform.position.x-drag,transform.position.y),speed);
    }
}
