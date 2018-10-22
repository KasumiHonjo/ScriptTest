using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+ this.mp +"。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss boss = new Boss();
        int[] points = {1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(points[j]);
        }
        
        for (int n = 0;n < 11; n++)
        {
            boss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
