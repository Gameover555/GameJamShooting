using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject BombBullet;
    bool bulletFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletFlag)
        {
            for (int i = 0; i < 50; i++)
            {

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "BombBullet")
        {
            Destroy(gameObject);
            bulletFlag = true;
        }
    }
}
