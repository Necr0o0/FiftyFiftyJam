using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeController : MonoBehaviour
{
    private Vector2 initialposition;
    public float offset = 0.01f;
    public float rotateOffset = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        initialposition = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Random.Range(initialposition.x-offset,initialposition.x+offset) ,Random.Range(initialposition.y-offset,initialposition.y+offset),transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(-rotateOffset,rotateOffset));
    }
}
