using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CorrutinaEnemigo3 : MonoBehaviour
{
    public float velocidadMovimiento = 3f; // Velocidad de movimiento del personaje
    private Vector3[] puntosMovimiento; // Puntos de movimiento 
    private int indicePuntoActual = 0; // Índice del punto de movimiento actual


    void Start()
    {

        
        puntosMovimiento = new Vector3[]
        {
        new Vector3(-5.27101469f,0,6.63000011f), // Punto inicial
           new Vector3(-8.60000038f,0,6.63000011f),
              new Vector3(-8.60000038f,0,8.60000038f),
                 new Vector3(-0.720000029f,0,8.60000038f),
                    new Vector3(-0.720000029f,0,6.98000002f),
                    new Vector3(-3.1099999f,0,6.98000002f),
                      new Vector3(-3.1099999f,0,5.07000017f),
                      new Vector3(1.05999994f,0,5.07000017f),
                      new Vector3(1.05999994f,0,3.18000007f),
                      new Vector3(3.1099999f,0,3.18000007f),
                      new Vector3(3.1099999f,0,-2.41000009f),
                      new Vector3(3.25f,0,-0.519999981f),
                      new Vector3(5.17999983f,0,-0.519999981f),
                      new Vector3(5.17999983f,0,6.48999977f),
                      new Vector3(8.57999992f,0,6.48999977f),
                      new Vector3(8.57999992f,0,8.48999977f),



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

