using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Post
{
    [JsonProperty("userId")]
    public int UserId { get; set; }
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("body")]
    public string Body { get; set; }

    public Post(int userId, int id, string title, string body)
    {
        UserId = userId;
        Id = id;
        Title = title;
        Body = body;
    }
}