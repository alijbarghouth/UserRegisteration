﻿//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System.Security.Principal;


//namespace UserRegisteration.ActionFilter
//{
//    public class ValidationFilterAttribute : IActionFilter
//    {

//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//            var param = context.ActionArguments.SingleOrDefault(p => p.Value is IEntity);
//            if (param.Value == null)
//            {
//                context.Result = new BadRequestObjectResult("Object is null");
//                return;
//            }

//            if (!context.ModelState.IsValid)
//            {
//                context.Result = new UnprocessableEntityObjectResult(context.ModelState);
//            }
//        }
//        public void OnActionExecuted(ActionExecutedContext context)
//        {
//        }

       
//    }
//}
