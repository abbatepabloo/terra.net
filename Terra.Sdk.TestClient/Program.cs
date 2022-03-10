﻿using Newtonsoft.Json;
using Terra.Sdk.Lcd;

void Dump(object value)
{
    var jsonSerializerSettings = new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
    var json = JsonConvert.SerializeObject(value, Formatting.Indented, jsonSerializerSettings);
    Console.WriteLine(json);
}

var client = new LcdClient(new LcdClientConfig
{
    Url = "https://bombay-lcd.terra.dev"
});

var res = await client.Gov.GetProposal(5333);
Console.WriteLine("***Result***");
Dump(res);
