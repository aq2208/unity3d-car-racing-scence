using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] public float RotationValue = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationValue * Time.deltaTime, 0, 0);
    }
}
