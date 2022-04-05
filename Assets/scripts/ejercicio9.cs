using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

public class ejercicio9 : MonoBehaviour
{
    public float capital1;
    public float capital2;
    public float capital3;
    public string nombre1;
    public string nombre2;
    public string nombre3;
    float capitaltotal;
    float porcentajeAportado1;
    float porcentajeAportado2;
    float porcentajeAportado3;



    void Start()
    {
        capitaltotal = capital1 + capital2 + capital3;
        porcentajeAportado1 = capital1 / capitaltotal * 100;
        Debug.Log("Nombre: " + nombre1 + "capital aportado: " + capital1 + "Porcentaje del capital: " + porcentajeAportado1 + "Monto total aportado: " + capitaltotal);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
