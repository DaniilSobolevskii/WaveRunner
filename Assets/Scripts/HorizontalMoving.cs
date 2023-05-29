using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class HorizontalMoving : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _leftBorder;
    private Vector3 _rightBorder;
    private float _curentTime;
    private float _duration = 2f;
    void Start()
    {
        Vector3 start = transform.position;
       _rightBorder = start;
       _rightBorder.x += 3;
       _leftBorder = start;
       _leftBorder.x -= 3;
    }

    // Update is called once per frame
    void Update()
    {
        _curentTime += Time.deltaTime;
        transform.position=Vector3.Lerp(_rightBorder, _leftBorder, Mathf.PingPong(_curentTime, _duration) / _duration);
    }
}
