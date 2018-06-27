using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GAMEpLAYcONTROLLER : MonoBehaviour {
    public GameObject LoadingPanel;
    public Slider Loadslider;
    public LapComplete winorloose;
    public GameObject PausePanel,ResultPanel;
    public GameObject LapPanel;
    public InputField Lap;
    public Text lapno, result;
    public int LapstoPlay=1;
    // Use this for initialization
    
    void Start () {
        LoadingPanel.SetActive(false);
        ResultPanel.SetActive(false);
        Time.timeScale = 0f;
        LapPanel.SetActive(true);
        PausePanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (winorloose.LapsDone>=LapstoPlay)
        { ResultPanel.SetActive(true);
            if (winorloose.opponentLaps >=winorloose.LapsDone)
            {
                result.text = "Sorry You Lost!";
            }
            else
            {
                result.text = "Great Driving! You won.";
            }
            StartCoroutine(WinorLose());
        }

    }
 IEnumerator WinorLose()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0f;
    }
   
    public void TakeLap()
    {
        lapno.text = Lap.text;
        LapstoPlay = int.Parse(lapno.text.ToString());
        LapPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        StartCoroutine(Load());
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void CArSelect()
    {
        SceneManager.LoadScene("TrackSelect");
    }
    public void RestArt()
    {
        SceneManager.LoadScene("GamePlay");
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

