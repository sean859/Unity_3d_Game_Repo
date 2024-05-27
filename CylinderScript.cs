using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
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
        // Similiar to the CoinScript but its for a different gameObject (in this case the 3D cylinder objects at the fifth course)
        transform.Rotate(rotateSpeed, 0, 0);
    }
}

