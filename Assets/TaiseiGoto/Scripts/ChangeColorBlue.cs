using UnityEngine;
public class ChangeColorBlue : MonoBehaviour
{
    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "ChangeColor")
        {
            // �������g�̐F��Ԃɕς���
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
