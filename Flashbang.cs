using UnityEngine;

namespace SDG.Unturned
{
	// Does what a flashbang does when the object is created at the end of the fuse length
	public class Flashbang : MonoBehaviour
	{
		public Color color = Color.white;
		
		public float fuseLength = 2.5f;
		
		public bool playAudioSource = true;
    }
}
