using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5, 
//respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
//a.Suma
//b.Producto

public class ejercicio2 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    void Start()
    {
        
        Debug.Log("la suma entre 4 y 5 es igual a " + (num1 + num2));
        Debug.Log("el producto entre 4 y 5 es igual a " + (num1 * num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
