using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    private bool isKnufeEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("UpdateKnife", 3.0f);�@// �֐���3�b��Ɏ��s
    }

    private void UpdateKnife()
    {
        if (isKnufeEnd == false)
        {
            transform.position += new Vector3(-20, 0, 0) * Time.deltaTime;//�i�C�t�̈ړ�

            if (transform.position.x < -30.0f)
            {
                transform.position = new Vector3(30, 0, 0);//�ʒu�̃��Z�b�g
                isKnufeEnd = true;
            }
        }
    }
}
