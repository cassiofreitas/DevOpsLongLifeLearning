#!/usr/bin/python3
#
"""
This is the first work with Python and JSON APIs.

My plan is:
- learn the primitives, to serialize/deserialize JSON.
- Produce a first version, where I will have BCB, BINANCE, COINGECKO and ETHSCAN APIs consuming.
- Once I have the backend working, I will develop some WEB frontend, to show me the values.

Motivation:
- My mindset is to automate repetitive tasks; nowadays, I am getting those informations mannualy.
- Learn by example; learn by doing.
- Improve my programming skills.
"""

import json
import requests
from datetime import date

#Creating the URL to call the BCB API, based on date.today()
#Getting the JSON return from BCB
# # 
today = date.today()
bcb_api_url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao='" + str(today.month) + '-' + str(today.day) + '-' + str(today.year) + "'&$top=100&$format=json&$select=cotacaoCompra,cotacaoVenda,dataHoraCotacao"
resp = requests.get(bcb_api_url,headers={'Accept': 'application/json'})
data = json.loads(resp.text)

cotacao_compra = data ['value'][0]['cotacaoCompra']
cotacao_venda = data['value'][0]['cotacaoVenda']
data_hora_cotacao = data['value'][0]['dataHoraCotacao']

print(f"Status code: {resp.status_code}\nCotacao compra: {cotacao_compra}\ncotacao_venda: {cotacao_venda}\ndata_cotacao: {data_hora_cotacao}")
