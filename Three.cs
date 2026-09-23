// public class Message
// {
// 	public string Recipient { get; set; }
// 	public string Text { get; set; }

// 	public Message(string recipient, string text)
// 	{
// 		Recipient = recipient;
// 		Text = text;
// 	}

// 	public virtual void Send()
// 	{
// 		Console.WriteLine($"Sending to {Recipient}: {Text}");
// 	}
// }

// public class EmailMessage : Message
// {
// 	public string Subject { get; set; }

// 	public EmailMessage(string recipient, string subject, string text) : base(recipient, text)
// 	{
// 		Subject = subject;
// 	}

// 	public override void Send()
// 	{
// 		Console.WriteLine($"EMAIL to {Recipient}");
// 		Console.WriteLine($"Subject: {Subject}");
// 		Console.WriteLine(Text);
// 	}
// }

// public class SmsMessage : Message
// {
// 	public SmsMessage(string phoneNumber, string text) : base(phoneNumber, text) { }

// 	public override void Send()
// 	{
// 		// SMS has a length limit
// 		string shortText = Text.Length > 160 ? Text.Substring(0, 160) : Text;
// 		Console.WriteLine($"SMS to {Recipient}: {shortText}");
// 	}
// }

// public class WarningMessage : Message
// {
// 	public WarningMessage(string recipient, string text) : base(recipient, text) { }

// 	public override void Send()
// 	{
// 		Console.ForegroundColor = ConsoleColor.Red;
// 		Console.Write($"VARNING: ");
// 		base.Send();
// 		Console.ResetColor();
// 	}
// }

// class Program
// {
// 	static void Main(string[] args)
// 	{
// 		List<Message> outbox = new List<Message>
// 		{
// 			new EmailMessage("anna@mail.se", "Welcome!", "Thanks for signing up."),
// 			new SmsMessage("070-123 45 67", "Your code is 4821"),
// 			new Message("admin", "Server restarted"),
// 			new WarningMessage("admin", "Server broken")
// 		};

// 		// Varje meddelande skickas på sitt eget sätt:
// 		foreach (Message message in outbox)
// 		{
// 			message.Send();
// 			Console.WriteLine("----");
// 		}
// 	}
// }