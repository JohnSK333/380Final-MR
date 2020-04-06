using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOneController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 originalPosition;
    float speed = 2f;
    bool goingRight = true;
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float distanceMoved = transform.position.x - originalPosition.x;
        Vector2 newPosition = transform.position;
        //Debug.unityLogger.Log(distanceMoved);
        if (goingRight)
        {
            newPosition.x += Time.deltaTime * speed;
        }
        else
        {
            newPosition.x -= Time.deltaTime * speed;
        }
        if (distanceMoved > 3.0f)
        {
            goingRight = false;
        }
        if (distanceMoved < -3.0f)
        {
            goingRight = true;
        }

        transform.position = newPosition;
    }


}
