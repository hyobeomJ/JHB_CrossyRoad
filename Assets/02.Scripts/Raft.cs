using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public float RangeDestroy = 12f;
    void Start()
    {
        
    }

    void Update()
    {
        float movex = MoveSpeed * Time.deltaTime;
        this.transform.Translate(movex, 0f, 0f);

        if(this.transform.localPosition.x >= RangeDestroy)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
