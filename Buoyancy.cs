using UnityEngine;

namespace SDG.Unturned
{
    // Applies a buoyancy force to Game Objects when they are in the water.
    // Requires a BoxCollider component on the base Game Object and a Rigidbody that is affected by gravity and not Kinematic on the parent Game Object
    // The size (volume) of the BoxCollider as well as the mass of the Rigidbody are used when calculating the buoyancy force
    public class Buoyancy : MonoBehaviour
    {
        // Buoyancy is proportional to volume and inversely proportional to density
        public float density = 500f;

        // Idk alot about Buoyancy simulation but my guess is that this just increases the accuracy
        public int slicesPerAxis = 2;

        // I think this is an override for sea level. 
        // When it is less than 0 I think it only works in water but might work in air too if set to more than or equal to 0
        public float overrideSurfaceElevation = -1f;
    }
}
