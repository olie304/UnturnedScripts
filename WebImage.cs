using UnityEngine;

namespace SDG.Unturned
{
    // Not sure if this works but if it does it should load an image file at a URL into the targetImage 
    // which might be usable in a renderer or material.
    // isExpanded, targetLayout and targetButton can be left Null as they don't do anything useful.
    // Using animation events you might be able to call the setAddressAndRefresh and Refresh methods.
    public class WebImage : MonoBehaviour
    {
        // Load image at URL
        public void setAddressAndRefresh(string newURL, bool newShouldCache, bool forceRefresh)
        {
        }
        
        // Refresh Image
        public void Refresh()
        {
        }

        // Must have image set here, it will be replaced when image at URL is loaded
        public Image targetImage;

        public string url;

        public bool shouldCache = true;

        public Button targetButton;

        public LayoutElement targetLayout;

        public bool isExpanded;

        // Ignore these. If you can access them you can use them in a material though I doubt it.
        protected Texture2D texture;
        protected Sprite sprite;
    }
}
