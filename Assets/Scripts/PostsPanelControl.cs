using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;


public class PostsPanelControl : AbstractPanelController
{
    [SerializeField] private PostItem postItemPrefab;
    [SerializeField] private Transform root;
    [SerializeField] private CommentItem commentItemPrefab;

    private List<PostItem> postItems = new List<PostItem>();
    private List<CommentItem> commentItems = new List<CommentItem>();

    private List<Post> posts = new List<Post>
    {
        
    };
    
    private List<Comment> comments = new List<Comment> { };

    protected override async Task OnShow()
    {
        var content= await GetContentFromServer("https://jsonplaceholder.typicode.com/posts");
        var contentcomm= await GetContentFromServer("https://jsonplaceholder.typicode.com/comments");
        posts = Deserialize<List<Post>>(content);
        comments = Deserialize<List<Comment>>(contentcomm);
        
        for (int i = 0; i < posts.Count; i++)
        {
            if (posts[i].UserId == GlobalVariables.userId)
            {
                PostItem postItem = Instantiate(postItemPrefab, root);
                postItem.UpdatePostItem(posts[i].Id, posts[i].Title, posts[i].Body);
                postItems.Add(postItem);
                for (int x = 0; x < comments.Count; x++)
                {
                    if (comments[x].PostId == posts[i].Id)
                    {   
                        CommentItem commentItem = Instantiate(commentItemPrefab, postItem.transform);
                        commentItem.UpdateCommentItem(comments[x].Id, comments[x].Name, comments[x].Email, comments[x].Body);
                        commentItems.Add(commentItem);
                        
                    }
                }
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
        for (int i = postItems.Count -1; i >= 0; i--)
        {
            Destroy(postItems[i].gameObject);
        }
        
        postItems.Clear();
    }

    public void clear()
    {
        for (int i = postItems.Count -1; i >= 0; i--)
        {
            Destroy(postItems[i].gameObject);
        }
        
        postItems.Clear();
    }
}