using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FinishPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    private float time=0.0f;

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject sound;
    [SerializeField] private GameObject graphics;
    
    //[SerializeField] private AudioClip runButtonSound;
    [SerializeField] private AudioClip buttonSound;
    //[SerializeField] private AudioClip blockSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!timeText.IsActive())
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + Math.Round(time,2) + " s";
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void MainMenu()
    {
        
    }
    
    public void Settings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
        Debug.Log("setting is true");
    }

    public void SettingsBack()
    {
        menu.SetActive(true);
        settings.SetActive(false);
    }

    public void Sound()
    {
        settings.SetActive(false);
        sound.SetActive(true);
    }
    
    public void SoundBack()
    {
        settings.SetActive(true);
        sound.SetActive(false);
    }
    
    public void Graphics()
    {
        settings.SetActive(false);
        graphics.SetActive(true);
    }
    public void GraphicsBack()
    {
        settings.SetActive(true);
        graphics.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    public void ButtonClick()
    {
        audioSource.PlayOneShot(buttonSound);
    }
    
}
