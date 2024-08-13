using FormulaOne.Client.Services;
using FormulaOne.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaOne.Client.Pages
{
    public partial class DriverDetails
    {

        protected string Message { get; set; }
        protected Driver driver {  get; set; } = new Driver();


        [Parameter]
        public string Id { get; set; }

        [Inject]
        private IDriverService driverService { get; set; }

        [Inject]
        private NavigationManager navigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if(string.IsNullOrEmpty(Id))
            {

            }
            else
            {
                var driverId = Convert.ToInt32(Id);

                var apiDriver = await driverService.GetDriver(driverId);

                if(apiDriver != null)
                {
                    driver = apiDriver;
                }
            }
        }

        protected void HandleFailedRequest()
        {
            Message = "Something went wrong. form not submitted";
        }

        protected void GoToDrivers()
        {
            navigationManager.NavigateTo("/drivers");
        }

        protected async Task DeleteDriver()
        {
            if(!string.IsNullOrEmpty(Id))
            {
                var driverId = Convert.ToInt32(Id);

                var result = await driverService.DeleteDriver(driverId);

                if(result)
                {
                    navigationManager.NavigateTo("/drivers");
                }
                else
                {
                    Message = "Something went wrong, driver not deleted.";
                }
            }
        }

        protected async void HandleValidRequest ()
        {
            if(string.IsNullOrEmpty(Id))
            {
                var result = await driverService.AddDriver(driver);

                if(result != null)
                {
                    navigationManager.NavigateTo("/drivers");
                }
                else
                {
                    Message = "Something went wrong, driver not added.";
                }
            }
            else
            {
                var result = await driverService.UpDateDriver(driver);

                if (result)
                {
                    navigationManager.NavigateTo("/drivers");
                }
                else
                {
                    Message = "Something went wrong, driver not updated.";
                }
            }
        }
    }
}
