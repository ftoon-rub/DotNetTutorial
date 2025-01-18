using DotNetTutorial.DependencyInjection;
using DotNetTutorial.DependencyInjection.Lifecycle;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public DependencyInjectionController(INotificationService notificationService, ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _notificationService = notificationService;
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        // GET api/<DependencyInjectionController>/ConstructorInjection
        [HttpGet]
        [Route("[action]")]
        public IActionResult ConstructorInjection()
        {
            _notificationService.Notify();
            return Ok("test");
        }
        // GET api/<DependencyInjectionController>/MethodInjection
        [HttpGet]
        [Route("[action]")]
        public IActionResult MethodInjection()
        {
            IMessageService messageService = new EmailService();
            _notificationService.NotifyMethodInjection(messageService);
            return Ok("test");
        }
        // GET api/<DependencyInjectionController>/Lifecycle
        [HttpGet]
        [Route("[action]")]
        public IActionResult Lifecycle()
        {
            var singleId = _singletonService.toString();
            var scopedId = _scopedService.toString();
            var transientId = _transientService.toString();
            return Ok($"{singleId}\n{scopedId}\n{transientId}");
        }
    }
}
