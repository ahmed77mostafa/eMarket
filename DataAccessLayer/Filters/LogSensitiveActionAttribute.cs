//using Microsoft.AspNetCore.Mvc.Filters;
//using System.Diagnostics;

//namespace DataAccessLayer.Filters
//{
//    public class LogSensitiveActionAttribute : ActionFilterAttribute
//    {
//        public override void OnActionExecuted(HttpActionExecutedContext context)
//        {
//            Debug.WriteLine($"Sensitive Action {context.ActionContext.Request.RequestUri} executed at {DateTime.Now}!!!!!!!!!!!!");
//        }
//    }
//}