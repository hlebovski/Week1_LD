using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour {

    [SerializeField] private float _rotationSpeed;
    private float _angle;
    private float _wantedAngle;

    private void Update() {

        if (Input.GetKeyDown(KeyCode.A)) { _wantedAngle += 90; }
        if (Input.GetKeyDown(KeyCode.D)) { _wantedAngle -= 90; }

        _angle = Mathf.Lerp(_angle, _wantedAngle, Time.deltaTime * _rotationSpeed);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, _angle, transform.localEulerAngles.z);
    }
}
