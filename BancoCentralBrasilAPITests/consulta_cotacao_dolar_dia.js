// api url
var todayDate = new Date();
var today =
    (todayDate.getMonth()+1).toString().padStart(2,'0') + '-' +
    todayDate.getDate().toString().padStart(2,'0') + '-' +
    todayDate.getFullYear().toString();
//
const api_url =
    "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao='" + today + "'&$top=100&$format=json&$select=cotacaoCompra,cotacaoVenda,dataHoraCotacao"

// Defining async function
async function getapi(url) {
	
	// Storing response
	const response = await fetch(url);
	
	// Storing data in form of JSON
	var data = await response.json();
	console.log(data);
	if (response) {
		hideloader();
	}
	show(data);
}
// Calling that async function
getapi(api_url);

// Function to hide the loader
function hideloader() {
	document.getElementById('loading').style.display = 'none';
}
// Function to define innerHTML for HTML table
function show(data) {
	let cotacaoCompraFormated=(new Intl.NumberFormat('pt-br', { maximumSignificantDigits: 9 }).format(data ['value'][0]['cotacaoCompra']));
	let cotacaoVendaFormated=(new Intl.NumberFormat('pt-br', { maximumSignificantDigits: 9 }).format(data['value'][0]['cotacaoVenda']));

	let tab =
	    `<tr>
			<td colspan='3'>Todays is: ${today}</td>
		</tr>
		<tr>
		    <td>Compra</td>
		    <td>Venda</td>
		    <td>Data</td>
		</tr>
        <tr>
	        <td>${cotacaoCompraFormated}</td>
	        <td>${cotacaoVendaFormated}</td>
	        <td>${data['value'][0]['dataHoraCotacao']}</td>
        </tr>`;
	// Setting innerHTML as tab variable
	document.getElementById("cotacao").innerHTML = tab;
}
