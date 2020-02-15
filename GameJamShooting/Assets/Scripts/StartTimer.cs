using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    float timer = 0;
    float startTime = 10.0f;
    GameObject player1;
    GameObject player2;
    public PlayerController playerScript1;
    public PlayerController playerScript2;
    bool isStop = true;
    // Start is called before the first frame update
    void Start()
    {
        //player1 = GameObject.Find("Player1");
        //player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //playerScript = player1.GetComponent<PlayerController>();
        //playerScript.enabled = isStart;
        //playerScript = player2.GetComponent<PlayerController>();
        //playerScript.enabled = isStart;
        playerScript1.enabled = isStop;
        playerScript2.enabled = isStop;

        Debug.Log(isStop);
        if (timer > startTime)
        {
            isStop = false;
        }
    }
}
