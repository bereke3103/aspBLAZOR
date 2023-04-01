using Microsoft.AspNetCore.Components;

namespace BlazzingShop.Pages.LearnBlazor
{
    public class LearnBlazorBase : ComponentBase
    {
        protected string name = "Spark";
        protected string WelcomeText = "Time tO learn Blazor!";

        protected void getName()
        {
            name = "Blazor Learner";
        }
    }
}
