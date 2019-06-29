using UnityEngine;

namespace SDG.Unturned
{
    // Toggles a binary state object when a phrase is typed in chat within a certain radius of the object
    //DISCLAIMER: THIS MIGHT NOT WORK!
    public class InteractableBinaryStateChatTrigger : MonoBehaviour
    {
        [Tooltip("Object ID (Choose a random one)")]
        public ushort id;

        [Tooltip("Phrase that will trigger the event")]
        public string phrase;

        [Tooltip("Range of trigger")]
        public float sqrRadius;

        [Tooltip("The Binary State Object to trigger")]
        [SerializeField]
        private InteractableObjectBinaryState target;
    }
}
