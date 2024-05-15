using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontPorchMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked on the FrontPorchMove object");
        }
    }
}
