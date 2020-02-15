using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerater : MonoBehaviour
{
    public GameObject bomb1;
    float span = 5.0f;
    float delta = 0;
    public int numberOfBombs;
    [SerializeField] int maxNumOfBombs = 100;

    void Start()
    {
        numberOfBombs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-8.0f, 9.0f);
        float y = Random.Range(-4.0f, 5.0f);

        this.delta += Time.deltaTime;
        if (numberOfBombs >= maxNumOfBombs)
        {
            return;
        }
        if (this.delta > this.span)
        {
            this.delta = 0;
            Instantiate(bomb1, new Vector3(x, y, 0), Quaternion.identity);
            if (span > 2.0f)
            {
                span -= 0.5f;
            }
            numberOfBombs++;
        }
    }
}
