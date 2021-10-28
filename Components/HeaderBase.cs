using Microsoft.AspNetCore.Components;

namespace Nufi.kyb.v2.Components
{
	public class HeaderBase : ComponentBase
	{
		[Parameter]
		public string index { get; set; }
		[Parameter]
		public int tabSelected { get; set; }
	}
}
