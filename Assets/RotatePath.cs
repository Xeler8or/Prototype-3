using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePath : MonoBehaviour
{
    private Vector3 _rotation;

    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.D))
            _rotation = Vector3.down;
        else
            _rotation = Vector3.zero;
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
