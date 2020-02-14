using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_matui : MonoBehaviour
{

    float Delete_time;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
        Delete_time += time;

        if (Delete_time > 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
