using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelyesValaszok : MonoBehaviour
{
    public GameObject egy, ketto, harom;
    public Button helytelen1, helytelen2;
    public Button helyes1, helyes2, helyes3;

    void Start()
    {
        helytelen1.onClick.AddListener(Vege);
		helytelen2.onClick.AddListener(Vege);

        helyes1.onClick.AddListener(MasodikKerdes);
        helyes2.onClick.AddListener(HarmadikKerdes);
        helyes3.onClick.AddListener(Nyeres);
    }

    public void Vege(){
        SceneManager.LoadScene("4");
    }

    public void MasodikKerdes(){
        egy.SetActive(false);
        ketto.SetActive(true);
    }

    public void HarmadikKerdes(){
        ketto.SetActive(false);
        harom.SetActive(true);
    }

    public void Nyeres(){
        SceneManager.LoadScene("Nyertel");
    }
}
