using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class Treasurer : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new();
			CustomerProcess customerProcess = new();
			if (req.Amount <= 100000)
			{
				
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Veznedar - Cem Koçak";
				customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Veznedar - Cem Koçak";
				customerProcess.Description = "Para çekme tutarı veznedarın günlük ödeme limitini" +
					" aştığı için işlem Şube Müdürü Yardımcısına yönlendirildi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
