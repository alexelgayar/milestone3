using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionList : MonoBehaviour
{
    CelluloAgentRigidBody script;
    public GameObject questionPane;
    GameObject answeringCellulo;
    Question currQ;
    public Text qText;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text answer4;
    public Text answer5;
    public Text answer6;

    Question q1 = new Question();
    Question q2 = new Question();
    Question q3= new Question();
    List<Question> qList;


    // Start is called before the first frame update
    void Start()
    {
        qList = new List<Question>();
        q1.question = "What's my name?";
        q1.red = "Al";
        q1.blue = "Ale";
        q1.green = "Alex";
        q1.yellow = "Alexa";
        q1.magenta = "Alexan";
        q1.white = "Alexand";
        q1.correct = q1.green;
        qList.Add(q1);

        q2.question = "where do I live?";
        q2.red = "La";
        q2.blue = "Laus";
        q2.green = "Lausa";
        q2.yellow = "Lausan";
        q2.magenta = "Lausanne";
        q2.white = "Lausannnna";
        q2.correct = q2.magenta;
        qList.Add(q2);

        q3.question = "how old am I?";
        q3.red = "11";
        q3.blue = "12";
        q3.green = "13";
        q3.yellow = "15";
        q3.magenta = "19";
        q3.white = "20";
        q3.correct = q3.white;
        qList.Add(q3);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayQuestion(GameObject cellulo, GameObject obj)
    {
        script = cellulo.GetComponentInParent<CelluloAgentRigidBody>();
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.red, 0);
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.blue, 1);
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.green, 2);
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.yellow, 3);
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.magenta, 4);
        script.SetVisualEffect(VisualEffect.VisualEffectConstSingle, Color.white, 5);
        answeringCellulo = cellulo.transform.parent.gameObject;

        int i = Random.Range(0, qList.Count - 1);
        currQ = qList[i];
        qText.text = qList[i].question;
        answer1.text = qList[i].red;
        answer2.text = qList[i].blue;
        answer3.text = qList[i].green;
        answer4.text = qList[i].yellow;
        answer5.text = qList[i].magenta;
        answer6.text = qList[i].white;
        questionPane.SetActive(true);
        Time.timeScale = 0;

    }

    public void answerQuestion(GameObject cellulo, int answer)
    {
        if (questionPane.activeSelf)
        {
            if(answeringCellulo == cellulo)
            {
                Score score = cellulo.GetComponent<Score>();
                answeringCellulo = null;
                if(answer == 0)
                {
                    if (currQ.correct.Equals(currQ.red)){
                        score.score += 10;
                    }
                    else {
                        score.score -= 5;
                    }
                }
                else if(answer == 1)
                {
                    if (currQ.correct.Equals(currQ.blue))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }


                }
                else if (answer == 2)
                {
                    if (currQ.correct.Equals(currQ.green))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }
                }
                else if (answer == 3)
                {
                    if (currQ.correct.Equals(currQ.yellow))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }
                }
                else if (answer == 4)
                {
                    if (currQ.correct.Equals(currQ.magenta))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }
                }
                else if (answer == 5)
                {
                    if (currQ.correct.Equals(currQ.white))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }
                }
                GameObject main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
                QuestionObjects spawn = main.GetComponent<QuestionObjects>();
                print(score.score);
                questionPane.SetActive(false);
                spawn.SpawnLater();
                Time.timeScale = 1;



            }

        }

    }



}
