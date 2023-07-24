using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class AreaDirector : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new();
			CustomerProcess customerProcess = new();
			if (req.Amount <= 400000)
			{

				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Kaymaz";
				customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else 
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Kaymaz";
				customerProcess.Description = "Para çekme tutarı Bölge Müdürünün günlük ödeme limitini" +
					" aştığı için işlem gerçekleştirilemedi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
		}
	}
}
