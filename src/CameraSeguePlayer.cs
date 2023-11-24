using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguePlayer : MonoBehaviour
{
    public Transform cameraPlayer;
    

    void FixedUpdate()
    {
        transform.position = cameraPlayer.position + new Vector3(0, 0, -10f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-4.21f, 81.65923f), Mathf.Clamp(transform.position.y,-3.349999f, 54.54974f), transform.position.z);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
