using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Feladat : MonoBehaviour
{
    private bool _aktiv = true;
    public Text szoveg;
    public GameObject feladatdoboz;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_aktiv)
            {
                feladatdoboz.SetActive(false);
                _aktiv = false;
                return;
            }
            else
            {
                feladatdoboz.SetActive(true);
                _aktiv = true;
                return;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Macska"))
        {
            _aktiv = true;
            feladatdoboz.SetActive(true);
            szoveg.text = "Vidd el a macskát a nénihez!";
        }

        if (collision.gameObject.CompareTag("Neni"))
        {
            SceneManager.LoadScene("1bol2re");
        }
    }
}
