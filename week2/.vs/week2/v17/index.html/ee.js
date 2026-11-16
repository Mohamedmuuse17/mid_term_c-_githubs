let players = [
    {name: "Player 1", active: true},
    {name: "Player 2", active: true},
    {name: "Player 3", active: true},
    {name: "Player 4", active: true}
];

let questions = [
    {
        q: "What is the capital of Somalia?",
        options: ["Mogadishu", "Hargeisa", "Kismayo", "Garowe"],
        correct: "Mogadishu"
    },
    {
        q: "How many days are in a week?",
        options: ["5", "6", "7", "8"],
        correct: "7"
    },
    {
        q: "Which planet is known as the Red Planet?",
        options: ["Earth", "Mars", "Venus", "Jupiter"],
        correct: "Mars"
    }
];

let current = 0;
let playerIndex = 0;
let eliminatedCount = 0;

function renderPlayers() {
    document.getElementById("playerList").innerHTML =
        players.map(p => `
            <div class="player">
                <span>${p.name}</span>
                <span class="${p.active ? '' : 'eliminated'}">
                    ${p.active ? '🟢 Active' : '❌ Eliminated'}
                </span>
            </div>
        `).join("");

    document.getElementById("players").textContent =
        players.filter(p => p.active).length;

    document.getElementById("eliminated").textContent =
        eliminatedCount;
}

function answer(value) {
    let active = players.filter(p => p.active);

    if (active.length <= 1) {
        return;
    }

    if (playerIndex >= players.length) {
        return;
    }

    let player = players[playerIndex];

    if (!player || !player.active) {
        return;
    }

    let correct = questions[current].correct;

    if (value.toLowerCase() === correct.toLowerCase()) {
        document.getElementById("result").textContent =
            "✅ Correct answer! " + player.name;
    } else {
        player.active = false;
        eliminatedCount++;

        document.getElementById("result").textContent =
            "❌ " + player.name + " eliminated!";
    }

    playerIndex++;
    renderPlayers();

    if (players.filter(p => p.active).length === 1) {
        let winner = players.find(p => p.active);
        document.getElementById("result").textContent =
            "🏆 Winner: " + winner.name;
    }
}

function nextQuestion() {
    if (players.filter(p => p.active).length <= 1) {
        document.getElementById("result").textContent =
            "The game is finished!";
        return;
    }

    current = (current + 1) % questions.length;
    playerIndex = 0;

    document.getElementById("question").textContent =
        questions[current].q;

    document.getElementById("result").textContent = "";

    document.getElementById("round").textContent =
        Number(document.getElementById("round").textContent) + 1;
}

function startVoice() {
    const SpeechRecognition =
        window.SpeechRecognition ||
        window.webkitSpeechRecognition;

    if (!SpeechRecognition) {
        alert("Please use Google Chrome for Voice Control.");
        return;
    }

    const recognition = new SpeechRecognition();

    recognition.lang = "en-US";
    recognition.interimResults = false;

    document.getElementById("voiceStatus").textContent =
        "🎤 Listening...";

    recognition.onresult = function(event) {
        let spoken = event.results[0][0].transcript;

        document.getElementById("voiceStatus").textContent =
            "You said: " + spoken;

        let options = questions[current].options;

        let found = options.find(option =>
            spoken.toLowerCase().includes(option.toLowerCase())
        );

        if (found) {
            answer(found);
        } else {
            document.getElementById("result").textContent =
                "Answer not recognized. Try again.";
        }
    };

    recognition.onerror = function() {
        document.getElementById("voiceStatus").textContent =
            "Voice error. Try again.";
    };

    recognition.start();
}

function resetGame() {
    players.forEach(p => p.active = true);

    current = 0;
    playerIndex = 0;
    eliminatedCount = 0;

    document.getElementById("round").textContent = 1;
    document.getElementById("question").textContent =
        questions[0].q;

    document.getElementById("result").textContent = "";
    document.getElementById("voiceStatus").textContent =
        "Voice is ready...";

    renderPlayers();
}

renderPlayers();