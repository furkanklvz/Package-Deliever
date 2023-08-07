using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMovement : MonoBehaviour


{
    bool up = true;
    void Start(){
        StartCoroutine(anim());
    }
    void Update()
    {
        if(up == true){
            transform.Translate(0,5*Time.deltaTime,0);
        }else{
            transform.Translate(0,-5*Time.deltaTime,0);
        }

    }
    IEnumerator anim(){
        while(true){
            yield return new WaitForSeconds(0.3f);
            up = !up;
        }
    }
}
