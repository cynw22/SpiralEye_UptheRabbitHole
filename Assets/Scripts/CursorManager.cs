using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

// Referenced from https://www.youtube.com/watch?v=JybecYyj83k

namespace SwitchingCursor {
    public class CursorManager : MonoBehaviour
    {
        public static CursorManager Instance { get; private set; }
        
        public SwitchManager switchManager;
        public Texture2D aliceSprite;
        public Texture2D alicePoint;
        public Texture2D aliceClick;
        public Texture2D constanceSprite;
        public Texture2D constancePoint;
        public Texture2D constanceClick;

        private Vector3 hotspot = new Vector3(35.0f, -40.0f, 0.0f);
        private Image image;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            image = GetComponent<Image>();
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Input.mousePosition + hotspot;
        }

        public void SetToMode(ModeOfCursor modeOfCursor)
        {
            switch (modeOfCursor) 
            {
                case ModeOfCursor.Default:
                    Cursor.SetCursor(switchManager.sisterPOV == false ? aliceSprite : constanceSprite, transform.position, CursorMode.Auto);
                    break;

                case ModeOfCursor.Point:
                    Cursor.SetCursor(switchManager.sisterPOV == false ? alicePoint : constancePoint, transform.position, CursorMode.Auto);
                    break;

                case ModeOfCursor.Click:
                    Cursor.SetCursor(switchManager.sisterPOV == false ? aliceClick : constanceClick, transform.position, CursorMode.Auto);
                    break;
            }
        }

        public enum ModeOfCursor
        {
            Default,
            Point,
            Click
        }
    }
}
