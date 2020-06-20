using UnityEngine;

namespace SDG.Unturned
{
    // Makes the target light become darker as you move further away.
    // Nice for moody lighting or to keep laggy lights from lighting up everything all the time.
    // Doesn't work on Area and Directional lights.
    // The light intensity specifies the starting/max intensity and the range property adjusts
    // the lighting distance and transition magnitude.
    public class LightLOD : MonoBehaviour
    {
        public Light targetLight;
    }
}
