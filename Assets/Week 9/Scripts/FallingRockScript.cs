using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class FallingRockScript : MonoBehaviour
    {
        public int rockDamage = 5;

       
        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<PlayerHealth>().playerHealth -= rockDamage;
            //same thing as writing "...playerHealth = playerHealth - 5;
        }
        
    }
}
