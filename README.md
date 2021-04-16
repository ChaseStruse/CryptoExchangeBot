# CryptoExchangeBot
Bot that was inspired by Kalle Hallden's video found here: https://www.youtube.com/watch?v=bARCE45FM4s&t=220s
Goal of this bot is to be able to give it a certain amount of money and see if it can post a profit.

## Build Status
[![.NET](https://github.com/ChaseStruse/CryptoExchangeBot/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ChaseStruse/CryptoExchangeBot/actions/workflows/dotnet.yml)

## How to run the project
- Ensure you have .Net 5.x.x installed
- Clone the latest version of the repo
- Using your terminal navigate to the CryptoExchangeBot/CryptoExchangeBot folder
- Run dotnet test, this will ensure all tests are passing
- Run dotnet run, to run the application

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
