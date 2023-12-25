using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizaaMove : MonoBehaviour
{
    // 移動する距離
    public float moveBackDistance = 1.0f;
    public float moveBackSpeed = 1.0f;
    public float moveUpDistance = 1.0f;
    public float moveUpSpeed = 1.0f;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトのローカル座標を取得
        Vector3 localPosition = transform.localPosition;

        if (Mathf.Abs(localPosition.x) < moveBackDistance)
        {
            // オブジェクトをローカル座標で後ろに下げる
            MoveBack();
        }
        else if (Mathf.Abs(localPosition.y) < moveUpDistance)
        {
            // オブジェクトをローカル座標で後ろに下げる
            MoveUp();
        }
    }

    void MoveBack()// オブジェクトをローカル座標で後ろに下げる
    {
        transform.Translate(Vector3.back * moveBackSpeed, Space.Self);
    }

    private void MoveUp()// オブジェクトをローカル座標で上に上げる
    {
        transform.Translate(Vector3.up * moveUpSpeed, Space.Self);
    }
}
