using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class VirtualCameraController : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    private CinemachineOrbitalTransposer orbitalTransposer;
    private Vector2 lastMousePosition;
    // カメラの角度を格納する変数（初期値に0,0を代入）
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

    // 前後のカメラ操作
    private void forwardViewPoint()
    {
        // マウスホイールの回転値を変数 scroll に渡す
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 offset = this.virtualCamera.transform.forward * scroll * forwardSpeed;
        orbitalTransposer.m_FollowOffset -= offset;
        //Debug.Log(offset.ToString());
    }


    // 垂直方向のカメラ操作

}
