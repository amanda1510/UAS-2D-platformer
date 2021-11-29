using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject PanelMenang;
    public GameObject PanelKalah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonRestartClicked()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }
    public void ButtonMainMenuClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
