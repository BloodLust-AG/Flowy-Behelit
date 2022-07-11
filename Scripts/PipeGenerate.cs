using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerate : MonoBehaviour
{
    public GameObject Pipe;
    private float timer =0f;
    public float max=1f;
    public float height=2f;
    public float destroy=3f;
    void Start()
    {
        
    }

    void Update()
    {
        if(timer >= max){
            GameObject pipes=Instantiate(Pipe);
            pipes.transform.position=transform.position + new Vector3(0,Random.Range(-height,height),0);
            Destroy(pipes,destroy);
            timer=0;
        }
        timer+=Time.deltaTime;
    }
}
