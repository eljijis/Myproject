using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;

void Start()
 {
    
 }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
                 GetComponent<Rigidbody>().useGravity= true;
        }
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
         Vector3 fuerza = new Vector3(100,0,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.B))
    {
         Vector3 fuerza = new Vector3(-100,0,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.N))
    {
         Vector3 fuerza = new Vector3(100,200,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.M))
    {
         Vector3 fuerza = new Vector3(-200,400,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
    

}

private void OnCollisionEnter(Collision c){
    Debug.Log ("colision");
    onGround = true;
    
}

private void OnCollisionStay(Collision c){
    onGround = true;
    
}
private void OnCollisionExit(Collision c){
    
    onGround = false;
    Debug.Log ("libre");
    
}

}