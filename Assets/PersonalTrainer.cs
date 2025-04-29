using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string entrenamiento;
    public int horas;
    int precioCardio = 1000;
    int precioFuerza = 1500;
    int precioRecreativo = 2500;
    float precioTotal;
    float precioDescuento;
    // Start is called before the first frame update
    void Start()
    {
        if(horas > 6 || horas < 1) {
            Debug.Log("Error. Cantidad de horas no valida");
            return;
        }
        if(entrenamiento == "Cardio")
        {
            precioTotal = horas * precioCardio;
        } else if (entrenamiento == "Fuerza")
        {
            precioTotal = horas * precioFuerza;
        } else if (entrenamiento == "Recreativo")
        {
            precioTotal = horas * precioRecreativo;
        } else
        {
            Debug.Log("Error. Entrenamiento no valido");
            return;
        }

        Debug.Log("El entrenamiento elejido es: " + entrenamiento);
        Debug.Log("La cantidad de horas reservadas es: " + horas);
        Debug.Log("El precio es: " + precioTotal);
        if (horas == 6)
        {
            precioDescuento = precioTotal - precioTotal* 10 / 100;
            Debug.Log("El precio con descuento es: " + precioDescuento);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
