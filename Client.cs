using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    Vector3 nextPos = Vector3.zero;
    ICake currentCake;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            ICake Cake = new BasicCake(nextPos);
            currentCake = Cake;
            Debug.Log("Basic taste: " + Cake.GetTaste());
            nextPos += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown("c"))
        {
            ICake Cake = new BasicCake(nextPos);
            Cake = new WithCream(Cake);
            currentCake = Cake;
            Debug.Log("With cream taste: " + Cake.GetTaste());
            nextPos += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown("t"))
        {
            ICake Cake = new BasicCake(nextPos);
            Cake = new WithCream(new WithTier(Cake));
            currentCake = Cake;
            Debug.Log("New tier + cream taste: " + Cake.GetTaste());
            nextPos += new Vector3(0, 0, 0);
        }

		if (Input.GetKeyDown("p"))
        {
            ICake Cake = new BasicCake(nextPos);
            Cake = new WithTopper(new WithTier(new WithCream(Cake)));
            currentCake = Cake;
            Debug.Log("Topper+ Cream + new tier taste: " + Cake.GetTaste());
            nextPos += new Vector3(0, 0, 0);
        }
		if (Input.GetKeyDown("a"))
        {
            ICake Cake = new BasicCake(nextPos);
            Cake = new WithCandle(new WithTopper(new WithTier(new WithCream(Cake))));
            currentCake = Cake;
            Debug.Log("Candle+ Topper+ Cream + new tier taste: " + Cake.GetTaste());
            nextPos += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            if (currentCake != null)
            {
                GameObject.Destroy(currentCake.GetGameObject());
                currentCake = null;
            }
        }
    }
}
