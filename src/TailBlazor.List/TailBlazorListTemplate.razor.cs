using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace TailBlazor.List
{
    public partial class TailBlazorListTemplate<TItem>
    {
        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<TItem> Items { get; set; }

        [Parameter]
        public string ListClass { get; set; } = "divide-y divide-gray-200";

        [Parameter]
        public string BodyClass { get; set; } = "bg-white shadow-md overflow-hidden sm:rounded-md";
    }
}
