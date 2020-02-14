using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_matui : MonoBehaviour
{

    public float speed;//速さ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 移動処理
        transform.Translate
            (Input.GetAxis("Horizontal") * 0.1f * speed,
            Input.GetAxis("Vertical") * 0.1f * speed,
            0);

        //キー、ステックの取得
        float Ver_1 = Input.GetAxis("Vertical");
        float Hor_1 = Input.GetAxisRaw("Horizontal");



    }
}
