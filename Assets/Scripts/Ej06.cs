using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej06 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 en una variable llamada num1 y muestre un mensaje por pantalla indicando el  número es par o el número es impar. Deberá utilizar el operador “módulo” es el caracter  %.");
        if ((num1 %2) == 0)
        {
            Debug.Log("El numero es Par");
        }
        else
        {
            Debug.Log("El numero es Impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
