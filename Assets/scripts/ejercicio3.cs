﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crear una variable pública que permita ingresar texto. 
//Permitir que al ejecutar el programa se muestre en la consola un mensaje de saludo que incluya el texto de la variable.
//Por ejemplo, si en la variable se ingresa el texto “Ana”, el mensaje en consola debe decir “Hola Ana”. 
public class ejercicio3 : MonoBehaviour
{
    public string nombre;
    void Start()
    {
        Debug.Log("Bienvenido a la guia de programación " + nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
