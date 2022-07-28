using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class TeleportingObject : MonoBehaviour
    {
        [SerializeField] private Vector3 teleportLocation;

        private void OnEnable()
        {
            //start listening to our "space bar press" event
            EventManager.OnClicked += Teleport;
        }
        private void OnDisable()
        {
            //stop listening to our "Space bar press" event
            EventManager.OnClicked -= Teleport;
        }
        private void Start()
        {
            teleportLocation = transform.position;  
        }
        private void Teleport()
        {
            transform.position = teleportLocation;
        }
    }
}
