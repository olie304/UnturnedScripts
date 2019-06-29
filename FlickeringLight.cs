using System;
using UnityEngine;

namespace SDG.Unturned
{
    // Causes a Light object to chaotically flicker
    public class FlickeringLight : MonoBehaviour
    {
        [Tooltip("Light to flicker")]
        public Light target;
    }
}
