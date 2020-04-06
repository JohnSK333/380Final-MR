using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject shot = Instantiate(Resources.Load("Prefabs/PlayerShot", typeof(GameObject))) as GameObject;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += .2f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= .2f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newPosition.y += .2f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.y -= .2f;
        }
        transform.position = newPosition;
    }
}
