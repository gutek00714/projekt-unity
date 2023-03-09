using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostItem : MonoBehaviour
{
    [SerializeField] private Text idText; 
    [SerializeField] private Text titleText;
    [SerializeField] private Text bodyText;

    public void UpdatePostItem(int id, string title, string body)
    {
        idText.text = id.ToString();
        titleText.text = title;
        bodyText.text = body;
    }
}