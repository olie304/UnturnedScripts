using UnityEngine;

// Smoothely moves the base Game Object to each point in points along a smooth curve.
public class BezierMover : MonoBehaviour
{
    // The points to travel to
    public Transform[] points;

    // Magnitude of the max slope for curving. Likely affects smootheness of curve.
    public float tangentLengths = 5f;

    public float speed = 1f;
}
