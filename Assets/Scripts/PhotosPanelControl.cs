// using System.Collections;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using UnityEngine;
//
// public class PhotosPanelControl : AbstractPanelController
// {
//     protected override async void OnShow()
//     {
//         var content= await GetContentFromServer("https://jsonplaceholder.typicode.com/photos");
//         todos = Deserialize<List<Todo>>(content);
//         
//         for (int i = 0; i < todos.Count; i++)
//         {
//             TodoItem todoItem = Instantiate(todoItemPrefab, root);
//             todoItem.UpdateTodoItem(todos[i].Id, todos[i].Title, todos[i].Completed);
//             todoItems.Add(todoItem);
//         }
//     }
//
//     private async Task GetContentFromServer(string httpsJsonplaceholderTypicodeComTodos)
//     {
//         throw new System.NotImplementedException();
//     }
// }
