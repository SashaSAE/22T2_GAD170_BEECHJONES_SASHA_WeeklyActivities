using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class PlayerHealth : MonoBehaviour
    {
        public int playerHealth = 10;

        private void Update()
        {
            if(playerHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
