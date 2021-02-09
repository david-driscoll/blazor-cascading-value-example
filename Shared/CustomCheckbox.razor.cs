using Microsoft.AspNetCore.Components;

namespace blazor.Shared
{
    public partial class CustomCheckbox : ComponentBase, ISizeable, IThemeable
    {
        [CascadingParameter]
        public ThemeData ParentTheme { get; set; }
        [Parameter]
        public ThemeData Theme { get; set; }
        [CascadingParameter]
        public Size? ParentSize { get; set; }
        [Parameter]
        public Size? Size { get; set; }
    }
}