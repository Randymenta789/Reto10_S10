using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinaEnemigo2 : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento del personaje
    private Vector3[] puntosMovimiento; // Puntos de movimiento 
    private int indicePuntoActual = 0; // Índice del punto de movimiento actual


    void Start()
    {
        puntosMovimiento = new Vector3[]
        {
        new Vector3(-8.64000034f,0,-4.30177402f), // Punto inicial
           new Vector3(-8.64000034f, 9.536743e-07f, -8.47f),
              new Vector3(-1.11000001f,0,-8.47000027f),
                 new Vector3(-1.11000001f,0,-5.82000017f),
                    new Vector3(-5.28999996f,0,-5.82000017f),
                    new Vector3(-5.28999996f,0,-0.419999987f),
                      new Vector3(-3.0999999f,0,-0.419999987f),
                      new Vector3(-3.0999999f,0,1.38f),
                      new Vector3(3.01999998f,0,1.38f),
                      new Vector3(3.01999998f,0,3.02999997f),
                      new Vector3(1.04999995f,0,3.02999997f),
                      new Vector3(1.04999995f,0,5.05000019f),
                      new Vector3(-5.07999992f,0,5.05000019f),
                      new Vector3(-5.07999992f,0,3.00999999f),
                      new Vector3(-8.55000019f,0,3.00999999f),
                      new Vector3(-8.55000019f,0,4.90999985f),



        };
        StartCoroutine(MoverPersonaje());

    }

    IEnumerator MoverPersonaje()
    {
        while (indicePuntoActual < puntosMovimiento.Length)
        {

            Vector3 siguientePunto = puntosMovimiento[indicePuntoActual];


            while (transform.position != siguientePunto)
            {

                transform.position = Vector3.MoveTowards(transform.position, siguientePunto, velocidadMovimiento * Time.deltaTime);
                yield return null;

            }
            indicePuntoActual++;
        }
    }
}
