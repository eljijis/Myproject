using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigocaida : MonoBehaviour
{
    public bool onGround;

void Start()
 {
    
 }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
                 GetComponent<Rigidbody>().useGravity= true;
        }
    }
    if (Input.GetKeyDown(KeyCode.X))
    {
         Vector3 fuerza = new Vector3(0,500,0);
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