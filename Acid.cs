using System;
using SDG.Unturned;
using UnityEngine;

namespace SDG.Unturned
{
	// Plays the specified effect when something collides with the Collider 
	// component on the base Game Object
	
	// Destroys itself after one use and cannot be reset
	public class Acid : MonoBehaviour
	{
		public Guid effectGuid;

		// Kept because lots of modders have been using this script in Unity,
		// so removing legacy effect id would break their content.
		public ushort effectID;
	}
}
