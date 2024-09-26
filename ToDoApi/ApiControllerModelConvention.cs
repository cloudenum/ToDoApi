using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ToDoApi
{
    public class ApiControllerModelConvention: IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNamespace = controller.ControllerType.Namespace; // ToDoApi.V1.Controllers
            var apiVersion = controllerNamespace?.Split('.')[1].ToLower(); // v1
            
            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
