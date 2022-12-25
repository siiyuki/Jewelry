using UnityEngine;
public class ChangeColorYellow : MonoBehaviour
{
    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "ChangeColor")
        {
            // 自分自身の色を赤に変える
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
