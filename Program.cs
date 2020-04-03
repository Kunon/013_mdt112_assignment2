using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    public GameObject goalGameObject;

    void OnMouseDrag();
    {
      transform.position=new vector1(0, 5, 0);
    }
     private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.Equals())
       {
        Debug.Log("Win");
       }

    }
}
