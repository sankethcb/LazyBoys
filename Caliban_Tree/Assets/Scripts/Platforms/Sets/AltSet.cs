using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltSet : PlatformSet
{

    public override void SetPlatform()
    {
        for (int i = 0; i < 2; i++)
        {

            platforms.Add(Instantiate(childPlatform));
            platforms[i].transform.parent = gameObject.transform;


        }

        platforms[0].transform.localPosition = new Vector3(-10f, 0.0f);
        platforms[1].transform.localPosition = new Vector3(0.0f, 2.5f);
        //platforms[2].transform.localPosition = new Vector3(10f, 5.0f);

    }
}
