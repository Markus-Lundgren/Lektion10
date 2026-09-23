class Program
{
	static void Main()
	{
		List<Contact> list = new List<Contact>();
		Contact p1 = new Contact();
		p1.Name = "Markus Lundgren";
		p1.Phone_Number = "076 - 895 81 43";
		Contact p2 = new Contact();
		p2.Name = "Moa Eriksson";
		p2.Phone_Number = "0706837302";
		Contact p3 = new Contact();
		p3.Name = "Mr. Worldwide";
		p3.Phone_Number = "+46768958144";

		list.Add(p1);
		list.Add(p2);
		list.Add(p3);
		while (true)
		{
			//Console.Clear();
			Console.WriteLine("ADRESSBOK v1");
			Console.WriteLine("------------");
			Console.WriteLine("1) Lägg till kontakt");
			Console.WriteLine("2) Lista kontakter");
			Console.WriteLine("3) Sök efter kontakt");
			Console.WriteLine("4) Uppdatera kontaktnamn");
			Console.WriteLine("5) Avsluta");
			Console.WriteLine();
			int choice = MInput.GetInputAsInt("Val: ");
			switch (choice)
			{
				case 1:
					AddContact(list);
					break;
				case 2:
					ListContacts(list);
					break;
				case 3:
					SearchContact(list);
					break;
				case 4:
					SearchContact(list, true);
					break;
				case 5:
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Ej ett giltigt val");
					break;
			}
		}
	}

	static void AddContact(List<Contact> list)
	{
		Contact person = new Contact();
		person.Name = MInput.GetInput("Namn: ");

		while (true)
		{
			person.Phone_Number = person.ValidatePhoneNumber(MInput.GetInput("Telefonnummer: "));
			if (person.Phone_Number == "ERROR")
			{
				Console.WriteLine($"Detta är inte ett giltigt nummer");
				continue;
			}
			Console.WriteLine($"{person.Phone_Number} är ett giltigt nummer");
			break;
		}

		foreach (Contact c in list)
		{
			if (c.Phone_Number == person.Phone_Number)
			{
				Console.WriteLine("Kontakt finns redan för detta nummer!");
				return;
			}
		}
		list.Add(person);
	}

	static void ListContacts(List<Contact> list)
	{
		int index = 1;
		foreach (Contact p in list)
		{
			Console.WriteLine($"{index++}. Namn: {p.Name} Telefonnummer: {p.FormatPhoneNumber(p.ValidatePhoneNumber(p.Phone_Number))} Id: {p.Id}");
		}
		Console.WriteLine();
	}

	static void SearchContact(List<Contact> list, bool update = false)
	{
		string search = MInput.GetInput("Sök efter en kontakt (namn eller nummer): ");
		bool found = false;
		foreach (Contact c in list)
		{
			string contact = c.ValidatePhoneNumber(c.Phone_Number);
			if (contact.Contains(c.ValidatePhoneNumber(search)))
			{
				found = true;
				Console.WriteLine($"{c.GetPerson()}");
				if (update)
				{
					c.Name = MInput.GetInput("Skriv in det nya nammnet: ");
					Console.WriteLine($"{c.GetPerson()}");
				}
				return;
			}
		}
		if (!found) Console.WriteLine("Hittade ej kontakt");
	}
}

class Entity
{
	public int Id { get; }
	public DateTime
	public Entity()
	{
		Id = Random.Shared.Next(1, 1000000);
	}
}
class Contact : Entity
{
	public string Name { get; set; }
	public string Phone_Number { get; set; }
	public string GetPerson()
	{
		return Name + " - " + Phone_Number;
	}

	public string ValidatePhoneNumber(string number)
	{
		string rawTimmy = number.Replace("+", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty).Trim();
		if (rawTimmy.StartsWith("46"))
			rawTimmy = string.Join(null, ["0", .. rawTimmy[2..]]);

		if (!rawTimmy.StartsWith("07") || rawTimmy.Length != 10)
		{
			return "ERROR";
		}
		else
		{
			return rawTimmy;
		}
	}

	public string FormatPhoneNumber(string num) => num.Insert(8, " ").Insert(6, " ").Insert(3, " - ");


	public string ReverseName()
	{
		string name = string.Empty;
		for (int i = Name.Length - 1; i >= 0; i--)
		{
			name += Name[i];
		}
		return name;
	}
}