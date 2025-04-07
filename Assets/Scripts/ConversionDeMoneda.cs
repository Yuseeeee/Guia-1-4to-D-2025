using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    //1.Declaracion de variables
    public float montoAConvertir;
    public string codigoMoneda;
    
    float montoConvertido;
    float montoMinimo = 1000;

    float cotizacionMoneda;
    float cotizacionDolar = 1297.21f;
    float cotizacionEuro = 1621.3f;
    float cotizacionReal = 183.0f;
    // Start is called before the first frame update
    void Start()
    {
        //2. ingreso y validacion de datos

        if (montoAConvertir < montoMinimo)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro; 
        }else if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;

        }
        else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal;

        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
                return;
        }
        //3. Procesamiento de datos
        montoConvertido = montoAConvertir / cotizacionMoneda;

        //4. Salida de datos
        Debug.Log("La conversón de $" + montoAConvertir + " es " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
