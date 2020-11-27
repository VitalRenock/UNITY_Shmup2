using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesSpawn : MonoBehaviour
{
    public Vector3 _spawnDirection;

    void Update()
    {
        //transform.Rotate(0f, 0f, 10f);
        transform.Rotate(0f, 0f, Mathf.Sin(Time.time));
        //transform.rotation *= new Quaternion(0f, 0f, Mathf.Sin(Time.time), 0f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.up);
    }
}
