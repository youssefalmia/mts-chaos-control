using UnityEngine;
using System.Collections;

public class TransformFollower : MonoBehaviour
{
    [SerializeField]
    private Transform target;




    private void Update()
    {
        transform.rotation = target.rotation;
    }
    
        
    
}