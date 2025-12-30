using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages
{
	public partial class EmployeeOverview
	{
		public List<Employee>? Employees { get; set; } = default!;

		protected override void OnInitialized()
		{
			Employees = Services.MockDataService.Employees;
		}
	}
}
