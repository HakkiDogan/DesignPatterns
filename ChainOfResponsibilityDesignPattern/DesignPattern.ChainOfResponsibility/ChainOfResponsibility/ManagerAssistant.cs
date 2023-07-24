using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class ManagerAssistant : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new();
			CustomerProcess customerProcess = new();
			if (req.Amount <= 150000)
			{

				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Derya Küçük";
				customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Derya Küçük";
				customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımcısının günlük ödeme limitini" +
					" aştığı için işlem Şube Müdürüne yönlendirildi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
