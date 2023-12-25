using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizaaMove : MonoBehaviour
{
    // �ړ����鋗��
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
        // �I�u�W�F�N�g�̃��[�J�����W���擾
        Vector3 localPosition = transform.localPosition;

        if (Mathf.Abs(localPosition.x) < moveBackDistance)
        {
            // �I�u�W�F�N�g�����[�J�����W�Ō��ɉ�����
            MoveBack();
        }
        else if (Mathf.Abs(localPosition.y) < moveUpDistance)
        {
            // �I�u�W�F�N�g�����[�J�����W�Ō��ɉ�����
            MoveUp();
        }
    }

    void MoveBack()// �I�u�W�F�N�g�����[�J�����W�Ō��ɉ�����
    {
        transform.Translate(Vector3.back * moveBackSpeed, Space.Self);
    }

    private void MoveUp()// �I�u�W�F�N�g�����[�J�����W�ŏ�ɏグ��
    {
        transform.Translate(Vector3.up * moveUpSpeed, Space.Self);
    }
}
