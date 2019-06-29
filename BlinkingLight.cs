using System;
using UnityEngine;

namespace SDG.Unturned
{
    // Enables and Disables a Game Object rapidly
    public class BlinkingLight : MonoBehaviour
    {
        [Tooltip("Game Object to toggle")]
        public GameObject target;
    }
}
