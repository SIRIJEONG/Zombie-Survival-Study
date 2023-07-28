using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour
{

    void Awake()
    {

        List<Dictionary<string, object>> data = CSVReader.Read("ZombieTest");

        for (var i = 0; i < data.Count; i++)
        {
            print("ZOMBIE_TYPE " + data[i]["ZOMBIE_TYPE"] + " " +
                   "HEALTH " + data[i]["HEALTH"] + " " +
                   "DAMAGE " + data[i]["DAMAGE"] + " " +
                   "SPEED " + data[i]["SPEED"] + " " +
                   "SKIN_COLOR " + data[i]["SKIN_COLOR"]);
        }

    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
