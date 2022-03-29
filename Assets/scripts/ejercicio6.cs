using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    public int num1;
    void Start()
    {

        if ((num1 % 2) == 0)
        {
            Debug.Log(num1 + " es un número par");
        }
        else
        {
            Debug.Log(num1 + " es un número impar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
