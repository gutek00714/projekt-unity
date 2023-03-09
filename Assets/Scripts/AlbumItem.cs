using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumItem : MonoBehaviour
{
    [SerializeField] private Text idText;
    [SerializeField] private Text titleText;

    public void UpdateAlbumItem(int id, string title)
    {
        idText.text = id.ToString();
        titleText.text = title;
    }
}
