using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{

    private Vector3 _startScale;

    private float _curentTime;
    private float _duration = 2f;
    private Vector3 _biggestScale = new Vector3(2.5f,2.5f,2.5f);
    private Vector3 _lowerScale = new Vector3(0.1f,0.1f,0.1f);
    
    
    // Start is called before the first frame update
    void Start()
    {
        _startScale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        _curentTime += Time.deltaTime;
        transform.localScale = Vector3.Lerp(_startScale + _lowerScale, _startScale + _biggestScale,
            Mathf.PingPong(_curentTime, _duration) / _duration);
    }
}
