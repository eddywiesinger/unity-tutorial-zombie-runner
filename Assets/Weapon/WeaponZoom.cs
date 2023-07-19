using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutRotSpeed = 2.5f;
    [SerializeField] float zoomedInRotSpeed = 0.8f;

    FirstPersonController fpc;
    bool zoomedInToggle = false;

    private void Start()
    {
        fpc = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
                fpc.RotationSpeed = zoomedInRotSpeed;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
                fpc.RotationSpeed = zoomedOutRotSpeed;
            }
        }
    }
}
