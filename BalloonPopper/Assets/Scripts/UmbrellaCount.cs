using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UmbrellaCount : MonoBehaviour
{

    public Store store;
	
    Text umbrellas;
	
	
	
    void Start ()
    {
        umbrellas = GetComponent<Text>();
    }
	
    void Update ()
    {
        umbrellas.text = store.Purchased.Count + "x";
    }
    
    
}
