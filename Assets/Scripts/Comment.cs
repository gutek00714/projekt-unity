using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Comment : MonoBehaviour
{
    [JsonProperty("postId")]
    public int PostId { get; set; }
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("body")]
    public string Body { get; set; }

    public Comment (int postId, int id, string name, string email, string body)
    {
        PostId = postId;
        Id = id;
        Name = name;
        Email = email;
        Body = body;
    }
}
