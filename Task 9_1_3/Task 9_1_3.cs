var myException = new Exception("Сообщение об ошибке!!");
myException.Data.Add("Дата создания исключения", DateTime.Now);
myException.HelpLink = "www.youtube.com";
Console.WriteLine(myException.Data["Дата создания исключения"]);