// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const mouseMovesData = [];

function posAndTime(e) {
    const record = {
        x: e.pageX,
        y: e.pageY,
        t: new Date().toLocaleString(),
    };
    
    mouseMovesData.push(record)
}

addEventListener('mousemove', posAndTime, false)

document.getElementById('send-data-button').addEventListener('click', () => {
    fetch('/api/MouseTrack', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(mouseMovesData) // отправляем массив
    })
        .then(response => response.json())
        .then(data => {
            console.log('Данные успешно отправлены:', data);
        })
        .catch(error => {
            console.error('Ошибка при отправке:', error);
        });
});