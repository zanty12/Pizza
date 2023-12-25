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
        // オブジェクトをローカル座標で後ろに下げる
        MoveBackward();
    }

    void MoveBackward()
    {
        if (transform.localPosition.x < moveBackDistance)
        {
            // オブジェクトをローカル座標で後ろに下げる
            transform.Translate(Vector3.back * moveBackSpeed, Space.Self);
        }
        else if (transform.localPosition.y < moveUpDistance)
        {
            transform.Translate(Vector3.up * moveUpSpeed, Space.Self);
        }
    }
}
