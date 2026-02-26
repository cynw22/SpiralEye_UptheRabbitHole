using UnityEngine;
using UnityEngine.EventSystems;

namespace SwitchingCursor {
    public class CursorSwitch : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {

        [SerializeField] private SwitchingCursor.CursorManager.ModeOfCursor modeOfCursor;

        public void OnPointerEnter(PointerEventData eventdata)
        {
            CursorManager.Instance.SetToMode(CursorManager.ModeOfCursor.Point);
        }

        public void OnPointerExit(PointerEventData eventdata)
        {
            CursorManager.Instance.SetToMode(CursorManager.ModeOfCursor.Default);
        }

        public void OnPointerDown(PointerEventData eventdata)
        {
            CursorManager.Instance.SetToMode(CursorManager.ModeOfCursor.Click);
        }

        public void OnPointerUp(PointerEventData eventdata)
        {
            CursorManager.Instance.SetToMode(CursorManager.ModeOfCursor.Default);
        }

    }
}
