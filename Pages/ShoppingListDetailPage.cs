using MauiReactor;
using MauiReactorShellExample.Models;

namespace MauiReactorShellExample.Pages;

public sealed class ShoppingListDetailPageState
{
    public ShoppingList ShoppingList { get; set; }
}

public sealed class ShoppingListDetailPageProps
{
    public ShoppingList ShoppingList { get; set; }
}

public sealed class ShoppingListDetailPage : Component<ShoppingListDetailPageState, ShoppingListDetailPageProps>
{
    public override VisualNode Render()
    {
        return new ContentPage
        {
            new Label("Welcome to ShoppingListDetailPage")
        }
        .Title(() => State.ShoppingList.Name);
    }


    protected override void OnMounted()
    {
        State.ShoppingList = Props.ShoppingList;
        base.OnMounted();
    }
}