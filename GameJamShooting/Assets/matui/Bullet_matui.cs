using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_matui : MonoBehaviour
{
    float Delete_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        Delete_time += Time.deltaTime;
        transform.Translate(0, 0.2f, 0);
        if (Delete_time > 3.0f)
        {
            Destroy(gameObject);
        }
    }
}
