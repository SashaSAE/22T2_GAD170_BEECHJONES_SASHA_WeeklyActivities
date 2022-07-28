using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class VerticalPusher : MonoBehaviour
    {
        [SerializeField] private Vector3 pushForce;
        private void OnEnable()
        {
            EventManager.OnClicked += PushObjectUp;
        }
        private void OnDisable()
        {
            EventManager.OnClicked -= PushObjectUp;
        }
        private void PushObjectUp()
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(pushForce);
        }
    }
}
