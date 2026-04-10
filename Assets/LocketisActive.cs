using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class LocketisActive : MonoBehaviour
{
    [SerializeField] PuzzleControl4 puzzleMan;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled) { Invoke(nameof(SetActive), 2f); }
    }

    void SetActive() {
        puzzleMan.Back4.SetActive(true);

    }

}
