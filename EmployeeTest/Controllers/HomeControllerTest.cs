using Moq;
using WebApiServices.Services.Interfaces;
using Xunit;

namespace EmployeeTest.Controllers
{


    public class HomeControllerTest
    {

        private readonly Mock<IEmployeeService> employeeServiceMock;

        //private readonly HomeController homeController;


        public HomeControllerTest()
        {
            this.employeeServiceMock = new Mock<IEmployeeService>();
        }


        [Fact]
        public void GetEmployees_Exist_ReturnTrue()
        {

            //Arange


            //Act

            //Assert

        }
    }
}
