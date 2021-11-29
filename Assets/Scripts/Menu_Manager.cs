using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HowToPlayPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        HowToPlayPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }
    public void HowToPlayButtonClicked()
    {
        MenuPanel.SetActive(false);
        HowToPlayPanel.SetActive(true);
    }
    public void Quit_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        HowToPlayPanel.SetActive(false);
    }
}
