using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public Slider timerSlider;
    float maxTime;
    float curTime;
    public Text winnerText;
    public Text text2win;
    public GameObject endscene;
    public GameObject dog1;
    public GameObject dog2;
    public GameObject backBut;
    public Text mins;
    public Text secs;
    // Start is called before the first frame update
    void Start()
    {
        curTime = 0f;
        maxTime = TimeHandler.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        
            curTime += Time.deltaTime;
            timerSlider.value = curTime / maxTime;
            secs.text = (((int)curTime) % 60).ToString("00");
            mins.text = (((int)curTime) / 60).ToString("00") + ":";
            if (timerSlider.value == 1.0f) {
                EndGame();
            }
        

    }


    void EndGame()
    {
        backBut.SetActive(false);
        endscene.SetActive(true);

        Score s1 = dog1.GetComponent<Score>();
        Score s2 = dog2.GetComponent<Score>();

        int p1Score = s1.score;
        int p2Score = s2.score;

        if(p1Score > p2Score)
        {
            text2win.text = "THE WINNER IS:";
            winnerText.color = Color.red;
            winnerText.text = "TEAM RED";

        }
        else if(p1Score == p2Score)
        {
            text2win.text = "IT'S A TIE!";
            winnerText.text = "";
        }
        else {

            text2win.text = "THE WINNER IS:";
            winnerText.text = "TEAM BLUE";
            winnerText.color = Color.blue;

        }

        Time.timeScale = 0;

      

        

    }

    public void Pause(){
        Time.timeScale = 0;

    }

    public void Resume(){
        Time.timeScale = 1;

    }
}
