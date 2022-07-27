using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class Week8Thursday : MonoBehaviour
    {
        public enum Fruit
        {
            Apple,
            Banana,
            Dragonfruit,
            Mango,
            Orange,
            Peach,
            Pear,
            Strawberry
        }
        public Fruit favouriteFruit = Fruit.Strawberry;

        public Fruit[] myFruitBasket = new Fruit[10];
        // int i = 0; i < fruitBasket.Length; i++


        // Start is called before the first frame update
        private void Start()
        {
            favouriteFruit = Fruit.Mango;
            //Debug.Log("My favourite fruit is " + favouriteFruit);
            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                //myFruitBasket[i] = Fruit.Orange;
                //  Debug.Log("My basket is full of " + myFruitBasket [i]);
                Debug.Log("The fruit I picked out of my basket was a " + myFruitBasket[i]);
                CheckFruit(myFruitBasket[i]);
            }
        }

        private void CheckFruit(Fruit typeOfFruit)
        {
            switch (typeOfFruit)
            {
                case Fruit.Apple:
                    break;
                case Fruit.Banana:
                    break;
                case Fruit.Dragonfruit:
                    break;
                case Fruit.Mango:
                    //YES; MANGOS
                    break;
                case Fruit.Orange:
                    break;
                case Fruit.Peach:
                    break;
                case Fruit.Pear:
                    break;
                case Fruit.Strawberry:
                    break;
                default:
                    break;
            }
        }
        //We want to output different text depending on which fruit was chosen.
        //If it is an apple do X
        //If it is a banana, Y
        // ...etc
        //switch tab tab type in type of fruit press enter twice
        //
        // Update is called once per frame
        void Update()
        {

        }
    }
}

