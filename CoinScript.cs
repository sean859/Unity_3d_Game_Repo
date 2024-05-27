using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotateSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // The coin will spin its z axis by the rotateSpeed you can set in the Unity creator
        transform.Rotate(0, 0, rotateSpeed);
    }
}
