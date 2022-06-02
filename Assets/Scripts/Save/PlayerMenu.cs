using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    public Text levelText;
    public Text experienceText;
    public GameObject panel;
    public GameObject areYouSure;

    public void ResetGame()
    {
        areYouSure.SetActive(false);
        SaveManager.instance.ResetGame();
    }

    public void AreYouSure()
        => areYouSure.SetActive(true);
    
    
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = LevelSystem.instance.Level.ToString();
        experienceText.text = LevelSystem.instance.Experience.ToString();
    }
    
    public void BackToMenu()
    {
        panel.SetActive(false);
        areYouSure.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
           BackToMenu();
    }
}
