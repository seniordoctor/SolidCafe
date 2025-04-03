using SolidCafe.Services;
using SolidCafe.Utils;

var menuService = new MenuService();
var menu = menuService.GetMenu();
menuService.PrintMenu(menu);

// Logger nesnemiz (şu an için basit bir konsol logger fakat sonradan dosya da olabilir)
// ILogger logger = new ConsoleLogger(); // Console log için kullanılan bir logger
ILogger logger = new FileLogger();

// Siparişi alma
var orderService = new OrderService(logger);
var basket = orderService.TakeOrder(menu);

if (basket.Count == 0)
{
    Console.WriteLine("Hiçbir sipariş verilmedi.");
    logger.Log("Sipariş verilmeden çıkıldı.");
}
else
{
    // Ödeme işlemi
    var paymentService = new PaymentService(logger);
    paymentService.ProcessPayment(basket);
}

var reportService = new ReportService();
reportService.PrintSummary(basket);