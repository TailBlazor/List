using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace TailBlazor.List
{
    public partial class TailBlazorList<TItem>
    {
        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<TItem> Items { get; set; }

        [Parameter]
        public string Class { get; set; } = "bg-white shadow-md overflow-hidden sm:rounded-md divide-y divide-gray-200";
    }
}
