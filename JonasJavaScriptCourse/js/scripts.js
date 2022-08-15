// The Complete JavaScript Course 2022: From Zero to Expert! - Udemy - Jonas
// Fundamentals - Part 1
function showMyData() {
    let country = 'BR';
    let continent = 'South America';
    let population = 220;

    let respostaTexto = document.getElementById("meuconsole");
    respostaTexto.innerHTML = `<code>${country}<br>${continent}<br>${population}<br></code>`;

    console.log(country);
    console.log(continent);
    console.log(population);
}

// JavaScript demonstration
// https://developer.mozilla.org/pt-BR/docs/Learn/JavaScript/Client-side_web_APIs/Manipulating_documents
function doDemo(button) {
    let square = document.getElementById("square");
    square.style.backgroundColor = "#fa4";
    button.setAttribute("disabled", "true");
    setTimeout(clearDemo, 2000, button);
}

function clearDemo(button) {
    let square = document.getElementById("square");
    square.style.backgroundColor = "transparent";
    button.removeAttribute("disabled");
}

function challengeOne() {
    let square = document.getElementById("meuconsole");
    const markMass = 95;  // kg
    const johnMass = 85;
    const markHeight = 1.88   // meter
    const johnHeight = 1.76

    const markBMI = markMass / (markHeight ** 2);
    const johnBMI = johnMass / (johnHeight ** 2);
    const markHigherBMI = markBMI > johnBMI;

    console.log('Mark', markHeight, markMass, markBMI);
    console.log('John', johnMass, johnHeight, johnBMI);
    console.log('Compare BMI:', markHigherBMI);

    square.innerHTML = `<code>Mark: ${markHeight} ${markMass} ${markBMI}<br>John: ${johnHeight} ${johnMass} ${johnBMI}<br>Is Mark's BMI higher than John's BMI: ${markHigherBMI}</code>`;
  
}