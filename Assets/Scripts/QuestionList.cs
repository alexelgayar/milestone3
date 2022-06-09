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

    float curTime;
    public static float maxTime;
    public Text secs;

    Question q1 = new Question();
    Question q2 = new Question();
    Question q3 = new Question();
    Question q4 = new Question();
    Question q5 = new Question();
    Question q6 = new Question();
    Question q7 = new Question();
    Question q8 = new Question();
    Question q9 = new Question();
    Question q10 = new Question();
    Question q11 = new Question();
    Question q12 = new Question();
    Question q13 = new Question();
    Question q14 = new Question();
    Question q15 = new Question();
    Question q16 = new Question();
    Question q17 = new Question();
    Question q18 = new Question();
    List<Question> qList;


    // Start is called before the first frame update
    void Start()
    {
        curTime = maxTime;
        qList = new List<Question>();

        q1.question = "What is the capital of Egypt";
        q1.red = "Alexandria";
        q1.blue = "Cairo";
        q1.green = "Rabat";
        q1.yellow = "Luxor";
        q1.magenta = "Aswan";
        q1.correct = q1.blue;
        qList.Add(q1);

        q2.question = "What is the world's largest coutry";
        q2.red = "Russia";
        q2.blue = "China";
        q2.green = "USA";
        q2.yellow = "Australia";
        q2.magenta = "India";
        q2.correct = q2.red;
        qList.Add(q2);

        q3.question = "What is the most visited city in the World";
        q3.red = "Paris";
        q3.blue = "New York";
        q3.green = "London";
        q3.yellow = "Singapore";
        q3.magenta = "Bangkok";
        q3.correct = q3.magenta;
        qList.Add(q3);

        q4.question = "What country is known to have the best quality tap water";
        q4.red = "New Zealand";
        q4.blue = "Canada";
        q4.green = "Iceland";
        q4.yellow = "Switzerland";
        q4.magenta = "Norway";
        q4.correct = q4.yellow;
        qList.Add(q4);

        q5.question = "Which country is home to the most volcanoes";
        q5.red = "Iceland";
        q5.blue = "Chile";
        q5.green = "Japan";
        q5.yellow = "Indonesia";
        q5.magenta = "United States";
        q5.correct = q5.magenta;
        qList.Add(q5);

        q6.question = "How many countries are there in Africa";
        q6.red = "43";
        q6.blue = "61";
        q6.green = "54";
        q6.yellow = "37";
        q6.magenta = "33";
        q6.correct = q6.green;
        qList.Add(q6);

        q7.question = "What is the closest planet to Earth";
        q7.red = "Mercury";
        q7.blue = "Venus";
        q7.green = "Mars";
        q7.yellow = "Jupiter";
        q7.magenta = "Saturn";
        q7.correct = q7.red;
        qList.Add(q7);

        q8.question = "What is the rarest blood type";
        q8.red = "AB positive";
        q8.blue = "AB negative";
        q8.green = "O positive";
        q8.yellow = "O negative";
        q8.magenta = "A positive";
        q8.correct = q8.blue;
        qList.Add(q8);

        q9.question = "How many elements are there in the periodic table";
        q9.red = "130";
        q9.blue = "100";
        q9.green = "118";
        q9.yellow = "123";
        q9.magenta = "105";
        q9.correct = q9.green;
        qList.Add(q9);

        q10.question = "Where can you find the smallest bone in the human body";
        q10.red = "foot";
        q10.blue = "hand";
        q10.green = "elbow";
        q10.yellow = "ear";
        q10.magenta = "hand";
        q10.correct = q10.yellow;
        qList.Add(q10);

        q11.question = "What is the hardest natural substance on Earth";
        q11.red = "zylon";
        q11.blue = "vibranium";
        q11.green = "topaz";
        q11.yellow = "quartz";
        q11.magenta = "diamond";
        q11.correct = q11.magenta;
        qList.Add(q11);

        q12.question = "What are the primary colors of light";
        q12.red = "green , blue, white";
        q12.blue = "red, blue, green";
        q12.green = "blue, green, yellow";
        q12.yellow = "red, green, yellow";
        q12.magenta = "red, blue, yellow";
        q12.correct = q12.blue;
        qList.Add(q12);

        q13.question = "When did WWI end";
        q13.red = "1918";
        q13.blue = "1924";
        q13.green = "1920";
        q13.yellow = "1912";
        q13.magenta = "1915";
        q13.correct = q13.red;
        qList.Add(q13);

        q14.question = "Who was NOT a greek god";
        q14.red = "Poseidon";
        q14.blue = "Horus";
        q14.green = "Ares";
        q14.yellow = "Hestia";
        q14.magenta = "Zeus";
        q14.correct = q14.blue;
        qList.Add(q14);

        q15.question = "Which Century did the French Revolution take place";
        q15.red = "15th";
        q15.blue = "16th";
        q15.green = "17th";
        q15.yellow = "18th";
        q15.magenta = "19th";
        q15.correct = q15.yellow;
        qList.Add(q15);

        q16.question = "The Anglo-Zanzibar War was the shortest war in history, how long did it last";
        q16.red = "1 hour";
        q16.blue = "3 hours";
        q16.green = "40 minutes";
        q16.yellow = "12 hours";
        q16.magenta = "15 minutes";
        q16.correct = q16.green;
        qList.Add(q16);

        q17.question = "Which is NOT one of the seven wonders of the world";
        q17.red = "Hanging gardens of Babylon";
        q17.blue = "Pyramids of Giza";
        q17.green = "Colossus of Rhodes";
        q17.yellow = "Statue of Zeus at Olympia";
        q17.magenta = "Leaning tower of Pisa";
        q17.correct = q17.magenta;
        qList.Add(q17);

        q18.question = "Which country first used paper money?";
        q18.red = "Greece";
        q18.blue = "Egypt";
        q18.green = "India";
        q18.yellow = "England";
        q18.magenta = "China";
        q18.correct = q18.magenta;
        qList.Add(q18);

    }

    // Update is called once per frame
    void Update()
    {
        if (questionPane.activeSelf)
        {
            if(curTime > 0)
            {
                curTime -= Time.deltaTime;
            }
            else
           
            {
               
                Score score = answeringCellulo.GetComponent<Score>();
                score.score -= 5;
                DogColour col = answeringCellulo.GetComponent<DogColour>();
                col.setColour();
                removePane();
            }
        }
        secs.text = (((int)curTime) % 60).ToString("00");



    }

    public void displayQuestion(GameObject cellulo, GameObject obj)
    {
        curTime = maxTime; 
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
        questionPane.SetActive(true);
        //Time.timeScale = 0;

    }

    public void answerQuestion(GameObject cellulo, int answer)
    {
        if (questionPane.activeSelf)
        {
            if (answeringCellulo == cellulo)
            {
                Score score = cellulo.GetComponent<Score>();
                answeringCellulo = null;
                if (answer == 0)
                {
                    if (currQ.correct.Equals(currQ.red))
                    {
                        score.score += 10;
                    }
                    else
                    {
                        score.score -= 5;
                    }
                }
                else if (answer == 1)
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

                removePane();
              
                
            }
        }
    }

    void removePane()
    {
        curTime = 20f;
        questionPane.SetActive(false);
        GameObject main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        QuestionObjects spawn = main.GetComponent<QuestionObjects>();
        MainScript mainscript = main.GetComponent<MainScript>();
        spawn.SpawnLater();

        //Time.timeScale = 1;
        mainscript.checkScore();

    }

}