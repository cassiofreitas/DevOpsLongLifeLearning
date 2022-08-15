#!/bin/bash
#
# This project started as a Python studying path. :-)
# I have a good experience using bash, so, I tried and I succeded deserializing JSON from bash
# I decided to keep this bash version in the project. It helps me to study and it can useful in the future.
#
# This is the first work with Python and JSON APIs (the original project).
#
#My plan is:
#- learn the primitives, to serialize/deserialize JSON.
#- Produce a first version, where I will have BCB, BINANCE, COINGECKO and ETHSCAN APIs consuming.
#- Once I have the backend working, I will develop some WEB frontend, to show me the values.
#
#Motivation:
#- My mindset is to automate repetitive tasks; nowadays, I am getting those informations mannualy.
#- Learn by example; learn by doing.
#- Improve my programming skills.

TODAY=$(date +%m-%d-%Y);
IFS=",";
read cotacaoCompra cotacaoVenda dataHoraCotacao <<< $(curl -H "Accept: application/json" -s "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao='${TODAY}'&$top=100&$format=json&$select=cotacaoCompra,cotacaoVenda,dataHoraCotacao" | jq '.value[0].cotacaoCompra,.value[0].cotacaoVenda,.value[0].dataHoraCotacao' | tr "\n" ",") 
echo $cotacaoCompra $cotacaoVenda $dataHoraCotacao | tr "." ",";
