using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public PlayerBullet Bullet;
    Rigidbody2D rb;
    public int controlNum; //コントローラーの番号
    int m_hitpoint = 10;
    float m_inputLX = 0;
    float m_inputLY = 0;
    float m_inputRX = 0;
    float m_inputRY = 0;
    float m_moveSpeed = 5.0f;
    float m_bulletSpeed = 7.0f;
    float m_shotTimer = 0;
    float m_shotInterval = 0.15f;
    float m_finishTimer = 0;
    float m_finishInterval = 2.0f;
    float m_timer = 0;
    float m_startTime = 6.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        m_timer += Time.deltaTime;
        Debug.Log(m_timer);

        if (m_timer > m_startTime)
        {
            InputKey();
            MovePlayer();
            BulletShot();

            if (m_hitpoint < 0)
            {
                m_hitpoint = 0;
                m_finishTimer += Time.deltaTime;
                Destroy(gameObject, 1.0f);

                if (m_finishTimer > m_finishInterval)
                {
                    switch (controlNum)
                    {
                        case 1:
                            SceneManager.LoadScene("ResultScene2P");
                            break;
                        case 2:
                            SceneManager.LoadScene("ResultScene1P");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    void InputKey()
    {
        m_inputLX = 0;
        m_inputLY = 0;
        m_inputRX = 0;
        m_inputRY = 0;

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

    void BulletShot()
    {
        m_shotTimer += Time.deltaTime;
        if (m_inputRX != 0 || m_inputRY != 0)
        {
            if (m_shotTimer > m_shotInterval)
            {
                Vector3 shotVec = new Vector3(m_inputRX, m_inputRY, 0).normalized;
                var bullet = Instantiate(Bullet, transform.position, transform.rotation);
                bullet.Init(shotVec, m_bulletSpeed);
                m_shotTimer = 0;
            }
        }
    }

    public int GetHP()
    {
        return m_hitpoint;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (controlNum)
        {
            case 1:
                if (collision.tag == "Bullet2" || collision.tag == "BombBullet")
                {
                    m_hitpoint--;
                }
                break;
            case 2:
                if (collision.tag == "Bullet1" || collision.tag == "BombBullet")
                {
                    m_hitpoint--;
                }
                break;
            default:
                break;
        }
    }

    
}
