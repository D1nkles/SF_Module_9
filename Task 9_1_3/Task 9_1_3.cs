var myException = new Exception();
myException.Data.Add("Дата создания исключения", DateTime.Now);
Console.WriteLine(myException.Data["Дата создания исключения"]);