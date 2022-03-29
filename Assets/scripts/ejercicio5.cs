using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;
    void Start()
    {
        if (num2 == 0)
        {
            Debug.Log("dividir por 0 es como ganarle a Magnus Carlsen en ajedrez, imposible");
        }
        else
        {
            Debug.Log("el resultado de la divición entre " + num1 + " y " + num2 + " da como resultado " + (num1 / num2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
