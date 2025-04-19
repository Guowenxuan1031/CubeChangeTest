using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{
    public GameObject a;public GameObject b;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        a=GameObject.Find("CubeCorrect");
        b=GameObject.Find("CubeWrong");
        if(Input.GetKey(KeyCode.W))
        a.transform.Translate(new Vector3(0,0,1)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.S))
        a.transform.Translate(new Vector3(0,0,-1)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.A))
        a.transform.Translate(new Vector3(-1,0,0)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.D))
        a.transform.Translate(new Vector3(1,0,0)*Time.deltaTime*5f);
        if(Input.GetKey(KeyCode.W))
        b.transform.Translate(new Vector3(0,0,-1)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.S))
        b.transform.Translate(new Vector3(0,0,1)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.A))
        b.transform.Translate(new Vector3(1,0,0)*Time.deltaTime*5f);
        else if(Input.GetKey(KeyCode.D))
        b.transform.Translate(new Vector3(-1,0,0)*Time.deltaTime*5f);
    }
}
