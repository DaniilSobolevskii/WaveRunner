using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _step;
    private Vector3 _upperBorder;
    private Vector3 _lowerBorder;
   
    private float _curentTime;
    private float _duration = 1f;
    void Start()
    {
        Vector3 start = transform.position;
        _lowerBorder = start;
        _lowerBorder.y += _step;
        _upperBorder = start;
        _upperBorder.y -= _step;
    }

    void Update()
    {
        _curentTime += Time.deltaTime;
        transform.position=Vector3.Lerp(_upperBorder,_lowerBorder, Mathf.PingPong(_curentTime, _duration) / _duration);
    }
}

