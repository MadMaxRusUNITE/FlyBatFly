using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // не забудь меня подключить, ты ж со сценами работаешь

public class Scene : MonoBehaviour
{
    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезагрузка сцены (но это я чет запарился)
        FindObjectOfType<AudioManager>().Play("jump");
    }

    public void NextLevel(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
        FindObjectOfType<AudioManager>().Play("jump");
    }

}
