using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

public class AlbumsPanelControl : AbstractPanelController
{
    [SerializeField] private AlbumItem albumItemPrefab;
    [SerializeField] private Transform root;

    private List<AlbumItem> albumItems = new List<AlbumItem>();
    
    private List<Album> album = new List<Album>
    {
        
    };

    protected override async Task OnShow()
    {
        var content= await GetContentFromServer("https://jsonplaceholder.typicode.com/albums");
        album = Deserialize<List<Album>>(content);
        
        for (int i = 0; i < album.Count; i++)
        {
            if (album[i].UserId == GlobalVariables.userId)
            {
                AlbumItem albumItem = Instantiate(albumItemPrefab, root);
                albumItem.UpdateAlbumItem(album[i].Id, album[i].Title);
                albumItems.Add(albumItem);
            }
            
        }
    }
    
    private async Task<string> GetContentFromServer(string path)
    {
        using HttpClient httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(path);
            
        return await response.Content.ReadAsStringAsync();
    }
    
    private T Deserialize<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }

    protected override void OnHide()
    {
        for (int i = albumItems.Count -1; i >= 0; i--)
        {
            Destroy(albumItems[i].gameObject);
        }
        
        albumItems.Clear();
    }

    public void clear()
    {
        for (int i = albumItems.Count -1; i >= 0; i--)
        {
            Destroy(albumItems[i].gameObject);
        }
        
        albumItems.Clear();
    }
}

