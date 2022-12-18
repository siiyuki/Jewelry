using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class VirtualCameraController : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    private CinemachineOrbitalTransposer orbitalTransposer;
    private Vector2 lastMousePosition;
    // �J�����̊p�x���i�[����ϐ��i�����l��0,0�����j
    private Vector2 cameraAngle = new Vector2(0, 0);

    public float forwardSpeed;
    public float riseSpeed;
    void Start()
    {
        this.virtualCamera = this.GetComponent<CinemachineVirtualCamera>();
        this.orbitalTransposer = this.virtualCamera.GetComponentInChildren<CinemachineOrbitalTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardViewPoint();
        //heightViewPoint();
    }

    // �O��̃J��������
    private void forwardViewPoint()
    {
        // �}�E�X�z�C�[���̉�]�l��ϐ� scroll �ɓn��
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 offset = this.virtualCamera.transform.forward * scroll * forwardSpeed;
        orbitalTransposer.m_FollowOffset -= offset;
        Debug.Log(offset.ToString());
    }


    // ���������̃J��������

}
