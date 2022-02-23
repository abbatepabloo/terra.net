﻿using Terra.Sdk.Lcd;
using Terra.Sdk.Lcd.Models;

var lcdClientConfig = new LcdClientConfig();
var queryParams = new QueryParams();

// Approach #1
var lcdClient = new LcdClient(lcdClientConfig);
var result = await lcdClient.Bank.Total(queryParams);
var coins = result.Value;
