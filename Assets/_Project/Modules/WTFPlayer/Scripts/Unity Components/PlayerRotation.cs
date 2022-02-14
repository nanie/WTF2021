using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 1;

    public void RotatePlayer(float horizontal)
    {
        horizontal = horizontal * _sensitivity * Time.fixedDeltaTime;
        transform.Rotate(Vector3.up * horizontal);
    }
}
