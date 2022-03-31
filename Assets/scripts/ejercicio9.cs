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
    float capitaltotal;



    void Start()
    {
        capitaltotal = capital1 + capital2 + capital3;
        Debug.Log("El porcentaje de capital aportado de la primera persona es " + capital1 + " de " + capitaltotal);
        Debug.Log("El porcentaje de capital aportado de la segunda persona es " + capital2 + " de " + capitaltotal);
        Debug.Log("El porcentaje de capital aportado de la tercera persona es " + capital3 + " de " + capitaltotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
