using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    float timer = 0;
    //la variable es publica para poder acceder desde fuera al gameObject que hace referencia
    public GameObject coinPrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f) {
            timer = 0;
            float x = Random.Range(-5f, 5f);
            Vector3 position = new Vector3(x, 0 ,0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
    }
}
