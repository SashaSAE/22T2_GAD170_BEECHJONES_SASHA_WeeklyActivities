using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class TriggerZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("box collision" + other.gameObject.name);

            //want to move the falling sphere up a bit, so it falls again
            //lets try setting the transform position
            other.gameObject.transform.position = new Vector3(0, 6, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

}
