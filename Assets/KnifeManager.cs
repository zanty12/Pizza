using System.Collections;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    private bool isKnifeEnd = false;
    public float moveInterval = 5.0f; // 動かす間隔（秒）
    private float moveDistance = 20.0f; // 移動距離
    private Vector3 initialPosition;
    public Transform targetObject; // CylinderオブジェクトのTransform

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
            Vector3 targetPosition = targetObject.position; // Cylinderオブジェクトの位置を取得

            while (timeElapsed < moveInterval)
            {
                timeElapsed += Time.deltaTime;
                transform.position = Vector3.Lerp(initialPosition, targetPosition, timeElapsed / moveInterval);
                yield return null;
            }

            transform.position = targetPosition;

            yield return new WaitForSeconds(0.5f); // 移動終了後の待機時間

            transform.position = initialPosition; // 初期位置に戻す

            yield return null;
        }
    }

    public void UpdateMoveDistance(float newDistance)
    {
        moveDistance = newDistance;
    }
}