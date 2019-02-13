using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Shake : MonoBehaviour
{
    [Range(0f, 2f)]
    public float Intensity;

    public Transform ball;
    Transform _target;
    Vector3 _initialPos;

    private void Start()
    {
        _target = GetComponent<Transform>();
        //_intialPos = _target.position;
    }

    float _pendingShakeDuration = 0f;

    public void Shake(float duration)
    {
        if (duration > 0)
        {
            _pendingShakeDuration += duration;
        }
    }

    bool _isShaking = false;

    public void Update()
    {
        if (_pendingShakeDuration > 0 && !_isShaking)
        {
            StartCoroutine(DoShake());
        }
    }

    IEnumerator DoShake()
    {
        _isShaking = true;

        _initialPos = _target.localPosition;
        print(_initialPos);
        //Debug.Break();

        var startTime = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < startTime + _pendingShakeDuration)
        {
            var randomPoint = ball.position + new Vector3(0,0, Random.Range(-0.1f, 0.1f) );
            _target.localPosition = randomPoint;
            yield return null;
        }

        _pendingShakeDuration = 0f;
        _target.localPosition = _initialPos;
        _isShaking = false;
    }
}
