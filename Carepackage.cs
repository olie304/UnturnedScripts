using UnityEngine;

namespace SDG.Unturned
{
    // Requires a BoxCollider on the base Game Object
    // When the Collider attatched to the base Game Object collides with anything it will spawn the specified barricade and effect #120 will play
    // If the barricade is an InteractableStorage 8 random items from the item pool will be added
    // After 10 minutes the carepackage will despawn
    
    // This will not make the Carepackage move on its own. To make an accurate carepackage add a rigidbody with gravity, 1 mass and 0.5 angular drag as well as a constant force object with a Y force value of 9.5
    // It is up to you to extract the parachute and light assets and whatever else
	public class Carepackage : MonoBehaviour
	{
        // The barricade to spawn, by default it is the base game Carepackage barricade
        // If you want it to fill with items it can be an interactable storage but it is not required
		public ushort barricadeID = 1374;

		// The Spawn Table id to use when filling the carepackage
        // Might throw an error if your barricade is an interactable storage and the id is invalid
		public ushort id;
	}
}
