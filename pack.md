TOKEN=[TOKEN]  

dotnet build src/RippleDotNet --configuration Release  
dotnet pack src/RippleDotNet --configuration Release  
dotnet nuget push src/RippleDotNet/bin/Release/BTCTrader.RippleDotNet.1.0.1.nupkg --api-key $TOKEN --source "btctrader"  
