using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    GameObject player;
    PlayerController playerScript;
    int m_hitpoint;
    int m_maxHP;
    float hpScale;
    float maxScaleX;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.root.gameObject;
        playerScript = player.GetComponent<PlayerController>();
        Init(playerScript.GetHP());
        hpScale = transform.localScale.x / m_maxHP;
        maxScaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        SetHP(playerScript.GetHP());
        Vector3 scale = new Vector3(maxScaleX - hpScale * (m_maxHP - m_hitpoint), transform.localScale.y, 1);
        transform.localScale = scale;
    }

    public void Init(int hp)
    {
        m_hitpoint = hp;
        m_maxHP = m_hitpoint;
    }

    public void SetHP(int hp)
    {
        m_hitpoint = hp;
    }
}
