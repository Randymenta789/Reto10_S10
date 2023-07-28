using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public GameObject muerteParticle;
    public TextMeshProUGUI textoGameOver;
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoScore1;
    ManagerTexto gameOver;
    public float speed = 5f;
    public float rotationSpeed = 20f;
    
     void Start()
    {
      
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();
        transform.position = transform.position + movement * speed * Time.deltaTime;

        if (movement != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed * Time.deltaTime);
    }

   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Enemigo"))
        {
            textoScore.gameObject.SetActive(false);
            textoScore1.gameObject.SetActive(false);
            textoGameOver.gameObject.SetActive(true);
            Destroy(gameObject);
            GameObject explosion = Instantiate(muerteParticle, transform.position, transform.rotation);
            Destroy(explosion, 3);
           
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.tag == ("Dot"))
            {

                Destroy(gameObject);
            }

       
    }
}
