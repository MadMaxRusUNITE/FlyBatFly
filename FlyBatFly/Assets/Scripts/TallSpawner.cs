using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallSpawner : MonoBehaviour
{
    public GameObject Tall;        // переменная для префабов 

    void Start()
    {
        StartCoroutine(Spawner());  // включаем корутину "Spawner" 
    }

    IEnumerator Spawner()           // собстна сама корутина
    {
        while (true)                // бесконечный цикл While - работает
        {
            yield return new WaitForSeconds(1);     // ждем 2 секунды
            float rand = Random.Range(-3f, 2f);     // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newTall = Instantiate(Tall, new Vector3(7, rand, 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newTall, 13);  // удаление нового gameObject'a через 10 секунд (если б удаляли Pipes - то ничего б не заработало)
        }
    }
}
