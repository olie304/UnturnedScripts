using UnityEngine;
using SDG.Unturned;

namespace SDG.Framework.Devkit
{
    // Instantly kills anything inside of the BoxCollider on the base Game Object
    // BoxCollider must have 'isTrigger' set to True
    // Game Object Layer is set to 30 at runtime and cannot be overriden
    public class KillVolume : MonoBehaviour
    {       
        public bool killPlayers;

        public bool killZombies;

        public bool killAnimals;

        public bool killVehicles;

        public EDeathCause deathCause;
    }
}

namespace SDG.Unturned
{
    public enum EDeathCause
    {
        BLEEDING,
        BONES,
        FREEZING,
        BURNING,
        FOOD,
        WATER,
        GUN,
        MELEE,
        ZOMBIE,
        ANIMAL,
        SUICIDE,
        KILL,
        INFECTION,
        PUNCH,
        BREATH,
        ROADKILL,
        VEHICLE,
        GRENADE,
        SHRED,
        LANDMINE,
        ARENA,
        MISSILE,
        CHARGE,
        SPLASH,
        SENTRY,
        ACID,
        BOULDER,
        BURNER,
        SPIT,
        SPARK
    }
}

