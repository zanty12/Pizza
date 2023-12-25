using System.Collections;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    private bool isKnifeEnd = false;
    public float moveInterval = 5.0f; // �������Ԋu�i�b�j
    private float moveDistance = 20.0f; // �ړ�����
    private Vector3 initialPosition;
    public Transform targetObject; // Cylinder�I�u�W�F�N�g��Transform

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(MoveRepeatedly());
    }

   public IEnumerator MoveRepeatedly()
    {
        while (!isKnifeEnd)
        {
            yield return new WaitForSeconds(moveInterval);

            float timeElapsed = 0.0f;
            Vector3 targetPosition = targetObject.position; // Cylinder�I�u�W�F�N�g�̈ʒu���擾

            while (timeElapsed < moveInterval)
            {
                timeElapsed += Time.deltaTime;
                transform.position = Vector3.Lerp(initialPosition, targetPosition, timeElapsed / moveInterval);
                yield return null;
            }

            transform.position = targetPosition;

            yield return new WaitForSeconds(0.5f); // �ړ��I����̑ҋ@����

            transform.position = initialPosition; // �����ʒu�ɖ߂�

            yield return null;
        }
    }

    public void UpdateMoveDistance(float newDistance)
    {
        moveDistance = newDistance;
    }
}