



const API_URL = 'https://debermuda-api.azurewebsites.net/vote/';

let successCount = 0;
let deniedCount = 0;

function vote(value) {


    const vote = { Value: value }

    fetch(API_URL, {
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        method: "POST",
        body: JSON.stringify(vote)
    })
    .then(() => showResults())
    .catch(() => showResults());
}


function loadResults() {
    fetch(API_URL)
        .then((response) => {
            return response.json();
        }).then(results => {

            results.forEach(element => {
                if (element.voteValue) { successCount++ }
                else { deniedCount++ }
            });
        });
}

function showResults() {

    // document.getElementById("message").innerHTML = "Um total de " + successCount + " pessoas podem trabalhar de bermuda. Outras " + deniedCount + " não podem :-(";
    buildChart();
    document.getElementById("results").style.display = "block";

    successCount = 0;
    deniedCount = 0;

    loadResults();
}

function buildChart() {
    var ctx = document.getElementById('myChart');

    data = {
        datasets: [{
            data: [successCount, deniedCount],
            backgroundColor: ["#007bff", "#dc3545"]
        }],

        labels: [
            'Podem',
            'Não podem',
        ]
    };

    var myChart = new Chart(ctx, {
        type: 'doughnut',
        data: data
    });
}

loadResults();