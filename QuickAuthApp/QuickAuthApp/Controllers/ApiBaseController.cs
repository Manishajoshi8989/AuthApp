﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace QuickAuthApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}
