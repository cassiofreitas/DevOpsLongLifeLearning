function createAddListeners() {
    let nomeUsuario = document.getElementById('nome');
    nomeUsuario.addEventListener('change', updateDataSet);

    let idadeUsuario = document.getElementById('idade');
    idadeUsuario.addEventListener('change', updateDataSet)

    let botaoCalcular = document.getElementById('botaoCalcular');
    botaoCalcular.addEventListener('click', updateDataSet);
}

function updateDataSet() {
    let showUserName = document.getElementById('h5NomeUsuario');
    let userName = document.getElementById('nome').value;

    let userIdade = document.getElementById('idade').value;
    let msgDataIdade = document.getElementById('informaGeracao');

    userIdade = (userIdade === '') ? 100 : userIdade;
    userName = (userName === '') ? 'Jose Minduim dos Anzois' : userName;

    let dataCorrente = new Date();
    let anoCorrente = dataCorrente.getFullYear();
    let anoNascimento = anoCorrente - userIdade;

    showUserName.innerText = `Olá, ${userName}`;
    msgDataIdade.innerText = `Você nasceu em ${anoNascimento} e pertence a geração ${calculaGeracao(anoNascimento)}.`;
}

function calculaGeracao(anoNascimento) {
    if (anoNascimento < 1946) {
        return "Lost Boys";
    }
    else if (anoNascimento < 1965) {
        return "Baby Boomers";
    }
    else if (anoNascimento < 1981) {
        return "X";
    }
    else if (anoNascimento < 1997) {
        return "Y ou Millennial";
    }
    else if (anoNascimento < 2011) {
        return "Z";
    }
    else if (anoNascimento > 2010) {
        return "Alpha";
    }
}

function getAPIDataFromRickAndMortyCharacters() {
    fetch('https://rickandmortyapi.com/api/character')
        .then((serverResponse) => serverResponse.json())
        .then((JSONresponse) => showAPIListResponseCharacters(JSONresponse));
}

function getAPIDataFromRickAndMortyEpisodes(pageNumber) {
    let baseURL = "https://rickandmortyapi.com/api/episode?page=";
    let pageURL = `${baseURL}${pageNumber}`;

    fetch(pageURL)
        .then((serverResponse) => serverResponse.json())
        .then((JSONresponse) => showAPIListResponseEpisodes(JSONresponse, pageNumber));
}

function getAPIData() {
    fetch('https://jsonplaceholder.typicode.com/posts/')
        .then((serverResponse) => serverResponse.json())
        .then((JSONresponse) => { JSONresponse.map(item => respostaAPI.innerHTML += `<li>${item.title}</li>`) });
}

function showAPIListResponseCharacters(response) {
    response.results.map(item => respostaAPICharacters.innerHTML += `<li class="list-group-item">${item.name}</li>`);
}

function showAPIListResponseEpisodes(response, pageNumber) {
    respostaAPIEpisodes.innerHTML = '';
    respostaAPIEpisodesPagination.innerHTML = '';

    response.results.forEach(
        eachResult => {
            respostaAPIEpisodes.innerHTML += `<li class="list-group-item">${eachResult.name}</li>`;
            console.log(eachResult.id, eachResult.name, eachResult.air_date, eachResult.episode);
            eachResult.characters.forEach(eachCharacter => { console.log(eachCharacter) });
        }
    );

    if (response.info.prev !== null) {
        respostaAPIEpisodesPagination.innerHTML += `<li class="page-item"><a class="page-link" onclick="getAPIDataFromRickAndMortyEpisodes(${response.info.prev});" href="# "">Previous</a></li>`;
    }
    for (let pageItem = pageNumber; pageItem < response.info.pages; pageItem++) {
        respostaAPIEpisodesPagination.innerHTML += `<li class="page-item"><a class="page-link" onclick="getAPIDataFromRickAndMortyEpisodes(${pageItem});" href="#">${pageItem}</a></li>`
    }
    respostaAPIEpisodesPagination.innerHTML += `<li class="page-item"><a class="page-link" onclick="getAPIDataFromRickAndMortyEpisodes(${response.info.pages});">Next</a></li>`;
}

/*
    Here starts what would be my "main" program
*/
createAddListeners();

/*
    This is a good documentation
    Here I would call my functions

getAPIData()
getAPIDataFromRickAndMortyCharacters();
*/
getAPIDataFromRickAndMortyEpisodes(1);
