using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeastryOverTime : MonoBehaviour
{
    public float timerD = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerD -= Time.deltaTime;
        if(timerD <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
