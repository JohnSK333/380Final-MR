using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawned;
    Vector2 screenBounds;
    float respawnTime = 3.0f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        StartCoroutine(spawnTimer());
    }
    private void spawn()
    {
        GameObject ingre = Instantiate(spawned) as GameObject;
        ingre.transform.position = new Vector2(Random.Range(-screenBounds.x+2, screenBounds.x-2), screenBounds.y * 2);
    }

    IEnumerator spawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawn();
        }
    }
  

}
