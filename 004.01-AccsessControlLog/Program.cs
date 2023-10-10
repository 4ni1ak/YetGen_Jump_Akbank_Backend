using _004._01_AccsessControlLog.Entities;
using System.Text.Json;
using System.Text.Json.Nodes;

var filePath = "C:\\Users\\Bhs\\Desktop\\Yetgen-basvuru\\000.0-Used files\\AccessControlLogs.txt";

var textFile = File.ReadAllText(filePath);

var splitedLines= textFile.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);

List<AccessControlLog> logs = new();

foreach (var splitedLine in splitedLines)
{
    var values= splitedLine.Split("---",StringSplitOptions.RemoveEmptyEntries);

    var accsessControlLog = new AccessControlLog()
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTimeOffset.Now,
        UserId = Convert.ToInt64(values[0]),
        DeviceSerialNo = values[1],
        AccsessType = AccessControlLog.ConvertStringToAccessType(values[2]),
        LogTime = Convert.ToDateTime(values[3])

    };
    logs.Add(accsessControlLog);
}

Console.WriteLine(JsonSerializer.Serialize(logs));

File.WriteAllText("C:\\Users\\Bhs\\Desktop\\Yetgen-basvuru\\000.0-Used files\\AccessControlLogsJson.txt",JsonSerializer.Serialize(logs));

Console.WriteLine("The operation was sucsesfully Comleted.");

Console.ReadLine();
