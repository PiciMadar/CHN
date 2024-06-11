using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Feladat3 : MonoBehaviour
{
    private bool _aktiv = true;
    public Text szoveg;
    public GameObject feladatdoboz;

    public int faMennyiseg;
    public Text faMenny;

    public SpriteRenderer spriteRenderer;
    public Sprite ujSprite;

    public GameObject viz;

    public Animator animator;

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
        if(other.gameObject.CompareTag("Anyagok")){
            Destroy(other.gameObject);
            faMennyiseg++;
            faMenny.text = $"{faMennyiseg}/5";

            if(faMennyiseg == 5){
                
                viz.SetActive(false);
                spriteRenderer.sprite = ujSprite;
                transform.position = new Vector3(10.2f,0f,-10.37f);

            }
        }

        if(other.gameObject.CompareTag("tuloldal")){
            SceneManager.LoadScene("3bol4re");
        }
    }



    
}
