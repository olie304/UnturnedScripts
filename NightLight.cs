using UnityEngine;

namespace SDG.Unturned
{
    // Turns a light on at night and off during the day
    public class NightLight : MonoBehaviour
    {
        [Tooltip("Light to toggle")]
        public Light target;
    }
}
