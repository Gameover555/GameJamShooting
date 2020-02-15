using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpowner : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 pos = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0);
        Instantiate(Player1, pos,transform.rotation);

        Vector3 pos2 = new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0);
        Instantiate(Player2, pos2, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
