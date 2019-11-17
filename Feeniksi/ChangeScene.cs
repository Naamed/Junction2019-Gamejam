using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour {
    public string levelToLoad;
    private float timer = 10f;
    private Text timerSeconds;
    void Start ()
    {
        timerSeconds = GetComponent<Text>();
    }
    void Update()
    {
        timer -= timer.deltatime;
        timerSeconds.text - timer.ToString("f0");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}