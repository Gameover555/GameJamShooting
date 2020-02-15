using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove2P : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time) * 0.6f;
        this.transform.position = new Vector3(0, 1.5f + sin, 0);
    }
}
