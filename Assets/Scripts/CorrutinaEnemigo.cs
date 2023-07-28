using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CorrutinaEnemigo : MonoBehaviour
{
    public float velocidadMovimiento = 3f; // Velocidad de movimiento del personaje
    private Vector3[] puntosMovimiento; // Puntos de movimiento 
    private int indicePuntoActual = 0; // Índice del punto de movimiento actual


    void Start()
    {
        puntosMovimiento = new Vector3[]
        {
        new Vector3(5, 9.536743e-07f, 6.651f), // Punto inicial
           new Vector3(8.61f, 9.536743e-07f, 6.651f),
              new Vector3(8.61f, 9.536743e-07f, 8.51f),
                 new Vector3(0.7f, 9.536743e-07f, 8.51f),
                    new Vector3(0.7f, 9.536743e-07f, 6.91f),
                    new Vector3( 3.13f, 9.536743e-07f, 6.91f),
                      new Vector3( 3.13f, 9.536743e-07f, 4.69f),
                      new Vector3(1.04f, 9.536743e-07f, 4.69f),
                      new Vector3(1.04f, 9.536743e-07f, 2.96f),
                      new Vector3( 5.13f, 9.536743e-07f, 2.96f),
                      new Vector3(5.13f, 9.536743e-07f, -5.862f),
                      new Vector3(-2.64f, 9.536743e-07f, -5.862f),
                      new Vector3(-2.66f, 9.536743e-07f, -5.862f),
                      new Vector3(-2.69f, 9.536743e-07f, -4.12f),
                      new Vector3(-0.41f, 9.536743e-07f, -4.12f),
                      new Vector3(-0.41f, 9.536743e-07f, -3.24f),

                     

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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            StartCoroutine(Reinicio());
        }

    }


    IEnumerator Reinicio()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Reto_1");
    }
}

