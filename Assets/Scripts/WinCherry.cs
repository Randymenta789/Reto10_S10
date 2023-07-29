using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinCherry : MonoBehaviour
{
    public TextMeshProUGUI textoWin;
    public Move Score;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            textoWin.gameObject.SetActive(true);
            Score.textoScore1.gameObject.SetActive(false);
            Score.textoScore.gameObject.SetActive(false);
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menú");
    }

}
