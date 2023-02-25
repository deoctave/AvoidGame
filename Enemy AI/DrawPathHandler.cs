using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPathHandler : MonoBehaviour
{
    public Transform transformRootObject;

    WaypointNode[] waypointNodes;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        if (transformRootObject == null)
            return;

        waypointNodes = transformRootObject.GetComponentsInChildren<WaypointNode>();

        foreach (WaypointNode waypoint in waypointNodes)
        {

            foreach (WaypointNode nextWayPoint in waypoint.nextWaypointNode)
            {
                if (nextWayPoint != null)
                    Gizmos.DrawLine(waypoint.transform.position, nextWayPoint.transform.position);

            }

        }
    }
}
