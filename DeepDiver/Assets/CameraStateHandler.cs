using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateHandler : MonoBehaviour
{
    [SerializeField] TriggerChannelSO _swimmingStartTrigger;
    [SerializeField] TriggerChannelSO _walkingStartTrigger;
    [SerializeField] TriggerChannelSO _submarineStartTrigger;

    [SerializeField] GameObject _inSubCam;
    [SerializeField] GameObject _subCam;
    [SerializeField] GameObject _swimCam;
    [SerializeField] GameObject _window;

    private void OnEnable()
    {
        _swimmingStartTrigger.AddListener(ActivateSwimmingCam);
        _walkingStartTrigger.AddListener(ActivateWalkingCam);
        _submarineStartTrigger.AddListener(ActivateSubmarineCam);
    }

    private void OnDisable()
    {
        _swimmingStartTrigger.RemoveListener(ActivateSwimmingCam);
        _walkingStartTrigger.RemoveListener(ActivateWalkingCam);
        _submarineStartTrigger.RemoveListener(ActivateSubmarineCam);
    }

    private void Start()
    {
        ActivateWalkingCam();
    }

    private void ActivateSubmarineCam()
    {
        _swimCam.SetActive(false);
        _inSubCam.SetActive(false);

        _subCam.SetActive(true);
        _window.SetActive(true);
    }

    private void ActivateWalkingCam()
    {
        _swimCam.SetActive(false);
        _subCam.SetActive(false);

        _inSubCam.SetActive(true);
        _window.SetActive(false);
    }

    private void ActivateSwimmingCam()
    {
        _inSubCam.SetActive(false);
        _subCam.SetActive(false);

        _swimCam.SetActive(true);
        _window.SetActive(true);
    }
}
