using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivitiesB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currentYear = (Random.Range(0,3000));
        Debug.Log("Current year is" + currentYear);
        {
            if (currentYear % 4 == 0)
            {
                Debug.Log("It is a leap year");
            }
            else
            {
                Debug.Log("It is not a leap year");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
