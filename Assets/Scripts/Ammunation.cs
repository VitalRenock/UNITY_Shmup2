using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunation : MonoBehaviour
{
    public float _ammuSpeed;

    /*[HideInInspector]*/ public LayerMask _hitlayer;

    private void Awake()
    {
        Destroy(this.gameObject, 1);
    }
    void Update()
    {
        transform.Translate(Vector3.up * _ammuSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_hitlayer == ( _hitlayer | (1 << collision.gameObject.layer))) { Destroy(collision.gameObject); }
        //Destroy(collision.gameObject);
    }
}
