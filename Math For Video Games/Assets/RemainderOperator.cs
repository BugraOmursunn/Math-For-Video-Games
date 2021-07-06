using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainderOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(0, 100);
        Debug.Log(i % 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
