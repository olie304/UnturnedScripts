using UnityEngine;

namespace SDG.Unturned
{
    // Requires a Collider on the base Game Object with 'isTrigger' set to True
    // When a player collides with the collider they are given the Steam achievement specified if it exists and they are teleported to the target transform after 3 seconds
    // Untested but can likely only teleport one player at a time
    // When a player is teleported the specified effect is played at a radius of 16 at the position of the eventHook transform
    // Upon teleporting players are given the same Y axis rotation as the target transform
    public class VolumeTeleporter : MonoBehaviour
    {
        // Achievement to give player, can be a null or empty string if you don't want to cheat :P
        public string achievement;

        // Teleporter Endpoint
        public Transform target;

        // Effect ID to play when player is teleported
        public ushort teleportEffect;

        // Location to play teleporter effect
        public Transform effectHook;
    }
}
