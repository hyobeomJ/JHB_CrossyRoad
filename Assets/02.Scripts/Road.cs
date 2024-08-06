using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Car CloneTarget = null;
    public Transform GenerationPos = null;
    public int GenerationPersent = 50;

    public float CloneDelaySec = 1f;

    protected float NextSecToClone = 0f;
    void Start()
    {
        
    }


    void Update()
    {
        float currSec = Time.time;
        if(NextSecToClone <= currSec)
        {
            int randomval = Random.Range(0,100);
            if(randomval <= GenerationPersent)
            {
                CloneCar();
            }
            NextSecToClone = currSec + CloneDelaySec;
        }
    }

    void CloneCar()
    {
        Transform clonepos = GenerationPos;
        Vector3 offsetpos = clonepos.position;
        offsetpos.y = 0.5f;

        GameObject cloneobj = GameObject.Instantiate(CloneTarget.gameObject
            ,offsetpos
            ,GenerationPos.rotation
            , this.transform);

        cloneobj.SetActive(true);


    }
}
