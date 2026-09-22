// class Program
// {
// 	static void Main(string[] args)
// 	{
// 		Ticket ticket = new Ticket("Konsert", 500);
// 		StudentTicket sTicket = new StudentTicket("Konsert", 500);
// 		VipTicket vip = new VipTicket("Konsert", 500, "A12");

// 		List<Ticket> tickets = [];

// 		tickets.Add(ticket);
// 		tickets.Add(sTicket);
// 		tickets.Add(vip);

// 		int sum = 0;

// 		foreach (Ticket t in tickets)
// 		{
// 			t.PrintInfo();
// 			sum += t.GetPrice();
// 		}
// 		Console.WriteLine($"Summa: {sum} kr");
// 	}
// }

// public class Ticket
// {
// 	public string EventName { get; set; }
// 	public int BasePrice { get; set; }

// 	public Ticket(string eventName, int basePrice)
// 	{
// 		EventName = eventName;
// 		BasePrice = basePrice;
// 	}

// 	public virtual int GetPrice()
// 	{
// 		return BasePrice;
// 	}

// 	public virtual void PrintInfo()
// 	{
// 		Console.WriteLine($"{EventName}: {GetPrice()} kr");
// 	}
// }

// public class StudentTicket : Ticket
// {
// 	public StudentTicket(string eventName, int basePrice) : base(eventName, basePrice)
// 	{

// 	}

// 	public override int GetPrice()
// 	{
// 		return BasePrice * 80 / 100; ;
// 	}
// }

// public class VipTicket : Ticket
// {
// 	public string SeatNumber;
// 	bool IncludesDrink = false;
// 	public VipTicket(string eventName, int basePrice, string seatNumber) : base(eventName, basePrice)
// 	{
// 		SeatNumber = seatNumber;
// 	}
// 	public override int GetPrice()
// 	{
//		int premiumPrice = BasePrice + 300;
// 		if (IncludesDrink)
// 		{
// 			return premiumPrice + 100;
// 		}
// 		return premiumPrice;
// 	}
// 	public override void PrintInfo()
// 	{
// 		base.PrintInfo();
// 		Console.WriteLine($"Plats: {SeatNumber}");
// 	}
// }

// public class ChildTicket : Ticket
// {
// 	public ChildTicket(string eventName, int basePrice) : base(eventName, basePrice) { }

// 	public override int GetPrice()
// 	{
// 		return BasePrice / 2;
// 	}
// }