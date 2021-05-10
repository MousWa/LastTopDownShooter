using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Enemey : MonoBehaviour
{
    private EnemyPathfindingMovement pathfindingMovment;
    private Vector3 startingPostiton;
    private Vector3 roamPostition;
   
    private void Awake()
    {
        pathfindingMovment = GetComponent<EnemyPathfindingMovement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        startingPostiton = transform.position;
        roamPostition = GetRoamingPosition();
    }

    // Update is called once per frame
    void Update()
    {
        pathfindingMovment.MoveToTimer(roamPostition);
        float reachedPositionDistance = 10f;
        if(Vector3.Distance(transform.position, roamPostition)< reachedPositionDistance)
        {
            roamPostition = GetRoamingPosition();
        }
    }
    Vector3 GetRoamingPosition()
    {
        return startingPostiton + UtilsClass.GetRandomDir() * Random.Range(10f, 70f);
    }
}
