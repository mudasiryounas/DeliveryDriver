using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // players position should be same as of camera
    [SerializeField] GameObject objectToFollow;

    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);

        
    }
}
