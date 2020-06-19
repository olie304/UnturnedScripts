using UnityEngine;

namespace SDG.Unturned
{
    // Toggles a binary state object when a phrase is typed in chat within a certain radius of the object.
    // In order for it to work you must create a LevelObject that is on the same position as the parent of this script
    // and it must be a binary state object and it must have the same ID as specified in the ID slot below. I have not
    // been able to test everything so if you are interested and are running into problems leave an issue or contact me some other way.
    public class InteractableBinaryStateChatTrigger : MonoBehaviour
    {
        [Tooltip("Object ID (Choose a random one)")]
        public ushort id;

        [Tooltip("Phrase that will trigger the event")]
        public string phrase;

        [Tooltip("Range of trigger")]
        public float sqrRadius;
        
        // Ignore this, this is just to clarify the object type of the target as specified in the instructions above
        private InteractableObjectBinaryState target;
    }
}
