using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetingsMenu : MonoBehaviour {
    public GameObject LoadingPanel;
    public Slider Loadslider;
    public AudioMixer audiomixer;
    public Slider slider;
    public int quality;
    public float volume=0;
    public Dropdown Qualitydrop;
    public void Start()
    {
        LoadingPanel.SetActive(false);
        slider.value= PlayerPrefs.GetFloat("Volume");
        //  audiomixer.SetFloat("Volume", volume);
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
        Qualitydrop.value= PlayerPrefs.GetInt("Quality");
    }
    public void SetVolume(float Volume)
    {
       
        audiomixer.SetFloat("Volume", Volume);
        volume = slider.value;
        PlayerPrefs.SetFloat("Volume", volume);
    }
    public void SetQuality(int QualityIndex)
    {
        quality = QualityIndex;
        QualitySettings.SetQualityLevel(QualityIndex);
        quality = QualityIndex;
    }
    public void Back()
    {
        StartCoroutine(Load());
    }
    public void Apply( )
    {
        PlayerPrefs.SetInt("Quality",quality);

    }
    IEnumerator Load()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainMenu");
        LoadingPanel.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            Loadslider.value = progress;
            yield return null;

        }

    }
}
