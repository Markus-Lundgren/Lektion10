class Program
{
	static void Main(string[] args)
	{
		Ticket ticket = new Ticket("Konsert", 500);
		StudentTicket sTicker = new StudentTicket("Konsert", 300);
		ticket.PrintInfo();
		sTicker.PrintInfo();
	}
}

public class Ticket
{
	public string EventName { get; set; }
	public int BasePrice { get; set; }

	public Ticket(string eventName, int basePrice)
	{
		EventName = eventName;
		BasePrice = basePrice;
	}

	public int GetPrice()
	{
		return BasePrice;
	}

	public void PrintInfo()
	{
		Console.WriteLine($"{EventName}: {GetPrice()} kr");
	}
}

public class StudentTicket : Ticket
{
	public StudentTicket(string eventName, int basePrice) : base(eventName, basePrice)
	{

	}
}