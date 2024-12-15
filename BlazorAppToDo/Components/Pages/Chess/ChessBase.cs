using BlazorAppToDo.Dto;
using BlazorAppToDo.GameModels;
using BlazorAppToDo.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorAppToDo.Components.Pages.Chess
{
    public class ChessBase : ComponentBase
    { 

        [Inject]
        public required ChessBoard ChessBoard { get; set; }

       
    }
}
