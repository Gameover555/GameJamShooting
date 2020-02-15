using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public GameObject B_Bullet;
    float speed;
    bool bulletFlag = true;
    float angleBase;
    float angleRange;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    

    void Update()
    {
        if (bulletFlag)
        {
            for (int i = 0; i < 10; i++)
            {
                    // 弾（ゲームオブジェクト）の生成
                    GameObject clone = Instantiate(B_Bullet, transform.position, Quaternion.identity);

                // クリックされた座標取得
                //// 向きの生成（Z成分の除去と正規化）
                Vector3 shotForward = Vector3.Scale(( transform.position), new Vector3(1, 1, 0)).normalized;
                shotForward.x = Random.Range(-1f,1f);
                shotForward.y = Random.Range(-1f, 1f);
                shotForward.z = 0f;
                shotForward = shotForward.normalized;
                Destroy(gameObject);

                // 弾に速度を与える
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

            }
        }
    }

   
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "BombBullet")
        {
            //
            bulletFlag = true;
            //Debug.Log("as");  
        }
    }
}
// Debug.Log("as");
                   // Destroy(gameObject);
                    //float y = Random.Range(-1, 10);
                    //float z = Random.Range(-1, 1);
                    //clone.transform.position = new Vector3(5, y, z);
                    //Destroy(gameObject);

               