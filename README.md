# CryptoExchangeBot

## Build Status
[![.NET](https://github.com/ChaseStruse/CryptoExchangeBot/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ChaseStruse/CryptoExchangeBot/actions/workflows/dotnet.yml)

## Workflow
This section will layout how all the data flows through the program

## What are you working on?
Check the issues section for issues currently being worked on, everything should be tagged

## Technology used
 - .Net 5.0
 - NUnit for Testing

## What determines if a buy should be placed?
Currently Buy() is a method that takes in the an array of doubles and a double which is the last three month highs and the current price. Then using these numbers I find the average of the three months including the current price and if the current price is higher then the moving average Buy() will return true. I am not sure if this is the correct logic.... but I think it is....

Example of the logic:
threeMonthHighs = [.5,1,1.5]
currentPrice = 1.75
moving average = 1.1875

Since the currentPrice (1.75) is greater then the moving average (1.1875) Buy() then returns true. 
