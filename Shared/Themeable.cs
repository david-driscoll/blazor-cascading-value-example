using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

public interface IThemeable
{
    [CascadingParameter]
    public ThemeData ParentTheme { get; set; }

    [Parameter]
    public ThemeData Theme { get; set; }

    public static RenderFragment Render(RenderFragment fragment, ThemeData themeData) => builder => Render(builder, fragment, themeData);

    public static void Render(RenderTreeBuilder builder, RenderFragment fragment, ThemeData themeData)
    {
        if (themeData != null)
        {
            builder.OpenComponent<CascadingValue<ThemeData>>(0);
            builder.AddAttribute(1, "Value", themeData);
            builder.AddAttribute(1, "ChildContent", fragment);
            builder.CloseComponent();
            return;
        }
        fragment(builder);
    }
}
public interface ISizeable
{
    [CascadingParameter]
    public Size? ParentSize { get; set; }

    [Parameter]
    public Size? Size { get; set; }

    public static RenderFragment Render(RenderFragment fragment, Size? size) => builder => Render(builder, fragment, size);

    public static void Render(RenderTreeBuilder builder, RenderFragment fragment, Size? size)
    {
        if (size.HasValue)
        {
            builder.OpenComponent<CascadingValue<Size>>(0);
            builder.AddAttribute(1, "Value", size.Value);
            builder.AddAttribute(1, "ChildContent", fragment);
            builder.CloseComponent();
            return;
        }
        fragment(builder);
    }
}