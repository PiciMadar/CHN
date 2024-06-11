using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feladat4 : MonoBehaviour
{
    private bool _aktiv = true;
    public Text szoveg;
    public GameObject feladatdoboz;
    public GameObject kerdesIndito;

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


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Huto")){
            feladatdoboz.SetActive(false);
            kerdesIndito.SetActive(true);
        }
    }
}
