using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class WeekTwoActivities : MonoBehaviour
    {
        // Variables go here 

        private string favouriteGame = "Rune Factory";
        private int hoursPlayed = 700;
        private float gamePrice = 149.95f;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("This is string 1." + "This is string 2.");
            Debug.Log("My Favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours, and it cost me $" + gamePrice + ". Therefore, my value of dollars per hour is: $" + gamePrice/hoursPlayed + ".");

            int randomNumber = Random.Range(1, 15);

            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

