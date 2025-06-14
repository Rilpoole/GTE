DateTime now =  DateTime.Now;
DateTime epoch = new DateTime(2025, 1, 29);
Console.WriteLine(((int)(now - epoch).TotalSeconds));