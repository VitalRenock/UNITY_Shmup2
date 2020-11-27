using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotor : MonoBehaviour
{
    Camera _camera;
    public float _boundariesWidth;
    public float _boundariesHeight;
    public float _shipSpeed;

    void Start()
    {
        if(_shipSpeed == 0f)
        {
            _shipSpeed = 8f;
            Debug.LogWarning("Aucune vitesse ou rotation renseignée, '_shipSpeed' réglé sur '1'");
        }

        _camera = Camera.main;
        _boundariesHeight = _camera.orthographicSize;
        _boundariesWidth = _camera.orthographicSize * _camera.aspect;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f) { MotorShip(); }
        
        // Correction de la position du joueur.
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -_boundariesWidth, _boundariesWidth), transform.position.y, transform.position.z);
    }

    private void MotorShip()
    {
        transform.Translate(Input.GetAxis("Horizontal") * _shipSpeed * Time.deltaTime, 0f, 0f);
    }
}
