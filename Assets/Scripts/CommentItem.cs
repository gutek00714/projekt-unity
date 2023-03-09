using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentItem : MonoBehaviour
{
    [SerializeField] private Text idText;
    [SerializeField] private Text nameText;
    [SerializeField] private Text emailText;
    [SerializeField] private Text bodyText;

    public void UpdateCommentItem(int id, string name, string email, string body)
    {
        idText.text = id.ToString();
        nameText.text = name;
        emailText.text = email;
        bodyText.text = body;
    }
}