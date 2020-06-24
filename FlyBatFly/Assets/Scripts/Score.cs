using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;                                       // не забудь меня подключить, ты ж с текстом работаешь!

public class Score : MonoBehaviour
{
    public Text modificatortext;
    public int score;                                       // переменная для очков                                       
    public Text scoreText;                                  // переменная для текста
    public Text highScore;
    private static int modificator;


    void Start()
    {

        score = 0;                                          // при старте кол-во очков будет равнять 0 
        modificator = PlayerPrefs.GetInt("mod", 1);                                               // modificator = 1;

    }


    void Update()
    {
        scoreText.text = score.ToString();                  // это связь очков и текста
        modificatortext.text = modificator.ToString();
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void MultiplyX2()
    {
        modificator = 2;
        PlayerPrefs.SetInt("mod", modificator);
    }

    public void MultiplyX5()
    {
        modificator = 5;
        PlayerPrefs.SetInt("mod", modificator);
    }


    private void OnTriggerEnter2D(Collider2D collision)     // метод для прохода через объект
    {
        if (collision.tag == "Score")                       // если птичка проходит через объект с тэгом "Score"
        {
            score++;
            score = score * modificator;

            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
           

        }

    }


    public void Reset()
    {
        PlayerPrefs.DeleteKey("mod");
    }

}