using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class Manager : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new();
			CustomerProcess customerProcess = new();
			if (req.Amount <= 250000)
			{

				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdürü - Cengiz Kurt";
				customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdürü - Cengiz Kurt";
				customerProcess.Description = "Para çekme tutarı Şube Müdürünün günlük ödeme limitini" +
					" aştığı için işlem Bölge Müdürü Yardımcısına yönlendirildi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
