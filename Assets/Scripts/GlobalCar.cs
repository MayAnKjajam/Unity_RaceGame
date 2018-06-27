
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalCar : MonoBehaviour {
    public static int Cartype;
    public GameObject LoadingPanel,GameModePanel;
    public Slider Loadslider;
    public Button Red, Blue, Green;
	// Use this for initialization
    void Awake() {
        Time.timeScale = 1f;
    }
	void Start () {
        GameModePanel.SetActive(false);
        LoadingPanel.SetActive(false);
	}
	public void Track1()
    {
        SceneManager.LoadScene("GamePlay");
    }
	// Update is called once per frame
	void Update () {
		
	}
    public void RecCar()
    {
        Cartype = 1;
        Red.interactable = false;
        Blue.interactable = true;
        Green.interactable = true;
        //  TrackWindow.SetActive(true);
    }
    public void BlueCar()
    {
        Cartype = 2;
        Blue.interactable = false;
        Red.interactable = true;
        Green.interactable = true;
        //  TrackWindow.SetActive(true);
    }
    public void GreenCar()
    {
        Cartype = 3;
        Green.interactable = false;
        Red.interactable = true;
        Blue.interactable = true;
        //  TrackWindow.SetActive(true);
    }
    public void Carselect()
    {
        SceneManager.LoadScene("TrackSelect");
    }
    public void Play()
    {
        GameModePanel.SetActive(true);

    }
    public void Day()
    {
        StartCoroutine(DAY());
    }
    public void Night()
    {
        StartCoroutine(NIGHT());
    }

    public void Back()
    {
        StartCoroutine(LoadMain());
    }
    
    public void Settings()
    {
        SceneManager.LoadScene("SETTINGS");
    }
    public void ExitGame()
    {
        Application.Quit();

    }
   IEnumerator DAY()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("GamePlay");
        LoadingPanel.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            Loadslider.value = progress;
            yield return null;

        }

    }
    IEnumerator NIGHT()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("GamePlay2");
        LoadingPanel.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            Loadslider.value = progress;
            yield return null;

        }

    }
    IEnumerator LoadMain()
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
