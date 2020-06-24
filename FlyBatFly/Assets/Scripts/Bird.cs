using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;
    Rigidbody2D BirdRigid;

    public GameObject HighScoreText;

    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject RateAppButton;
    public GameObject RestartButton; // это для кнопки
    public GameObject Menu;
    public GameObject PauseButton;


    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BirdRigid.velocity = Vector2.up * force;
            FindObjectOfType<AudioManager>().Play("jump");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // проверяем столкновение
    {
        if (collision.collider.tag == "Enemy")          // если тэг объекта "Enemy"
        {
            Destroy(gameObject);                        // то птичка уничтожаеся(
            Time.timeScale = 0;
            RestartButton.SetActive(true);              // кнопка рестарта появляется
            RateAppButton.SetActive(true);
            NoButton.SetActive(true);
            YesButton.SetActive(true);
            HighScoreText.SetActive(true);
            Menu.SetActive(true);
            PauseButton.SetActive(false);
            FindObjectOfType<AudioManager>().Play("death");
        }
    }

}
