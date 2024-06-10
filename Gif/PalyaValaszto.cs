using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PalyaValaszto : MonoBehaviour
{
	
	public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
	
	
	void Start()
    {
        m_YourFirstButton.onClick.AddListener(PalyaBetoltes);
		m_YourSecondButton.onClick.AddListener(PalyaBetoltes);
		m_YourThirdButton.onClick.AddListener(Bezaras);
    }
	
    public static void PalyaBetoltes(){
		SceneManager.LoadScene("palya1");
	}
	
	public static void Bezaras(){
		Application.Quit();
	}
	
}
