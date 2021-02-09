using Microsoft.AspNetCore.Components;

namespace blazor.Shared
{
    public partial class CustomParent : ComponentBase, ISizeable, IThemeable
    {
        [CascadingParameter]
        public ThemeData ParentTheme { get; set; }

        [Parameter]
        public ThemeData Theme { get; set; }

        [CascadingParameter]
        public Size? ParentSize { get; set; }

        [Parameter]
        public Size? Size { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}