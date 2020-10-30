using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoKuber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {
        private static readonly int[] id = new[]
        {
            1,2,3,4,5,6
        };

        private static readonly int[] price = new[]
        {
            30,20,40,120,40,30
        };

        private static readonly string[] active = new[]
        {
            "YES","YES","YES","YES","YES","YES"
        };

        private static readonly string[] name = new[]
        {
            "Burger","Cold Drinks","Momo","Rice","Noodles","Rice"
        };
        private static readonly string[] type = new[]
        {
            "Snacks","Drinks","snacks","Lunch","Snacks","Lunch"
        };
        private static readonly string[] Free = new[]
        {
            "No","No","No","Yes","No","Yes"
        };

        private readonly ILogger<MenuItemController> _logger;

        public MenuItemController(ILogger<MenuItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new MenuItem
            {
                Date = DateTime.Now.AddDays(index),
                ItemId = id[rng.Next(id.Length)],
                ItemPrice = price[rng.Next(price.Length)],
                Active = active[rng.Next(active.Length)],
                ItemName = name[rng.Next(name.Length)],
                ItemType = type[rng.Next(type.Length)],
                DeliveryFree = Free[rng.Next(Free.Length)]
            })
            .ToArray();
        }
    }
}
