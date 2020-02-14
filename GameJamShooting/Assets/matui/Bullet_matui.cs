using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_matui : MonoBehaviour
{
    float Delete_time;
    float time;
    public GameObject effect_1;

    public float speed;//速さ

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //
        time = Time.deltaTime;
        Delete_time += time;

        transform.Translate(0, speed * time, 0);
        if (Delete_time > 3.0f)
        {
            Destroy(gameObject);
        }
    }
    //当たったら
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Instantiate
                (effect_1, new Vector3(this.transform.position.x, this.transform.position.y, 0.0f), Quaternion.identity);

            Destroy(gameObject);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Instantiate
                (effect_1, new Vector3(this.transform.position.x, this.transform.position.y, 0.0f), Quaternion.identity);

            Destroy(gameObject);
        }
    }
    
}
