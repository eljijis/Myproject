using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNTOS : MonoBehaviour
{
   public int puntos; 
    void Start()
    {
        puntos = 0 ; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c){
        Debug.Log("Choque tipo trigger");
        puntos++;
    }
}
