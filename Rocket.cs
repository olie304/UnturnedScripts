using UnityEngine;
using Steamworks;

namespace SDG.Unturned
{
    // Creates an explosion when an object collides with the collider component on the object with this script.
    // Damage and damage range can be specified for each damagable entity.
    // If the object which collides with the collider is the transform ignoreTransform or a child of ignoreTransform it will not explode.
    // When the rocket explodes it is completely destroyed and cannot be reset.
    // The rocket will not move on its own so it can be used as a stationary trap or an Apply Force and Rigidbody component can be added to make it move.
    public class Rocket : MonoBehaviour
    {
        public CSteamID killer;

        // Explosion Damage Radius
        public float range;

        public float playerDamage;

        public float zombieDamage;

        public float animalDamage;

        public float barricadeDamage;

        public float structureDamage;

        public float vehicleDamage;

        public float resourceDamage;

        public float objectDamage;

        // ID of the effect to be played when rocket explodes
        public ushort explosion;

        public bool penetrateBuildables;

        public Transform ignoreTransform;

        public ERagdollEffect ragdollEffect;
    }

    public enum ERagdollEffect
    {
        NONE,
        BRONZE,
        SILVER,
        GOLD,
        ZERO_KELVIN
    }
}

namespace Steamworks
{
    public struct CSteamID
    {
        public ulong m_SteamID;
    }
}

