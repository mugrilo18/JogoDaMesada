using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private NotesSO notesSO;

    private void Start()
    {
        image.sprite = notesSO.noteImage;
    }
}
