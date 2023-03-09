// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
//
// public class AlbumsToPhotos : MonoBehaviour
// {
//     [SerializeField] private PhotosPanelControl photosPanelControl;
//     [SerializeField] private AlbumsPanelControl albumsPanelControl;
//
//     [SerializeField] private Button albumButton;
//
//     private void Awake()
//     {
//         albumButton.onClick.AddListener(albumsClicked);
//     }
//
//     private void OnDestroy()
//     {
//         albumButton.onClick.RemoveListener(albumsClicked);
//     }
//
//     private void albumsClicked()
//     {
//         albumsPanelControl.Hide();
//         photosPanelControl.Show();
//     }
// }
