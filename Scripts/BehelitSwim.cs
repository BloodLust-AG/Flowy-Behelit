using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehelitSwim : MonoBehaviour{
    Rigidbody2D behelit;
    public float jump=6f;
    public float score=0;
    private bool dead=false;
    void Start(){
        behelit=transform.GetComponent<Rigidbody2D>();
    }
    void Update(){
        if(Input.GetKeyDown("space")&&!dead){
            behelit.velocity=new Vector2(0,jump);
        }
    }
    void OnCollision2D(Collision2D col){
        if(col.gameObject.tag=="PointTrigger"){
            score++;
        }
        if(col.gameObject.tag=="terminate"){
            dead=true;
            score=0;
        }
    }
}
