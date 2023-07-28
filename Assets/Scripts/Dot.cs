using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }

    }
}
