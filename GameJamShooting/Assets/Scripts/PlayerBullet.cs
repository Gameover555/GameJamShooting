using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public int controlNum;
    Vector3 m_velocity;
    bool isDestroy = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDestroy)
        {
            transform.position += m_velocity * Time.deltaTime;
        }
    }

    public void Init(Vector3 vec,float speed)
    {
        m_velocity = vec * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall")
        {
            Destroy(gameObject, 0.2f);
            isDestroy = true;
        }
        else if (collision.tag == "Bomb")
        {
            Destroy(gameObject, 0.2f);
            isDestroy = true;
        }

        switch (controlNum)
        {
            case 1:
                if(collision.tag == "Player2")
                {
                    Destroy(gameObject, 0.2f);
                    isDestroy = true;
                }
                break;
            case 2:
                if (collision.tag == "Player1")
                {
                    Destroy(gameObject, 0.2f);
                    isDestroy = true;
                }
                break;
            default:
                break;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            Destroy(gameObject, 0.2f);
            isDestroy = true;
        }

        switch (controlNum)
        {
            case 1:
                if (collision.tag == "Player2")
                {
                    Destroy(gameObject, 0.2f);
                    isDestroy = true;

                }
                break;
            case 2:
                if (collision.tag == "Player1")
                {
                    Destroy(gameObject, 0.2f);
                    isDestroy = true;

                }
                break;
            default:
                break;
        }
    }
}
