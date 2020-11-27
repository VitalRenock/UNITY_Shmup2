using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    [SerializeField] GameObject _prefabAmmu;
    GameObject _ammunation;
    [SerializeField] Transform _shootPoint;
    public float _shootFireRate;
    float _lastShootTime;

    public LayerMask _layerMask;

    private void Start()
    {
        if(_shootFireRate == 0f) { _shootFireRate = 1f; }
        _lastShootTime = 0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > _lastShootTime + _shootFireRate)
        {
            ShipShooting();
            _lastShootTime = Time.time;
        }
    }

    private void ShipShooting()
    {
        _ammunation = Instantiate(_prefabAmmu, _shootPoint.position, Quaternion.identity);
        _ammunation.gameObject.layer = _layerMask;
    }
}
