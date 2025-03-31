using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num1 : MonoBehaviour
{
    int num1 = 0;
    int resultado;
    int multiplicacion;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + 2;
        Debug.Log("La suma de " + num1 + " y " + "2" + " es: " + resultado);
        multiplicacion = resultado * resultado;
        Debug.Log("La multiplicacion de " + resultado + " y " + resultado + " es: " + multiplicacion);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
