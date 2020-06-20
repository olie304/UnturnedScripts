using UnityEngine;

namespace SDG.Unturned
{
    // Plays the specified effect when something collides with the Collider component on the base Game Object
    // Destroys itself after one use and cannot be reset
    public class Acid : MonoBehaviour
    {
        public ushort effectID;
    }
}
