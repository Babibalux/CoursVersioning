using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    int speed = 5;

    float lifeTime = 0.8f;
    float reproduction = 0.2f;
    public GameObject walker;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += (Vector3)chooseDirection() * speed * Time.deltaTime;
    }

    Vector2 chooseDirection()
    {
        float number = Random.Range(0, 100);
        Vector2 dir = Vector2.up;
        for (int i = 0; i < 4; i++)
        {
            if (number < i * 25 && number > (i + 1) * 25)
            {
                dir = new Vector2(Mathf.Cos(i * (Mathf.PI / 2)), Mathf.Sin(i * (Mathf.PI / 2)));
            }
            
        }
        return dir;
    }
}
