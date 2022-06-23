using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{
    //Start: Sasha
    [SerializeField] private int yearsLeft = 2020;

    private void Start()
    {
        Surprise(yearsLeft);
        //Start: Max
    }

    public void Surprise(int yearsLeft)
    {
        if (yearsLeft % 4 == 0)
        {
            Debug.Log ("It is a leap year");
        }
        else
        {
            Debug.Log ("It is not a leap year");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
