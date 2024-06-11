using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Feladat2 : MonoBehaviour
{

    private int krumplikSzama = 70;
    private bool _aktiv = true;
    //public Text szoveg;
    public GameObject feladatdoboz;
    public GameObject krumplik;

    private bool mezonVan = false;

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

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mezonVan)
            {
                krumplik.gameObject.SetActive(false);
                feladatdoboz.SetActive(false);
                StartCoroutine(ExampleCoroutine());
            }
            
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
		SceneManager.LoadScene("feketeseg");
    }

    IEnumerator KrumpliVege()
    {
        yield return new WaitForSeconds(1);
		SceneManager.LoadScene("feketesegKrumplihoz");
    }

    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Mezok"))
        {
            mezonVan = true;
        }

        if (other.gameObject.CompareTag("KinottKrumplik"))
        {
            Destroy(other.gameObject);
            StartCoroutine(KrumpliVege());
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Mezok"))
        {
            mezonVan = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mezok"))
        {
            mezonVan = true;
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mezok"))
        {
            mezonVan = false;
        }
    }
}
