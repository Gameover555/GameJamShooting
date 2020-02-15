using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Bullet;

    int controlNum = 1; //コントローラーの番号
    int m_hitpoint = 10;
    float m_inputLX = 0;
    float m_inputLY = 0;
    float m_inputRX = 0;
    float m_inputRY = 0;
    float m_moveSpeed = 3.0f;
    float m_bulletSpeed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputKey();
        MovePlayer();

    }

    void InputKey()
    {
        float m_inputLX = 0;
        float m_inputLY = 0;
        float m_inputRX = 0;
        float m_inputRY = 0;

        m_inputLX = Input.GetAxis("LStick_X_" + controlNum);
        m_inputLY = Input.GetAxis("LStick_Y_" + controlNum);
        m_inputRX = Input.GetAxis("RStick_X_" + controlNum);
        m_inputRY = Input.GetAxis("RStick_Y_" + controlNum);

    }

    void MovePlayer()
    {
        Vector3 moveVec = new Vector3(m_inputLX * m_moveSpeed, m_inputLY * m_moveSpeed, 0) * Time.deltaTime;
        transform.position += moveVec;
    }

    void BulletShoot()
    {
        if (m_inputRX != 0 || m_inputRY != 0)
        {
            Vector3 shootVec = new Vector3(m_inputRX, m_inputRY, 0);
            //Instantiate(Bullet);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "2PBullet")
        {

        }
    }
}
