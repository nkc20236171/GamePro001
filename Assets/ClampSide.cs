using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampSide : MonoBehaviour
{
    [SerializeField] private float _minX =-1;
    [SerializeField] private float _maxX = 1;
    private void Updete()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        transform.position = pos;
    }
   
}
